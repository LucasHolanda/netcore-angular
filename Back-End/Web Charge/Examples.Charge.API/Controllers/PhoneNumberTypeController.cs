using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using System.Threading.Tasks;
using Examples.Charge.Application.Dtos;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneNumberTypeController : BaseController
    {
        private IPhoneNumberTypeFacade _facade;

        private IMapper _mapper;
        public PhoneNumberTypeController(IPhoneNumberTypeFacade facade, IMapper mapper)
        {
            _facade = facade;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<PhoneNumberTypeResponse>> Get() => Response(await _facade.FindAllAsync());
    }
}
