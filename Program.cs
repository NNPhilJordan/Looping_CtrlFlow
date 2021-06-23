using System;

namespace Looping_CtrlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isStudent ;
            string studentYorN = " ";
            int ageOfCust = 0;
            //Get the status Student/Not
            while  (studentYorN != "Y" && studentYorN != "N" &&
                    studentYorN != "n" && studentYorN != "y")
            {
             Console.WriteLine("Are you a student(Yes/No) ");
             studentYorN = Console.ReadLine();
             if (studentYorN != "Y" && studentYorN != "N" &&
                    studentYorN != "n" && studentYorN != "y")
                {
                   Console.WriteLine("Student -  Possible values are Y/y/N/n"); 
                }    
            } 
            //Determine is Student
            if (studentYorN == "Y" || studentYorN == "y")
            {
                isStudent = true;
            }
            {
                isStudent = false;
            }
            //Get the ticketholder age no less than 0 values
            do
            {
              Console.WriteLine("Your age? (no decimals) ");
              bool isParsable = Int32.TryParse(Console.ReadLine(),out ageOfCust);
              if (ageOfCust < 0)
              {
                  Console.WriteLine("Age -  Possible values are zero or greater ");
              }              
            } while (ageOfCust < 0) ;
            //determine ticket price
            int ticketPrice = 0;

            switch  (isStudent)
            {
                case true:
                ticketPrice =  8;
                break;

                default:
                  if (ageOfCust >= 0 && ageOfCust <= 12) 
                  {
                    ticketPrice = 8;
                  }   
                  else 
                  {
                    if (ageOfCust >= 13 && ageOfCust <= 64) 
                    {
                      ticketPrice = 14 ; 
                    }
                    else 
                    {
                      ticketPrice = 10 ;
                    }
                  }
                break;  
            }
            
            Console.WriteLine($"{Environment.NewLine}Ticket Price is $ {ticketPrice}");
            Console.WriteLine("Pick up your ticket at Will Call!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
           
        }
    }
}
