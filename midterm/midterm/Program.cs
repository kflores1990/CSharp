using System;

namespace midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader workerFile =
                new System.IO.StreamReader(@"c:\Users\Kyle\Desktop\spring sem\adv prog\weeks\week7\worker.txt");


            int WarrSize = Convert.ToInt32(workerFile.ReadLine());


            Worker[] workerArr = new Worker[WarrSize];

            int Currentyear = 0;

            Console.Write("What is the current year: ");
            Currentyear = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < WarrSize; x++)//cycle array 
            {
                workerArr[x] = new Worker(
                    Currentyear, //current year
                    Convert.ToString(workerFile.ReadLine()), //fname
                    Convert.ToString(workerFile.ReadLine()), //lname
                    Convert.ToString(workerFile.ReadLine()), //workID
                    Convert.ToInt32(workerFile.ReadLine()), //year started
                    Convert.ToDouble(workerFile.ReadLine()) //double initial salary,
                    );//current salary
                //intake worker info line by line. 


            }
            Console.WriteLine("\n--------------EMPLOYEES---------------------");

            foreach (var employee in workerArr)
            {
                Console.WriteLine(employee);
            }

            workerFile.Close();

            System.IO.StreamReader managerFile =
                new System.IO.StreamReader(@"c:\Users\Kyle\Desktop\spring sem\adv prog\weeks\week7\manager.txt");


            int MarrSize = Convert.ToInt32(managerFile.ReadLine());
            Manager[] Marr = new Manager[MarrSize];

            for (int x = 0; x < MarrSize; x++)//cycle array 
            {
                Marr[x] = new Manager(

                    Currentyear, //current year
                    Convert.ToString(managerFile.ReadLine()), //fname
                    Convert.ToString(managerFile.ReadLine()), //lname
                    Convert.ToString(managerFile.ReadLine()), //workID
                    Convert.ToInt32(managerFile.ReadLine()), //year started
                    Convert.ToDouble(managerFile.ReadLine()), // initial salary,
                    Convert.ToInt32(managerFile.ReadLine()) // promoted year
                    );
                //intake worker info line by line. 


            }
            Console.WriteLine("\n--------------MANAGERS---------------------");
            foreach (var manager in Marr)
            {
                Console.WriteLine(manager);
            }

            managerFile.Close();



            Console.ReadLine();
        }
    }
}
