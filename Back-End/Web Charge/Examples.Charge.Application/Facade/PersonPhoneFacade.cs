using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Facade
{
    public class PersonPhoneFacade : IPersonPhoneFacade
    {
        private readonly IPersonPhoneService _service;
        private readonly IMapper _mapper;

        public PersonPhoneFacade(IPersonPhoneService personPhoneService, IMapper mapper)
        {
            _service = personPhoneService;
            _mapper = mapper;
        }

        public async Task<PersonPhoneResponse> Delete(int id, int idType)
        {
            var result = await _service.Delete(id, idType);

            var response = new PersonPhoneResponse();
            response.Person = _mapper.Map<PersonPhoneDto>(result);
            return response;
        }

        public async Task<PersonPhoneResponse> FindAllAsync()
        {
            var result = await _service.FindAllAsync();
            var response = new PersonPhoneResponse();
            response.PersonObjects = new List<PersonPhoneDto>();
            response.PersonObjects.AddRange(result.Select(x => _mapper.Map<PersonPhoneDto>(x)));
            return response;
        }

        public async Task<PersonPhoneResponse> Insert(PersonPhoneRequest dto)
        {
            var result = await _service.Insert(_mapper.Map<PersonPhone>(dto));

            var response = new PersonPhoneResponse();
            response.Person = _mapper.Map<PersonPhoneDto>(result);
            return response;
        }

        public async Task<PersonPhoneResponse> Update(PersonPhoneRequest dto)
        {
            var result = await _service.Update(_mapper.Map<PersonPhone>(dto));

            var response = new PersonPhoneResponse();
            response.Person = _mapper.Map<PersonPhoneDto>(result);
            return response;
        }
    }
}
