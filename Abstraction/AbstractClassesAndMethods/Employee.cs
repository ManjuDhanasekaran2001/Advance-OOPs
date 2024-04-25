using System;

namespace AbstractClassesAndMethods
{
    public abstract class Employee//Abstract class
    {
        //Abstract class - partial abstraction.
        //It has fields, property ,method, constructor, destructor, indexers, events
        //can have both abstract declaration and normal definitions
        //can only used with an inherited class
        //Not support multiple inheritance
        //it cannot be static class
        protected string _name;//Normal Field
        
        public abstract string Name { get; set; }//Abstract property

        public double Amount { get; set; } //Normal property

        public string Display() //Normal Method
        {
            return _name;
        }

        public abstract double Salary(int dates); //Abstract Method - only Declaration
    }
}
