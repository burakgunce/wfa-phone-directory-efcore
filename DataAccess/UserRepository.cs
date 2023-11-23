using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserRepository
    {
        public UserRepository()
        {
            db = new PhoneDirectoryContext();
        }
        PhoneDirectoryContext db;
        public void Add(Person person)
        {
            db.Add(person);
            db.SaveChanges();
        }
        public void Update(Person person, string name, string surname, string phone)
        {

            person.Name = name;
            person.Surname = surname;
            person.PhoneNumber = phone;
            db.Update(person);
            db.SaveChanges();
        }

        public List<Person> GetAll()
        {

            var userList = db.Persons.ToList();
            return userList;
        }

        public List<Person> GetByNameOrSurname(string word)
        {

            var userList = db.Persons.Where(u => u.Name.Contains(word) || u.Surname
            .Contains(word)).ToList();
            return userList;
        }

        public Person GetById(int id)
        {
            Person person = db.Persons.FirstOrDefault(p => p.ID == id);
            return person;
        }
    }
}
