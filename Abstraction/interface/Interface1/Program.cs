using System;
using Interface1;
namespace Iterface1;
class Program{
    public static void Main(string[] args)
    {
        Dog dog1 = new Dog();
        dog1.Name="Mojo";
        dog1.Habitat ="house";
        dog1.EatingHabit ="Chicken";
        dog1.Displayname();
        dog1.DisplayInfo();
Console.WriteLine(" ");
        Dog dog2 = new Dog();
        dog2.Name="Gibson";
        dog2.Habitat ="house";
        dog2.EatingHabit ="Chicken,Bones";
        dog2.Displayname();
        dog2.DisplayInfo();

Console.WriteLine(" ");
        Duck duck1 = new Duck();
        duck1.Name = "Ace";
        duck1.Habitat = "Field";
        duck1.EatingHabit = "Grains,insects";
        duck1.Displayname();
        duck1.DisplayInfo();

 Console.WriteLine(" ");
         Duck duck2 = new Duck();
        duck2.Name = "Ace";
        duck2.Habitat = "Field";
        duck2.EatingHabit = "Grains,insects";
        duck2.Displayname();
        duck2.DisplayInfo();
    }
}
