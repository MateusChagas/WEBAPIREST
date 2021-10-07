using System;
using System.Collections.Generic;
using System.Linq;
using WEBAPIREST.Model;
using WEBAPIREST.Model.MySqlContext;
using WEBAPIREST.Repository;

namespace WEBAPIREST.Business.Implementations
{
    public class PersonBusinessimplementation : IPersonBusiness
    {

        private readonly IPersonRepository _repository;
        public PersonBusinessimplementation(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person Create(Person person)
        {

            return _repository.Create(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            return _repository.FindAll();
        }


        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);

        }       
    }
}
