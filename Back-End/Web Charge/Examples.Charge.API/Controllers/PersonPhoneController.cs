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
    public class PersonPhoneController : BaseController
    {
        private IPersonPhoneFacade _facade;

        private IMapper _mapper;
        public PersonPhoneController(IPersonPhoneFacade facade, IMapper mapper)
        {
            _facade = facade;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<PersonPhoneResponse>> Get() => Response(await _facade.FindAllAsync());

        [HttpPost]
        public async Task<ActionResult<PersonPhoneResponse>> Post([FromBody] PersonPhoneRequest request) => Response(await _facade.Insert(_mapper.Map<PersonPhoneRequest>(request)));

        [HttpPut]
        public async Task<ActionResult<PersonPhoneResponse>> Put([FromBody] PersonPhoneRequest request) => Response(await _facade.Update(_mapper.Map<PersonPhoneRequest>(request)));

        [HttpDelete("{id}/{idType}")]
        public async Task<ActionResult<PersonPhoneResponse>> Delete(int id, int idType) => Response(await _facade.Delete(id, idType));
    }
}
