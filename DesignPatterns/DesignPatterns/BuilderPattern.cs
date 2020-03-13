using System;

namespace DesignPatterns
{
    internal class BuilderPattern
    {
        static void Main()
        {
            Person person = new PersonBuilder("Mohit")
                .Lives
                .At("Mudhaliar Layout")
                .In("Bangalore")
                .WithPinCode("560035")
                .Works
                .AsA("Software Engineer")
                .In("Siemens")
                .Earns(1000);
            Console.WriteLine(person.ToString());

        }
    }

    internal class Person
    {
        public string Name;//mandatory field.
        public string StreetAddress, City, PinCode;
        public string Designation, CompanyName;
        public int Salary;

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name} \n{nameof(StreetAddress)}: {StreetAddress}, {nameof(City)}: {City}, {nameof(PinCode)}: {PinCode} \n{nameof(Designation)}: {Designation}, {nameof(CompanyName)}: {CompanyName}, {nameof(Salary)}: {Salary}";
        }
    }

    internal class PersonBuilder
    {
        protected Person Person;
        public PersonAddressBuilder Lives => new PersonAddressBuilder(Person);
        public PersonJobBuilder Works => new PersonJobBuilder(Person);
        public PersonBuilder(string personName)
        {
            Person = new Person {Name = personName};
        }

        public Person Build()
        {
            return Person;
        }

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.Person;
        }
    }

    internal class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person) : base(person.Name)
        {
            Person = person;
        }

        public PersonAddressBuilder At(string streetAddress)
        {
            Person.StreetAddress = streetAddress;
            return this;
        }
        public PersonAddressBuilder In(string city)
        {
            Person.City = city;
            return this;
        }
        public PersonAddressBuilder WithPinCode(string pinCode)
        {
            Person.PinCode = pinCode;
            return this;
        }
    }

    internal class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person) : base(person.Name)
        {
            Person = person;
        }

        public PersonJobBuilder AsA(string designation)
        {
            Person.Designation = designation;
            return this;
        }

        public PersonJobBuilder In(string companyName)
        {
            Person.CompanyName = companyName;
            return this;
        }

        public PersonJobBuilder Earns(int salary)
        {
            Person.Salary = salary;
            return this;
        }
    }
}