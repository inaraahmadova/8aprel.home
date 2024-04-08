using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _8aprel.home
{
    internal class Student:ICodeAcademy
    {
        static int Count = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodeEmail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Id = ++Count;
            GenerateEmail();
        }

        public static void CheckName(string name)
        {
            if (name.Length < 3)
            {
                Console.WriteLine("Ad en az 3 herfden ibaret olmalidir.");
            }
            else
            {
                Console.WriteLine("Ad uygundur.");
            }
        }

        public string GenerateEmail()
        {
            string email = $"{Name.ToLower()}.{Surname.ToLower()}{Id}@code.edu.az";
            return email;
        }

        void ICodeAcademy.GenerateEmail()
        {
            throw new NotImplementedException();
        }
    }
}
