using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactForm
{
    public enum Gender { Male, Female };
    public class Person
    {
        public string Name { get; set; }
        public string HeadshotUrl { get; set; }
        public string Email { get; set; }
        public DateTime Dob { get; set; }
        public Gender Gender { get; set; }
        public bool IsFavorite { get; set; }

        public override string ToString()
        {
            return string.Format("Name={0}, Email={1}, Dob={2}, Gender={3}, IsFavorite={4}", this.Name, this.Email, this.Dob, this.Gender, this.IsFavorite);
        }
    }
    public class SimpsonFactory
    {
        public static Person GetPerson()
        {
            return new Person
            {
                Name = "Homer Simpson",
                Email = "homer@gmail.com",
                Gender = Gender.Male,
                HeadshotUrl = "Homer.gif",
                IsFavorite = false,
                Dob = new DateTime(1999,12,1)
            };
        }

    }
}
