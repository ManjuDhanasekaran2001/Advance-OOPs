using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
namespace FileFolder;
class Program{
    public static void Main(string[] args)
    {
        //Creating the folder
        string path = @"C:\Users\ManjuDhanasekaran\OneDrive - Syncfusion\Desktop\DSA";
        string folderpath=path+"/Manju";
        if(!Directory.Exists(folderpath)){
            Console.WriteLine("Creating folder");
            Directory.CreateDirectory(folderpath);

        }
        else{
            Console.WriteLine("Folder alredy Existts");
        }


        //Creating the file
        string filepath = path+"/myFile.txt";
        if(!File.Exists(filepath)){
            Console.WriteLine("Creating file");
            File.Create(filepath);
        }
        else{
            Console.WriteLine("File already exits");
        }

        //Creating the folder file and deleting the folder file as your wish

        Console.WriteLine("Select 1. Create folder 2. Create file 3. Delet The Folder 4.Delete the File");
        int option = int.Parse(Console.ReadLine());
        switch(option){
            case 1 :
            {
                Console.WriteLine("Enter the folder name you want to create : ");
                string folder = Console.ReadLine();
                string newPath = path+"/"+folder;
                if(!Directory.Exists(newPath)){
                    Console.WriteLine("Creating folder "+folder);
                    Directory.CreateDirectory(newPath);
                }
                else{
                    Console.WriteLine("Folder already exited");
                }

                break;
                }
            case 2:
            {
                Console.WriteLine("Enter The file Name : ");
                string fileNAme = Console.ReadLine();
                Console.WriteLine("Enter The Extension : ");
                string extension = Console.ReadLine();
                string newFilePath = path+"/"+fileNAme+"."+extension;
                if(!File.Exists(newFilePath)){
                    Console.WriteLine("Creating The file : ");
                    File.Create(newFilePath);
                }
                else{
                    Console.WriteLine("File Already Exits");
                }
                break;
                }
            case 3 : {
                foreach(string path1 in  Directory.GetDirectories(path)){
                    Console.WriteLine(path1);
                }
                Console.WriteLine("Select The folder you wish to remove : ");
                string folder1 = Console.ReadLine();
                foreach(string path1 in  Directory.GetDirectories(path)){
                    if(path1.Contains(folder1)){
                        Console.WriteLine("Folder deleted Successfully");
                        Directory.Delete(path1);
                    }
                }
                break;
                }
                case 4 :
                {
                    foreach(string file1 in  Directory.GetFiles(path)){
                    Console.WriteLine(file1);
                }
                Console.WriteLine("Select The file you wish to remove : ");
                string file2 = Console.ReadLine();
                foreach(string file1 in  Directory.GetFiles(path)){
                    if(file1.Contains(file2)){
                        Console.WriteLine("File Deleted SUccessfully ");

                        File.Delete(file1);
                    }
                }
                    break;
                }
        }
    }
}
