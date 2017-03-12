using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program : Aritra.Aritra
    {
        public Program(string name, int age) : base(name, age)
        {
        }

        public static void Main()
        {
            Console.WriteLine("Hello There !!! {0} and {1} !!!", "Aritra", "Sumi");
            Aritra.Aritra aritra = new Aritra.Aritra("Aritra", 22);
            aritra.displayDetails();
            Aritra.Sumi sumi = new Aritra.Sumi("Sumi", 23);
            sumi.displayDetails();
            Main.Another ano = new Main.Another();
            ano.setAnother("Ano", 25);
            ano.display();
            Aritra.Another another = new Aritra.Another();
            another.setAnother("Another", 22);
            another.display();
            Console.ReadKey();
        }
    }

    class Another
    {
        string name;
        int age;

        public void setAnother(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void display()
        {
            Console.WriteLine("{0}'s age is {1}", name, age);
        }
    }
}

namespace Aritra
{
    public class Aritra
    {
        string name;
        int age;

        public Aritra(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void displayDetails()
        {
            Console.WriteLine("{0}'s age is {1}", name, age);
        }
    }

    public class Sumi : Aritra
    {
        public Sumi(string name, int age) : base(name, age)
        {
        }
    }

    class Another : Main.Another
    {

    }

}