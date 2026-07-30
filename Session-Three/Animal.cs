using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Three
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public abstract void MakeSound();
    }

    public interface IRunnable
    {
        void Run();
    }

    public class Cat : Animal, IRunnable
    {
        public Cat(string name, int age) : base(name,age)
        {
            
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }

    public class Dog : Animal,IRunnable
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }

    public class lion : Animal,IRunnable 
    {
        public lion(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Roar");
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
