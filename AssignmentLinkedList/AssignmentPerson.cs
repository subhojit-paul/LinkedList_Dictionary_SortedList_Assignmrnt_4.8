using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLinkedList
{
    public class Person
    {
        public int age;
        public string fname;
        public string lname;
        public string city;

        public Person()
        {

        }
        public Person(int _age,string _fname,string _lname,string _city)
        {
            age = _age;
            fname = _fname;
            lname = _lname;
            city = _city;
        }

        public void DisplayPerson()
        {
            Console.WriteLine("Details of the person");
            Console.WriteLine("first name: {0}",fname);
            Console.WriteLine("Last name: {0}", lname);
            Console.WriteLine("City name: {0}", city);
            Console.WriteLine("Age: {0}", age);

        }


    }




    class AssignmentPerson
    {
        static void Main()
        {
            List<Person> ls = new List<Person>();
            
           Person p1=new Person(25, "subho", "paul", "hyderabad");
            Person p2 = new Person(252, "dipa", "dasbabu", "kolkata");
            Person p3 = new Person(52, "somyajit", "pal", "baranagar");
            Person p4 = new Person(65, "kaka", "mama", "pune");
            Person p5 = new Person(36, "subh", "patra", "chennai");
            ls.Add(p1);
            ls.Add(p2); ls.Add(p3);
            ls.Add(p4);
            ls.Add(p5);


            //Person p = new Person();
            //p.DisplayPerson();
            foreach (Person p in ls)
            {
                p.DisplayPerson();
                //Console.WriteLine(p.DisplayPerson());
            }

            Console.Read();
        }
    }
}
