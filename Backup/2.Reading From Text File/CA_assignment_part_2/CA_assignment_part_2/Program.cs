using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//required to use buil-in functions to read information of the text file. 

namespace CA_assignment_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a new object in streamreader and assigning the pathway of the text file
            StreamReader read_from_txt = new StreamReader(@"");
            //will read the first line in text file
            string retrieving_data = read_from_txt.ReadLine();
            //this will continue to read the text file until the end is reached
            while(retrieving_data != null)
            {
                //the read information will be displayed on to the console application
                Console.WriteLine(retrieving_data);
                //will read the next existing line
                retrieving_data = read_from_txt.ReadLine();

                //retrieving current date and time of the system and assigning it to the current_time variable
                DateTime current_time = DateTime.Now;
                //displaying only the appropriate sub sections of the time on the console application
                Console.WriteLine("System time during data retrieval: " + current_time.Hour + "HH : " + current_time.Minute + "MM : " + current_time.Second + "Sec . " + current_time.Millisecond + "Ms\n");
            }
            //closing the link to the file
            read_from_txt.Close();
            //required to keep the concole application open after code execution, will be open until a key press is provided by the user input
            Console.ReadKey();
        }
    }
}
