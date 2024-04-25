using System;

namespace Interface1
{
    public class Dog :IAnimal
    {
        private string _name;
        public string Name {get{return _name;}set{_name=value;}}
        private string _habitat;
        public string Habitat {get{return _habitat;}set {_habitat=value;}} 

        private string _eatingHabit;
        public string EatingHabit {get{return _eatingHabit;}set{_eatingHabit=value;}}



        public void Displayname(){
            Console.WriteLine($"Animal name : {Name}");

        }
        public void DisplayInfo(){
            
            Console.WriteLine($"Dog Habitat : {Habitat}");
            Console.WriteLine($"Dog eating Habit : {EatingHabit}");
        }
    }
}
