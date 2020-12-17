using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonPhoneRepository
    {
        Task<IEnumerable<PersonPhone>> FindAllAsync();
        Task<PersonPhone> Insert(PersonPhone entity);
        Task<PersonPhone> Update(PersonPhone entity);
        Task<PersonPhone> Delete(int id, int idType);
        
    }
}
