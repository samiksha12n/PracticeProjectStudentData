using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrivestudentData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr;
           
            try
            {
                string fpath = "C:\\Users\\Samiksha\\OneDrive\\Desktop\\GitAssignment\\24thAssignment\\StudentDetails.txt";
                sr = new StreamReader(fpath);
                string text = " ";
                while ((text = sr.ReadLine()) != null)
                {
                    Console.WriteLine(text);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
            
        }
    }
}
