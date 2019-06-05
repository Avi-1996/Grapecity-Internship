using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Actions
    {
        // Object by which we can use the functions of math as well as scientific math library
        Calculator.ScienceMathLib myCal = new Calculator.ScienceMathLib(); 
        //Oprands
        public string secNum;
        String firstNumber = null;
        ////flag is for checking if the user continued with previous value(true) or not(false)
        public static bool flag = false;
        
        //calcultor starts here
        public void Start()
        {
            string check = null;
            do
            {
                Menu myMenu = new Menu();
                //showing the menu
                myMenu.Show();
                Actions myAction = new Actions();
                //performing the opration
                myAction.ExcuteOpration();
                //Confirming the Exit from the calcultor
                Console.Write("\t\t\t\t\tPress N to and R to restart");
                check = Console.ReadLine();
                if (check == "R" || check == "r")
                {
                    Actions myAction1 = new Actions();
                    //If user dont want to quit then restart the opration again
                    myAction.ExcuteOpration();
                }

            } while (check != "n" || check != "N");//loop untill user quit
        }
        
        
        public void ExcuteOpration() {
            //flag is for checking if the user continued with previous value  then it is (true) else  (false)
            if (flag == false) 
            { 
                //if user didnt continued the restart the fresh with taking firNumber as input
                Console.Write("\t\t\t\t\tEnter the value 1  :");
                firstNumber = Console.ReadLine();
                
             }
            else
            {
                //else firstnumis now tghe perious result
                Console.WriteLine("\n\t\t\t the previous value is :" + myCal.Result);
            }

            try
            {
                Console.Write("\t\t\t\t\tEnter One of the OpratorsFrom Above  :");
                string oprator = Console.ReadLine();
                switch (oprator)
                {
                    case "+":
                        Console.Write("\n\t\t\t\t\tEnter 2nd Value : ");
                        secNum = Console.ReadLine();
                        myCal.FNum = Double.Parse(firstNumber);
                        myCal.SNum = Double.Parse(secNum);
                        myCal.Add();
                        Console.Write("\n\t\t\t\t\tanswer is " + myCal.Result);

                        break;
                    case "-":
                        Console.Write("\n\t\t\t\t\tEnter 2nd Value : ");
                        secNum = Console.ReadLine();
                        myCal.FNum = Double.Parse(firstNumber);
                        myCal.SNum = Double.Parse(secNum);
                        myCal.Sub();
                        Console.Write("\n\t\t\t\t\tanswer is " + myCal.Result);
                        break;
                    case "/":
                        Console.Write("\n\t\t\t\t\tEnter 2nd Value : ");
                        secNum = Console.ReadLine();
                        if (double.Parse(secNum) != 0)
                        {
                            myCal.Div();
                            Console.Write("\n\t\t\t\t\tanswer is " + myCal.Result);
                        }
                        else
                            Console.Write("\n\t\t\t\t\t Sorry cant Divide By Zero");
                        break;
                    case "*":
                        Console.Write("\n\t\t\t\t\tEnter 2nd Value : ");
                        secNum = Console.ReadLine();
                        myCal.FNum = Double.Parse(firstNumber);
                        myCal.SNum = Double.Parse(secNum);
                        myCal.Mul();
                        Console.WriteLine("\n\t\t\t\t answer is " + myCal.Result);
                        break;
                    case "%":
                        Console.Write("\n\t\t\t\t\t\tEnter 2nd Value : ");
                        secNum = Console.ReadLine();
                        myCal.FNum = Double.Parse(firstNumber);
                        myCal.SNum = Double.Parse(secNum);
                        myCal.Mod();
                        Console.WriteLine("\n\t\t\t\t answer is " + myCal.Result);
                        break;
                    case "^":
                        Console.Write("\n\t\t\t\t\t\tEnter 2nd Value : ");
                        secNum = Console.ReadLine();
                        myCal.FNum = Double.Parse(firstNumber);
                        myCal.SNum = Double.Parse(secNum);
                        myCal.Power();
                        Console.WriteLine("\n\t\t\t\t\t\tanswer is " + myCal.Result);
                        break;

                    case "sqr":
                    case "SQR":
                        myCal.FNum = Double.Parse(firstNumber);
                        myCal.Sqr();
                        Console.WriteLine("\n\t\t\t\t\t\tanswer is " + myCal.Result);
                        break;

                    case "sqrroot":
                    case "SQRROOT":
                        myCal.FNum = Double.Parse(firstNumber);
                        myCal.Sqrt();
                        Console.WriteLine("\n\t\t\t\t\t\tanswer is " + myCal.Result);
                        break;
                   
                    case "sine":
                    case "SINE":
                        myCal.FNum = Double.Parse(firstNumber);
                        myCal.Sine();
                        Console.WriteLine("\n\t\t\t\t\t\tanswer is " + myCal.Result);
                        break;

                    case "cos":
                    case "COS":
                        myCal.FNum = Double.Parse(firstNumber);
                        myCal.Cosine();
                        Console.WriteLine("\n\t\t\t\t\t\tanswer is " + myCal.Result);
                        break;
                    case "tan":
                    case "Tan":
                        myCal.FNum = Double.Parse(firstNumber);
                        myCal.Tan();
                        Console.WriteLine("\n\t\t\t\t\t\tanswer is " + myCal.Result);
                        break;

                    case "log":
                    case "LOG":
                        myCal.FNum = Double.Parse(firstNumber);
                        myCal.Log();
                        Console.WriteLine("\n\t\t\t\t\t\tanswer is " + myCal.Result);
                        break;

                    default:
                        Console.WriteLine("\n\t\t\t\t\t\tPlease Check Your Operator");
                        break;
                }
                Console.Write("\n\t\tEnter C for continue or  M for main Menu or R for restart  or q for exit: ");
                string check = Console.ReadLine();
                switch (check) {
                    case "C":
                    case "c":
                        flag = true;
                        firstNumber = (myCal.Result).ToString();
                        ExcuteOpration();
                        break;
                    case "M":
                    case "m":
                        flag = false;
                        Start();
                        break;
                    case "R":
                    case "r":
                        flag = false;
                        ExcuteOpration();
                        break;
                    default:
                        flag = false;
                        Start();
                        break;
                }
            }
            catch
            {
                Console.Write("\n\t\t\t\tSome Error accure Check your input And try Again\n");
                ExcuteOpration();
            }
        }
    }

}