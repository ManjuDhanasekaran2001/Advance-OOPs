using System;
using System.Runtime.Serialization.Formatters;
namespace ListDs;
class Program{
    public static void Main(string[] args)
    {
        //Creating object for the custom list
        
        CustomList<int> numberList = new CustomList<int>();
        numberList.Add(10);
        numberList.Add(20);
        numberList.Add(30);
        numberList.Add(40);
        numberList.Add(50);

        CustomList<int>numbers = new CustomList<int>();
        numbers.Add(60);
        numbers.Add(70);
        numberList.AddRange(numbers);

        for(int i =0; i<numberList.Count;i++){
            Console.WriteLine(numberList[i]);
        }

        bool result = numberList.Contains(40);
        int position = numberList.IndexOf(20);
        numberList.Insert(2,30);
        numberList.RemoveAt(2);
        bool temp= numberList.Remove(40);
        numberList.Reverse();
        numberList.InsertRange(2,numbers);
        numberList.Sort();

        foreach(int value in numberList){
            Console.WriteLine(value);
        }
    }
}
