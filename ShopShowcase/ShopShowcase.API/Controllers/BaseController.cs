using Microsoft.AspNetCore.Mvc;
using ShopShowcase.Common.Factories;
using ShopShowcase.Common.Filters;
using ShopShowcase.Common.Requests;
using ShopShowcase.Common.Validators;
using ShopShowcase.Services.Services.BaseService;
using System.Threading.Tasks;
using static ShopShowcase.Common.Constants.ConsumeTypes;

namespace ShopShowcase.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Consumes(DefaultConsumeType)]
    public class BaseController<TService, TValidator, TFactory, TClass, TData> : ControllerBase where TService : IBaseService<TFactory, TValidator, TClass, TData> where TClass : class where TFactory : BaseFactory<TValidator, TClass> where TValidator : BaseValidator<TClass>
    {
        protected readonly TService _service;

        public BaseController(TService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetMany(new BaseRequest()));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(string id)
        {
            var request = new BaseRequest
            {
                Payload = id
            };
            return Ok(_service.Get(request));
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromForm] TClass @class)
        {
            var request = new BaseRequest
            {
                Payload = @class
            };
            var response = await _service.AddAsync(request);
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Edit([FromForm] TClass @class)
        {
            var request = new BaseRequest
            {
                Payload = @class
            };
            var response = _service.Update(request);
            return Ok(response);
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            var request = new BaseRequest
            {
                Payload = id
            };
            return Ok(_service.Remove(request));
        }

        [HttpGet]
        public IActionResult Filter(FilteringObject filteringObject)
        {
            var request = new BaseRequest
            {
                Payload = filteringObject
            };
            return Ok(_service.GetFiltered(request));
        }

        [HttpGet]
        public IActionResult Sorting(FilteringObject filteringObject)
        {
            var request = new BaseRequest
            {
                Payload = filteringObject
            };
            return Ok(_service.GetSorted(request));
        }
    }
}
