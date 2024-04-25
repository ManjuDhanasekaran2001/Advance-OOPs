using System;
namespace ValueAndReferenceType;
class Program{
    public void Main(string[] args)
    {
        int number1 = 10;
        
        Console.WriteLine(number1);
        int number2 = number1;
        Console.WriteLine(number2);
        number1 =20;
        Console.WriteLine(number2);

        Student student1 = new Student();
        student1.Name="Manju";
        Console.WriteLine(student1.Name);

        Student student2 = student1;
        
        Console.WriteLine(student2.Name);

        student1.Name="sakila";
        Console.WriteLine(student1.Name);
         Console.WriteLine(student2.Name);


    }
}