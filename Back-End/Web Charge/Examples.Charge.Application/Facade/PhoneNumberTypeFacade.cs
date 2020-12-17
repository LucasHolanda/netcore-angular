using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Facade
{
    public class PhoneNumberTypeFacade : IPhoneNumberTypeFacade
    {
        private readonly IPhoneNumberTypeService _PhoneNumberTypeService;
        private readonly IMapper _mapper;

        public PhoneNumberTypeFacade(IPhoneNumberTypeService PhoneNumberTypeService, IMapper mapper)
        {
            _PhoneNumberTypeService = PhoneNumberTypeService;
            _mapper = mapper;
        }

        public async Task<PhoneNumberTypeResponse> FindAllAsync()
        {
            var result = await _PhoneNumberTypeService.FindAllAsync();
            var response = new PhoneNumberTypeResponse();
            response.PhoneNumberTypeObjects = new List<PhoneNumberTypeDto>();
            response.PhoneNumberTypeObjects.AddRange(result.Select(x => _mapper.Map<PhoneNumberTypeDto>(x)));
            return response;
        }
    }
}
