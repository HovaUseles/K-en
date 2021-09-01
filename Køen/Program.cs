using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    class Program
    {
        static Queue<PrintJob> printQueue = new Queue<PrintJob>();
        static void AddItem()
        {
            Console.Clear();
            Random rand = new Random();
            PrintJob newFile = new PrintJob();

            Console.WriteLine("Add file to print queue...");
            Console.WriteLine("Write file name.");
            newFile.FileName = Console.ReadLine();
            Console.WriteLine("Write the file type");
            newFile.FileType = Console.ReadLine();
            Console.WriteLine();

            newFile.FileSize = rand.Next(1000, 50000);

            Console.WriteLine($"Found your file C:\\PrintableFiles\\{newFile.FileName}.{newFile.FileType}");
            Console.WriteLine("Is this your file?\n1.\nYes 2. No\n");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    printQueue.Enqueue(newFile);
                    Console.WriteLine("\nFile added.");
                    break;
                case 2:
                    Console.WriteLine("File not added. Returning to main menu.");
                    break;
                default:
                    Console.WriteLine("Your input did not match a option. Returning to main menu.");
                    break;
            }
            Console.ReadKey();
        }
        static void DeleteItem()
        {
            Console.Clear();
            Console.WriteLine("Delete file from print queue...");
            Console.WriteLine("Write file name.");
            string inputName = Console.ReadLine();
            Console.WriteLine("Write file type.");
            string inputType = Console.ReadLine();
            printQueue = new Queue<PrintJob>(printQueue.Where(job => (job.FileName != inputName && job.FileType != inputType)));
            Console.WriteLine($"file {inputName}.{inputType} deleted.");
            Console.ReadKey();
        }
        static void ItemNumber()
        {
            Console.Clear();
            Console.WriteLine($"The number of jobs in the queue: {printQueue.Count()}");
            Console.ReadKey();
        }
        static void MinMax()
        {
            Console.Clear();
            Console.WriteLine($"The Smallest file in the queue {printQueue.Min(job => job.FileSize)}");
            Console.WriteLine($"The Biggest file in the queue {printQueue.Max(job => job.FileSize)}");
            Console.ReadKey();
        }
        static void ItemSearch()
        {
            Console.Clear();
            Console.WriteLine("Name of the item you want to find?");
            string filename = Console.ReadLine();
            foreach (PrintJob item in printQueue)
            {
                if (filename == item.FileName)
                {
                    Console.WriteLine(item.FileName + "found.");
                }
            }
            Console.ReadKey();
        }

        static void ShowAllItems()
        {
            foreach (PrintJob item in printQueue)
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0}.{1}, {2}kb. Is now being printed",item.FileName, item.FileType, item.FileSize));
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("..");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Print done.");
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            // Creating some objects for our list
            Random rand = new Random();
            PrintJob job1 = new PrintJob();
            job1.FileName = "Kittens";
            job1.FileType = "jpg";
            job1.FileSize = rand.Next(1000, 50000);
            printQueue.Enqueue(job1);
            PrintJob job2 = new PrintJob();
            job1.FileName = "Movies";
            job1.FileType = "txt";
            job1.FileSize = rand.Next(1000, 50000);
            printQueue.Enqueue(job2);
            PrintJob job3 = new PrintJob();
            job1.FileName = "bomb manual";
            job1.FileType = "txt";
            job1.FileSize = rand.Next(1000, 50000);
            printQueue.Enqueue(job3);
            PrintJob job4 = new PrintJob();
            job1.FileName = "Switch Configuration";
            job1.FileType = "txt";
            job1.FileSize = rand.Next(1000, 50000);
            printQueue.Enqueue(job4);

            // Creating the menu
            bool looper = true;
            while (looper)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("            H1 Queue Operations Menu");
                Console.WriteLine("==================================================");
                Console.WriteLine();
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Delete Item");
                Console.WriteLine("3. Show the number of items");
                Console.WriteLine("4. Show min and max items");
                Console.WriteLine("5. Find an item");
                Console.WriteLine("6. Print all items");
                Console.WriteLine("7. Exit");
                Console.WriteLine();
                Console.WriteLine("Enter your choice");
                Console.WriteLine();
                int menuChoice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (menuChoice)
                {
                    case 1:
                        AddItem();
                        break;
                    case 2:
                        DeleteItem();
                        break;
                    case 3:
                        ItemNumber();
                        break;
                    case 4:
                        MinMax();
                        break;
                    case 5:
                        ItemSearch();
                        break;
                    case 6:
                        ShowAllItems();
                        break;
                    case 7:
                        looper = false;
                        break;
                    default:
                        Console.WriteLine("Input not recognise. Please try igen");
                        break;
                }
            }
        }
    }
}
