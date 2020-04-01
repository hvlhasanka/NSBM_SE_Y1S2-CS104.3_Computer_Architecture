/* Source Code Written By: Hewa Vidanage Lahiru Hasanka */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;//required to use built-in functions to retrieve hostname
using System.IO;//required to use built-in fucntions to save information in text file

namespace CA_assignment_part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a new object in streamwriter and assigning the pathway of the text file
            StreamWriter print_to_txt = new StreamWriter(@"C:\Users\Lucas.L.H.H\Desktop\Computer Architechture Assignment\CA_assignment_part_1\H.V.L.Hasanka(10026404).txt");

            //retrieving hostname and assigning into a string variable
            string hostname = Dns.GetHostName();
            //using print_to_txt object name will save the required information into the text file
            print_to_txt.WriteLine("Hostname: " + hostname);
            //to display information to the console applicatione
            Console.WriteLine("Hostname: " + hostname);

            for (int i = 1; i <= 100; i++)
            {
                //retrieving current date and time of the system and assigning it to the current_time variable
                DateTime current_time = DateTime.Now;
                //by including the variable name and a sub section, the required component can be represented like hour, minute, second, and millisecond
                print_to_txt.WriteLine("Iteration: " + i + "\t\tSystem time during iteration execution:  " + current_time.Hour + "HH : " + current_time.Minute + "MM : " + current_time.Second + "Sec . " + current_time.Millisecond + "Ms");
                Console.WriteLine("Iteration: " + i + "\t\tSystem time during iteration execution:  " + current_time.Hour + "HH : " + current_time.Minute + "MM : " + current_time.Second + "Sec . " + current_time.Millisecond + "Ms");
            }
            //closing the link to the file
            print_to_txt.Close();

            //required to keep the concole application open after code execution, will be open until a key press is provided by the user input
            Console.ReadKey();
        }
    }
}
