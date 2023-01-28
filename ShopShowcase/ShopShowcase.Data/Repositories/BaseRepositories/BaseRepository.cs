using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShopShowcase.Common.Factories;
using ShopShowcase.Common.Filters;
using ShopShowcase.Common.Handlers.Generics;
using ShopShowcase.Common.Handlers.Specific;
using ShopShowcase.Common.Requests;
using ShopShowcase.Common.Responses;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ShopShowcase.Data.Repositories.BaseRepositories
{
    public class BaseRepository<TData> : IBaseRepository<TData> where TData : class
    {
        private readonly DbSet<TData> _table;
        private readonly ApplicationDbContext _context;
        private readonly ILogger<BaseRepository<TData>> _logger;

        protected BaseRepository(ApplicationDbContext applicationDbContext, ILogger<BaseRepository<TData>> logger)
        {
            var context = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
            _context = applicationDbContext;
            _logger = logger;
            _table = context.Set<TData>();
        }

        public BaseResponse GetMany(BaseRequest request)
        {
            var amount = int.Parse(request.Payload.ToString()!);
            var origin = $"{GetType().Name}, GetMany";
            var response = ResponseFactory.InitialiseEntity();
            var query = $"SELECT TOP {amount} FROM {typeof(TData).Name}";
            var entities = _table.FromSqlRaw(query);
            response!.Payload = entities;
            _logger.LogInformation(response.GetMessage());
            return response;
        }

        public BaseResponse GetById(BaseRequest request)
        {
            var origin = $"{GetType().Name}, GetId";
            var response = ResponseFactory.InitialiseEntity();
            var query = $"SELECT * WHERE Id = {request.Payload} FROM {typeof(TData).Name}";
            var entity = _table.FromSqlRaw(query);
            response!.Payload = entity;
            _logger.LogInformation(response.GetMessage());
            return response;
        }

        public async Task<BaseResponse> InsertAsync(BaseRequest request)
        {
            var origin = $"{GetType().Name}, InsertAsync";
            var response = ResponseFactory.InitialiseEntity()!;
            var entity = request.Payload.MapTo<TData>();
            await _table.AddAsync(entity);
            response.Payload = _table.Contains(entity);
            _logger.LogInformation(response.GetMessage());
            return response;
        }

        public BaseResponse Update(BaseRequest request)
        {
            var origin = $"{GetType().Name}, Update";
            var response = ResponseFactory.InitialiseEntity()!;
            var entity = request.Payload.MapTo<TData>();
            _table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            response.Payload = _table.Contains(entity);
            _logger.LogInformation(response.GetMessage());
            return response;
        }

        public BaseResponse Delete(BaseRequest request)
        {
            var origin = $"{GetType().Name}, Delete";
            var response = ResponseFactory.InitialiseEntity();
            var entity = (TData)GetById(request).Payload;
            typeof(TData).GetProperties().Where(p => p is { CanWrite: true, CanRead: true } && p.Name.EndsWith("Id") && p.Name != "Id").ToList().ForEach(p => p.SetValue(p, null));
            _table.Remove(entity);
            response!.Payload = !_table.Contains(entity);
            _logger.LogInformation(response.GetMessage());
            return response;
        }

        public async Task<BaseResponse> SaveAsync()
        {
            var origin = $"{GetType().Name}, SaveAsync";
            var response = ResponseFactory.InitialiseEntity();
            var changes = await _context.SaveChangesAsync();
            response!.Payload = changes;
            _logger.LogInformation(response.GetMessage());
            return response;
        }

        public BaseResponse Filter(BaseRequest request)
        {
            var origin = $"{GetType().Name}, Filter";
            var response = ResponseFactory.InitialiseEntity();
            var filter = request.Payload.MapTo<FilteringObject>();
            var propertyName = filter.PropertyName;
            var value = filter.Value;
            var query = $"SELECT TOP {filter.Amount} FROM {typeof(TData).Name} WHERE {propertyName} = '{value}'";
            var all = _table.FromSqlRaw(query);
            response!.Payload = all;
            _logger.LogInformation(response.GetMessage());
            return response;
        }

        public BaseResponse Sort(BaseRequest request)
        {
            var origin = $"{GetType().Name}, Sort";
            var response = ResponseFactory.InitialiseEntity();
            var filter = request.Payload.MapTo<FilteringObject>();
            var propertyName = filter.PropertyName;
            var query = $"SELECT TOP {filter.Amount} ORDER BY {propertyName}";
            var all = _table.FromSqlRaw(query);
            response!.Payload = all;
            _logger.LogInformation(response.GetMessage());
            return response;
        }
    }
}
