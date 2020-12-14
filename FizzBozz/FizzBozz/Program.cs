using System;
using MyLib;

namespace FizzBozz
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.Write("Введи свое имя:\t");
            p.Name = Console.ReadLine();

            Console.Write("Введи свой возраст:\t");
            p.Age = Int32.Parse(Console.ReadLine());
            
            string personMame = p.Name;
            int personAge = p.Age;
            
            Display(Checked(ref personAge), personMame, personAge);
            
        }

        class Person
        {
            private string name;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            private int age;

            public int Age
            {
                set
                {
                    if (value < 18)
                    {
                        Console.WriteLine($"Твой возраст {value}, доступ разрешен только с 18 лет.");
                    }
                    else
                    {
                        age = value;
                    }
                }

                get { return age; }
            }

        }

        static bool Checked(ref int b)
        {
            if (b >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        static void Display(bool z, string name, int age)
        {
            if (z == true)
            {
                Console.WriteLine("Доступ разрешен!");
                Console.WriteLine($"Твое имя:{name}, твой возраст:{age} ");
            }
            else
            {
                Console.WriteLine("Доступ запрещен!");
            }
        }




    }
   
}
