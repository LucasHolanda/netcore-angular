﻿using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ExampleContext _context;

        public PersonRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Person>> FindAllAsync() => await Task.Run(() => _context.Person);

        public async Task<Person> FindByIdAsync(int id) => await Task.Run(() => _context.Person.FirstOrDefault(x => x.BusinessEntityID == id));

        public Task<Person> Insert(Person entity)
        {
            _context.Person.Add(entity);
            _context.SaveChanges();

            return Task.Run(() => entity);
        }
    }
}
