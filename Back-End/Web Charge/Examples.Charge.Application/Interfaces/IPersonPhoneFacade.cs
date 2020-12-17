
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Examples.Charge.Application.Interfaces
{
    public interface IPersonPhoneFacade
    {
        Task<PersonPhoneResponse> FindAllAsync();
        Task<PersonPhoneResponse> Insert(PersonPhoneRequest dto);
        Task<PersonPhoneResponse> Update(PersonPhoneRequest dto);
        Task<PersonPhoneResponse> Delete(int id, int idType);

    }
}