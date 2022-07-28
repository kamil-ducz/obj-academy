using System.ComponentModel.DataAnnotations;

namespace CollectionTools.Console.Persons.Models
{
    public class Person
    {
        [Required, MinLength(2)]
        public string? Name { get; set; }
        [Required, RangeAttribute(0,100)]
        public int Age { get; set; }

        public Person(string? name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
