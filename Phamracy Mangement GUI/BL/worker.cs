using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phamracy_Mangement_GUI.BL
{
    public class worker
    {
        private int salary;
        private int age;
        private string personName;
        private string religion;
        private string post;

        public string PersonName { get => personName; set => personName = value; }
        public int Age { get => age; set => age = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Post { get => post; set => post = value; }
        public string Religion { get => religion; set => religion = value; }

        public string getPersonName() => PersonName;
        public string getReligion() => Religion;
        public string getPost() => Post;
        public int getSalary() => Salary;
        public int getAge() => Age;
        //--------------------------seter---------------------------------
        //public string getPersonName(string personName) => this.PersonName = personName;
        //public string getReligion(string religion) => this.Religion = religion;
        //public string getPost(string post) => this.Post = post;
        //public int getSalary(int salary) => this.Salary = salary;
        //public int getAge(int age) => this.Age = age;
        public worker(int salary, int age, string person_name, string religion, string post)
        {
            this.Salary = salary;
            this.PersonName = person_name;
            this.Religion = religion;
            this.Post = post;
            this.Age = age;
            this.PersonName = personName;
        }
        public worker(string personName, int age)
        {
            Salary = 0;
            age = 0;
            personName = "";
            Religion = "";
            Post = "";
            this.PersonName = personName;
            this.Age = age;
        }
    }
}
