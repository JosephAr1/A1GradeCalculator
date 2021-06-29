using System;

namespace A1GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int avg2;

            int num1, num2, num3;
            int num4;
            
            
                        
            //First number for Math
            Console.Write("\nEnter Marks for Math:               ");    // user prompted number as a student mark
            num1 = Convert.ToInt32(Console.ReadLine());                // computer reads the number enetered by user and save it to num1

            //Second number for Physics
            Console.Write("\nEnter Marks for Physics:            "); // user prompted number as a student mark
            num2 = Convert.ToInt32(Console.ReadLine());              // computer reads the number enetered by user and save it to num2

            //Third number for Chemistry
            Console.Write("\nEnter Marks for Chemistry:          "); // user prompted number as a student mark
            num3 = Convert.ToInt32(Console.ReadLine());              // computer reads the number enetered by user and save it to num3

            //Fourt number for Computer Science
            Console.Write("\nEnter Marks for Computer Science:   "); // user prompted number as a student mark
            num4 = Convert.ToInt32(Console.ReadLine());              // computer reads the number enetered by user and save it to num4

            avg2 = Avg(num1, num2, num3, num4);                           // call the avg (Average) function with parameter with return value
      
            Console.WriteLine("\nThe Average Mark is:                "   + avg2);  // print and display the average mark called from the
            Console.WriteLine();

            string result = CheckNumber(avg2);                      //   call the function of the if else statement that returns the value as
                                                                    //   string that is saved to avg2.
            Console.WriteLine();                                   
            //display(result)
            
            switch (result)                                               // condition to call the function from the if else statement that identify
                                                                          // what is the renarks per case
            {
                case "Grade A":
                    Console.WriteLine("Excellent! Your Grade is A!");
                    break;
                case "Grade B":
                    Console.WriteLine("Good! Your Grade is B!");
                    break;
                case "Grade C":
                    Console.WriteLine("Satisfactory, Your Grade is C");
                    break;
                case "Grade D":
                    Console.WriteLine("Pass, Your Grade is D");
                    break;
                case "Grade E":
                    Console.WriteLine("Fail, Your Grade is F");
                    break;
                case "Grade F":
                    Console.WriteLine("Error! marks unaccepted");
                    break;

            }
        }

        static int Avg(int num1, int num2, int num3, int num4)  // return value of decimal div
        {
            int avg1;
            avg1 = (num1 + num2 + num3 + num4) / 4;      //returning value called by the division function for the average
            return avg1;                                                              // of 4 marks      
        }
        static string CheckNumber(int avg1)
        {
            
            if (avg1 >= 80)                                  // if condition to find out the grade of the student according to the average mark
            {
                return "Grade A";         // displays the equivalent grade of the student according to the average mark 
            }
            else if (avg1 >= 70 && avg1 < 80)
            {
                return "Grade B";
            }
            else if (avg1 >= 60 && avg1 < 70)
            {
                return "Grade C";
            }
            else if (avg1 >= 50 && avg1 < 60)
            {
                return "Grade D";
            }
            else if (avg1 < 50)
            {
                return "Grade E";
            }
            else if (avg1 >=101)
            {
                return "Grade F";
            }
            return Convert.ToString(avg1);
         }

    }
}
