/*
    ------------------------------- To Do List ----------------------------------------------
        1. Class : How to implement Class?
        2. Object: How to create Object?    
        3. Fields Vs Properties: What is the difference between them?
            Auto Property
            Read-only Property
            Private Setter
        4.Constructor && Parameterized Constructor
        5. this Keyword
        6. Inheritance
        7. Access Modifiers
        8. Types of Polymorphism
            - Method Overloading (Compile-Time)
            - Method Overloading (Compile-Time)
            - Method Overriding (Run-Time) [Virtual & Override KeyWords]
        9. Abstract Class vs Interface
        10. Static Members
 */
namespace Session_Three;

struct Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var cat = new Cat("Cat", 12);



        Console.WriteLine(cat.Age);
    }
}
