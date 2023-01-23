using Microsoft.Extensions.Logging;
using ShopShowcase.Common;
using ShopShowcase.Data.Repositories.BaseRepositories;
using System.Linq;
using System.Threading.Tasks;

namespace ShopShowcase.Services.Services.BaseService
{
    public abstract class BaseService<TFactory, TClass> : IBaseService where TClass : class where TFactory : BaseFactory<TClass>
    {
        protected readonly IBaseRepository _repository;

        protected readonly TFactory _factory;

        protected readonly BaseValidator _validator;

        protected readonly ILogger<BaseService<TFactory, TClass>> _logger;

        protected BaseService(IBaseRepository repository, TFactory factory, ILogger<BaseService<TFactory, TClass>> logger)
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
            _factory.Validator.Validate(response);
            _logger.LogInformation(response.GetMessage());
            return response;
        }

        public BaseResponse Remove(BaseRequest request)
        {
            var origin = $"{this.GetType().Name}, Remove";
            request.Origin = origin;
            var response = _repository.Delete(request);
            _factory.Validator.Validate(response);
            _logger.LogInformation(response.GetMessage());
            return response;
        }

        public BaseResponse Update(BaseRequest request)
        {
            var origin = $"{this.GetType().Name}, Update";
            request.Origin = origin;
            var response = _repository.Update(request);
            _factory.Validator.Validate(response);
            _logger.LogInformation(response.GetMessage());
            return response;
        }

        public BaseResponse Get(BaseRequest request)
        {
            var origin = $"{this.GetType().Name}, Get";
            var response = ResponseFactory.InitialiseEntity();
            request.Origin = origin;
            _factory.Validator.Validate(request.Payload);
            if (_validator.HasErrors)
                response.Errors = _validator.Errors.ToList();
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
            _factory.Validator.Validate(response);
            _logger.LogInformation(response.GetMessage());
            return response;
        }

        public BaseResponse GetSorted(BaseRequest request)
        {
            var origin = $"{this.GetType().Name}, GetSorted";
            request.Origin = origin;
            var response = _repository.Sort(request);
            _factory.Validator.Validate(response);
            _logger.LogInformation(response.GetMessage());
            return response;

        }

        public BaseResponse GetFiltered(BaseRequest request)
        {
            var origin = $"{this.GetType().Name}, GetSorted";
            request.Origin = origin;
            var response = _repository.Filter(request);
            _factory.Validator.Validate(response);
            _logger.LogInformation(response.GetMessage());
            return response;
        }
    }
}
