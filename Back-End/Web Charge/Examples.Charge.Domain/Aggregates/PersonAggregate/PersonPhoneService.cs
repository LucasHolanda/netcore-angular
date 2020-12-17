using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate
{
    public class PersonPhoneService : IPersonPhoneService
    {
        private readonly IPersonPhoneRepository _repository;
        public PersonPhoneService(IPersonPhoneRepository personPhoneRepository)
        {
            _repository = personPhoneRepository;
        }

        public async Task<PersonPhone> Delete(int id, int idType) => (await _repository.Delete(id, idType));

        public async Task<List<PersonPhone>> FindAllAsync() => (await _repository.FindAllAsync()).ToList();

        public async Task<PersonPhone> Insert(PersonPhone entity) => (await _repository.Insert(entity));

        public async Task<PersonPhone> Update(PersonPhone entity) => (await _repository.Update(entity));
    }
}
