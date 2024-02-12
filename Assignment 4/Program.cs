using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment_4.Program;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("John Doe", "2403 Clair St", "Troy", 33, "Professor", 40000);
            Student student1 = new Student("Mary Jane", "430 Saint Rd", "Troy", 16, 365, "English");
            Customer customer1 = new Customer("Jane Kyo", "403 Sara Ln", "Troy", 42, "C242", "4053 Line Rd");

            Person[] people = new Person[] { employee1, student1, customer1 };

            foreach (var person in people)
            {
                person.DoSomeWork();
            }
            Console.Read();
        }
        public abstract class Person
        {
            
            private string name;
            private string address;
            private string city;
            private int age;
            
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Address
            {
                get { return address; }
                set { address = value; }
            }
            public string City
            {
                get { return city; }
                set { city = value; }

            }
            public int Age
            {
                get { return age; }
                set { age = value; }
            }
            public Person (string name, string address, string city, int age)
            {
                Name = name;
                Address = address;
                City = city;
                Age = age;
            }
            public abstract void DoSomeWork();
        }
        public class Employee : Person
        {
            private string department;
            private int salary;

            public string Department
            {
                get { return department; }
                set { department = value; }
            }
            public int Salary
            {
                get { return salary; }
                set { salary = value; }
            }
            public Employee(string name, string address, string city, int age, string department, int salary) : base(name, address, city, age)
            {
                Department = department;
                Salary = salary;
            }
            public override void DoSomeWork() 
            {
                Console.WriteLine($"Employee Name:{Name} Employee Address: {Address} City: {City} Age: {Age} Employee Department: {Department} Employee Salary: {Salary}");
            }
        }
        public class Student:Person
        {
            private int rollNumber;
            private string studyingClass;

            public int RollNumber
            {
                get { return rollNumber; }
                set { rollNumber = value; }
            }
            public string StudyingClass
            {
                get { return studyingClass; }
                set { studyingClass = value; }
            }
            public Student(string name, string address, string city, int age, int rollNumber, string studyingClass) : base (name, address, city, age)
            {
                RollNumber = rollNumber;
                StudyingClass = studyingClass;
            }
            public override void DoSomeWork()
            {
                Console.WriteLine($"Student Name:{Name} Student Address: {Address} City: {City} Age: {Age} Student Roll: {RollNumber} Class: {StudyingClass}");
            }
        }
        public class Customer:Person
        {
            private string customerId;
            private string shoppingAddress;
            public string CustomerId
            {
                get { return customerId; }
                set { customerId = value; }
            }
            public string ShoppingAddress
            {
                get { return shoppingAddress; }
                set { shoppingAddress = value; }
            }
            public Customer(string name, string address, string city, int age, string customerId, string shoppingAddress) : base (name, address, city, age)
            {
                ShoppingAddress= shoppingAddress;
                CustomerId = customerId;
            }
            public override void DoSomeWork()
            {
                Console.WriteLine($"Customer Name:{Name} Customer Address: {Address} City: {City} Age: {Age} CustomerId: {CustomerId} Shopping Address: {ShoppingAddress}");
            }
        }
    }
}
