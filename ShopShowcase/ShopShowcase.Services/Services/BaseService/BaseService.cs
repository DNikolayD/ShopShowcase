using Microsoft.Extensions.Logging;
using ShopShowcase.Common.Factories;
using ShopShowcase.Common.Handlers.Generics;
using ShopShowcase.Common.Handlers.Specific;
using ShopShowcase.Common.Requests;
using ShopShowcase.Common.Responses;
using ShopShowcase.Common.Validators;
using ShopShowcase.Data.Repositories.BaseRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopShowcase.Services.Services.BaseService
{
    public class BaseService<TFactory, TValidator, TClass, TData> : IBaseService<TFactory, TValidator, TClass, TData> where TClass : class where TFactory : BaseFactory<TValidator, TClass> where TValidator : BaseValidator<TClass>
    {
        protected readonly IBaseRepository<TData> _repository;

        protected readonly TFactory _factory;

        protected readonly TValidator _validator;

        protected readonly ILogger<BaseService<TFactory, TValidator, TClass, TData>> _logger;

        protected BaseService(IBaseRepository<TData> repository, TFactory factory, ILogger<BaseService<TFactory, TValidator, TClass, TData>> logger)
        {
            _repository = repository;
            _factory = factory;
            _logger = logger;
            _validator = _factory.Validator;
        }

        public async Task<BaseResponse> AddAsync(BaseRequest request)
        {
            const string fileName = "ResponseOfIBaseRepositoryInsertAsync.txt";
            var origin = $"{this.GetType().Name}, AddAsync";
            request.Origin = origin;
            var response = await _repository.InsertAsync(request);
            var text = response.Extract();
            await FileHandler.HandleTextFilesForMocking(string.Empty, fileName, text);
            _validator.Validate(response.Payload.MapTo<TClass>());
            response.Errors = _validator.Errors;
            _logger.LogInformation(response.GetMessage());
            return response;
        }

        public BaseResponse Remove(BaseRequest request)
        {
            var origin = $"{this.GetType().Name}, Remove";
            request.Origin = origin;
            var response = _repository.Delete(request);
            _validator.Validate(response.Payload.MapTo<TClass>());
            response.Errors = _validator.Errors;
            _logger.LogInformation(response.GetMessage());
            return response;
        }

        public BaseResponse Update(BaseRequest request)
        {
            var origin = $"{this.GetType().Name}, Update";
            request.Origin = origin;
            var response = _repository.Update(request);
            _validator.Validate(response.Payload.MapTo<TClass>());
            response.Errors = _validator.Errors;
            _logger.LogInformation(response.GetMessage());
            return response;
        }

        public BaseResponse Get(BaseRequest request)
        {
            var origin = $"{this.GetType().Name}, Get";
            var response = ResponseFactory.InitialiseEntity();
            request.Origin = origin;
            _validator.Validate(request.Payload.MapTo<TClass>());
            if (_validator.HasErrors)
                response.Errors = _validator.Errors;
            else
                response = _repository.GetById(request);
            _logger.LogInformation(response.GetMessage());
            return response;
        }

        public BaseResponse GetMany(BaseRequest request)
        {
            var origin = $"{this.GetType().Name}, GetMany";
            request.Origin = origin;
            var response = _repository.GetMany(request);
            foreach (var @class in response.Payload.MapTo<List<TClass>>())
            {
                _validator.Validate(@class);
            }

            response.Errors = _validator.Errors;
            _logger.LogInformation(response.GetMessage());
            return response;
        }

        public BaseResponse GetSorted(BaseRequest request)
        {
            var origin = $"{this.GetType().Name}, GetSorted";
            request.Origin = origin;
            var response = _repository.Sort(request);
            foreach (var @class in response.Payload.MapTo<List<TClass>>())
            {
                _validator.Validate(@class);
            }

            response.Errors = _validator.Errors;
            _logger.LogInformation(response.GetMessage());
            return response;

        }

        public BaseResponse GetFiltered(BaseRequest request)
        {
            var origin = $"{this.GetType().Name}, GetSorted";
            request.Origin = origin;
            var response = _repository.Filter(request);
            foreach (var @class in response.Payload.MapTo<List<TClass>>())
            {
                _validator.Validate(@class);
            }
            response.Errors = _validator.Errors;
            _logger.LogInformation(response.GetMessage());
            return response;
        }
    }
}
