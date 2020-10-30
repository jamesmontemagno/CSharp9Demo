using System;
using System.Text.Json;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person("James", "Montemagno");
            var p2 = new Person("Maddy", "Leger");


            var json = JsonSerializer.Serialize(p1);
            Console.WriteLine(json);
            var p3 = JsonSerializer.Deserialize<Person>(json);
            var isEqual = p1 == p3;
            Console.WriteLine($"p1 == p3: {isEqual}");

            var (firstName, lastName) = p1;
            Console.WriteLine($"{lastName}, {firstName}");

            Console.WriteLine($"Is Maddy in chat {IsInChat(p2)}");
        }

        private static bool IsInChat(Person p) => p switch
        {
            ("James", "Montemagno") => true,
            ("Maddy", "Leger") => true,
            _ => false
        };
    }

    record Person(string FirstName, string LastName);

    //public class Person : IEquatable<Person>
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public Person (string firstName, string lastName)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //    }

    //    public void Deconstruct(out string firstName, out string lastName)
    //    {
    //        firstName = FirstName;
    //        lastName = LastName;
    //    }

    //    public bool Equals(Person obj)
    //    {
    //        return obj is Person person &&
    //               FirstName == person.FirstName &&
    //               LastName == person.LastName;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return HashCode.Combine(FirstName, LastName);
    //    }

    //    public override string ToString()
    //    {
    //        return base.ToString();
    //    }

    //    public static bool operator ==(Person left, Person right)
    //    {
    //        return left.Equals(right);
    //    }

    //    public static bool operator !=(Person left, Person right)
    //    {
    //        return !(left == right);
    //    }

    //    public override bool Equals(object obj)
    //    {
    //        return obj is Person && Equals((Person)obj);
    //    }
    //}
}
