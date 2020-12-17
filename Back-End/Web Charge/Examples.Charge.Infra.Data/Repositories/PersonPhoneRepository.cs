using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PersonPhoneRepository : IPersonPhoneRepository
    {
        private readonly ExampleContext _context;

        public PersonPhoneRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<PersonPhone>> FindAllAsync() => await Task.Run(() => _context.PersonPhone.Include(x => x.PhoneNumberType).Include(p => p.Person));

        public Task<PersonPhone> Insert(PersonPhone entity)
        {
            _context.PersonPhone.Add(entity);
            _context.SaveChanges();

            return Task.Run(() => entity);
        }

        public Task<PersonPhone> Update(PersonPhone entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();

            return Task.Run(() => entity);
        }

        public Task<PersonPhone> Delete(int id, int idType)
        {
            var entity = _context.PersonPhone.FirstOrDefault(x => x.BusinessEntityID == id && x.PhoneNumberTypeID == idType);
            _context.PersonPhone.Remove(entity);
            _context.SaveChanges();

            return Task.Run(() => entity);
        }
    }
}
