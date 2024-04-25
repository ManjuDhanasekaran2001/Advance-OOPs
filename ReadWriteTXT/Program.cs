using System;
using System.IO;
namespace ReadWriteTXT;
class Program{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder")){
            Console.WriteLine("Creating Folder");
            Directory.CreateDirectory("TestFolder");

        }
        else {
            Console.WriteLine("Directory Exists");
        }
        if(!File.Exists("TestFolder/MyFile.txt"))
        {
            Console.WriteLine("Creating File");
            File.Create("TestFolder/MyFile.txt").Close();
        }
        else{
            Console.WriteLine("File Already Exists");
        }

        Console.WriteLine("Select 1. Read From File 2. Write to File");
        int oprtion= int.Parse(Console.ReadLine());
        switch(oprtion){
            case 1 :{
                StreamReader sr = new StreamReader("TestFolder/MyFile.txt");
                string data = sr.ReadLine();
                while(data!=null){
                    Console.WriteLine(data);
                    data = sr.ReadLine();
                }
                sr.Close();
                break;
                }
            case 2 :{
                string [] contents = File.ReadAllLines("TestFolder/MyFile.txt");
                StreamWriter sw = new StreamWriter("TestFolder/MyFile.txt");

                Console.WriteLine("Enter What do younWant To place in file");
                string data = Console.ReadLine();
                string old= "";
                foreach(string line in contents){
                    old=old+line+"\n";
                }
                old = old+data+"\n";
                sw.WriteLine(old);

                sw.Close();
                break;
                }
        }
    }
}
