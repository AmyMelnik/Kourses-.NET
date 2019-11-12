using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Homwtask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Valera = new Student();
            Student Dick = new Student("Dick","Suka","Blyat");
            Valera.AddDesignMark(8);
            Valera.GetInfo(Valera);
            Console.ReadKey();
        }
    }

    class Student
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private string Second_name { get; set; }
        private string Group { get; set; }
        private int Age { get; set; }
        private int[] ProgMarks = new int[20];
        private int[] AdminMarks = new int[20];
        private int[] DesignMarks = new int[20];
        public int ProgMarkCount = 0;
        public int AdminMarkCount = 0;
        public int DesignMarkCount = 0;
        public Student()
        {
            Name = "Valera";
            Surname = "Valerka";
            Second_name = "Valeriyovich";

            Group = "1";
            Age = 150;
        }
        public Student(string name, string surname, string secondname)
        {
            Name = name;
            Surname = surname;
            Second_name = secondname;
            Group = "2";
            Age = 140;
        }

        public Student(string name, string surname, string secondname, string group, int age)
        {
            Name = name;
            Surname = surname;
            Second_name = secondname;
            Group = group;
            Age = age;
        }

        public void AddProgMark(int mark)
        {
            ProgMarks[ProgMarkCount] = mark;
            ProgMarkCount++;
            Console.WriteLine($"Mark {mark} seted");
        }

        public void AddAdmMark(int mark)
        {
            AdminMarks[AdminMarkCount] = mark;
            AdminMarkCount++;
            Console.WriteLine($"Mark {mark} seted");
        }

        public void AddDesignMark(int mark)
        {
            DesignMarks[DesignMarkCount] = mark;
            DesignMarkCount++;
            Console.WriteLine($"Mark {mark} seted");
        }

        public void GetInfo(Student st)
        {
            Console.WriteLine(st);
            Console.Write("Programing marks:");
            for (int i = 0; i < st.ProgMarkCount; i++)
            {
                Console.Write($"{st.ProgMarks[i]}, ");
            }

            Console.Write("\nAdministration Marks:");
            for (int i = 0; i < st.AdminMarkCount; i++)
            {
                Console.Write($"{st.AdminMarks[i]}, ");
            }
            Console.Write("\nDesign Marks:");
            for (int i = 0; i < st.DesignMarkCount; i++)
            {
                Console.WriteLine($"{st.DesignMarks[i]}, ");
            }
        }
        public override string ToString()
        {
            return $"Name: {Name}\n Surname:{Surname}\n Secondname: {Second_name}\n Group: {Group}\n Age: {Age}\n ";
        }
    }
}
