using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// v prikladu zakomentovanem na konci tohoto souboru pouzijte dedicnost tim nejjednodussim zpusobem
// tam kde jsou prazdne komenty // , tak to znaci co bylo pridano
namespace simpleInheritance
{
    class Person
    {                        //
        public int age;                    //
    }                                    //
    //Employee dedi z Person 
    class Employee : Person
    {          //
        public int salary;                   //
    }                                    //
    // Student dedi z Person
    class Student : Person
    {              //
        public int scholarship;             //
        public Student(int v, int s)
        {
            this.age = v; scholarship = s;
        }
        public void writeInfo()
        {
            Console.WriteLine("věk studenta: " + age + ", scholarship: " + scholarship);
        }
    }
    // Accountant dedi z Employee - vnuk Person
    class Accountant : Employee
    {       //
        public Accountant(int v, int p)
        {
            age = v; salary = p;
        }
        public void writeInfo()
        {
            Console.WriteLine("věk ekonomky: " + age + ", salary: " + salary);
        }
    }
    // Teacher dedi z Employee
    class Teacher : Employee
    {         //
        public int teachingTime;                 //
        public Teacher(int v, int p, int u)
        {
            teachingTime = u;
            salary = p;
            age = v;
        }
        public void writeInfo()
        {
            Console.Write("věk učitele:  " + age + ", salary: " + salary);
            Console.WriteLine(", počet úvazkových hodin: " + teachingTime);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(20, 1000);
            s1.writeInfo();
            Accountant e1 = new Accountant(30, 12000);
            e1.writeInfo();
            Teacher u1 = new Teacher(40, 20000, 22);
            u1.writeInfo();
            Console.ReadLine();

        }
    }
}







//namespace simpleConstructor
//{
//    class Student
//    {
//        public int age, scholarship;

//        // constructor
//        public Student(int vek, int s)
//        {
//            this.age = vek;
//            this.scholarship = s;
//        }
//        // constructor
//        public void writeInfo()
//        {
//            Console.WriteLine("věk studenta: " + age + ", scholarship: " + scholarship);
//        }
//    }
//    class Accountant
//    {
//        public int age, salary;
//        public Accountant(int v, int p)
//        {
//            age = v;
//            salary = p;
//        }
//        public void writeInfo()
//        {
//            Console.WriteLine("věk ekonomky: " + age + ", salary: " + salary);
//        }
//    }

//    class Teacher
//    {
//        public int age, salary, teachingTime;
//        public Teacher(int v, int p, int u)
//        {
//            salary = p;
//            age = v;
//            teachingTime = u;
//        }
//        public void writeInfo()
//        {
//            Console.Write("věk učitele:  " + age + ", salary: " + salary);
//            Console.WriteLine(", počet úvazkových hodin: " + teachingTime);
//        }
//    }


//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // check how this part changed
//            Student s1 = new Student(20, 1000);
//            s1.writeInfo();
//            Accountant e1 = new Accountant(30, 12000);
//            e1.writeInfo();
//            Teacher u1 = new Teacher(40, 20000, 22);
//            u1.writeInfo();
//            Console.ReadLine();
//            // check how this part changed
//        }
//    }
//}
