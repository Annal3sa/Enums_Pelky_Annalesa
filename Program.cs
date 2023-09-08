using System;
using System.IO;


namespace Enums_Pelky_Annalesa
{


    //creates a global enum called months
    enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // asigns int as month, date, and year
            int myBirthMonth = (int)Months.Dec;
            int myBirthDay = 09;
            int myBirthYear = 2005;

            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

            File.WriteAllText("myFile.txt", "This is my text fail!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            File.AppendAllText("myFile.txt", "WooHoo more text added to file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            if (!File.Exists("newFile.txt"))
            {
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
            }

            File.AppendAllText("newFile.txt", myBirthDate);
            Console.WriteLine(File.ReadAllText("newFile.txt"));
        }
    }
}