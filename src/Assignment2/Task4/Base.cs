using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Id { get; private set; }
        public string id;

        public Base()
        {
            Id = id;
        }

        public Base(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

       
        public virtual void GenerateId()
        {
            Id =  DateTime.Now.Ticks.ToString();
        }

    }
}
