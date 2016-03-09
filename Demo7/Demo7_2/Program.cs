using System;
using System;using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // write numbers to file
            using (StreamWriter integerFile = new StreamWriter(mydocpath + @"\T2Integers.txt"))
            {
                using (StreamWriter doubleFile = new StreamWriter(mydocpath + @"\T2Doubles.txt"))
                {
                    do
                    {
                        Console.Write("Enter a number (to stop entering just press enter) : ");
                        line = Console.ReadLine();
                        if (line.Length != 0)
                        {
                            try
                            {
                                int number = int.Parse(line);
                                integerFile.WriteLine(line);
                            }
                            catch (FormatException)
                            {
                                try
                                {
                                    double number = double.Parse(line);
                                    doubleFile.WriteLine(line);
                                }
                                catch (FormatException)
                                {
                                    break;
                                }
                            }
                        }
                    } while (line.Length != 0);
                }
            }
            // print numbers
            try
            {
                string text1 = File.ReadAllText(mydocpath + @"\T2Integers.txt");
                Console.WriteLine("Contents of T2Integers.txt:\n" + text1);
                string text2 = File.ReadAllText(mydocpath + @"\T2Doubles.txt");
                Console.WriteLine("Contents of T2Doubles.txt:\n" + text2);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }

            Console.WriteLine();
            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
