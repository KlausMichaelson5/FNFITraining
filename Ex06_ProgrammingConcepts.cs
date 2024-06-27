using System;

namespace Sample{


    class Arithmmetic{

        public double first;
        public double second;
        public string operation;

        public double PerformOperation(){
             switch(operation){
                case "+":
                        return (first+second);
                    case "-":
                        return (first-second);

                    case "/":
                        return (first/second);

                    case "*":
                        return (first*second);
                    default:
                        throw new Exception("Invalid Choice");
            }
        }

    }



    class Ex06ProgrammingConcepts{

        static double PerformOperations(double first, double second, string operation){
           Arithmmetic math=new Arithmmetic();
           math.first=first;
           math.second=second;
           math.operation=operation;

           return math.PerformOperation();

        }

        static void Main(){

            string stopSignal="";
            Console.WriteLine("Welcome to Windows Caluculator");
            do{
                double first=MyConsole.GetDouble("Enter the first number:");
                string operation=MyConsole.GetString("Enter the choice of operation as + - / *");
                double second=MyConsole.GetDouble("Enter the second number:");

                try
                {       
                double result=PerformOperations(first,second,operation);
                Console.WriteLine("The result of given operation is {0}",result);
                stopSignal=MyConsole.GetString("DO YOU WANT TO CONTINUE ?:\n PRESS Y FOR YES OR N FOR NO.");     
                }
                catch (Exception Ex)
                {
                  Console.WriteLine(Ex);
                }
            }while(stopSignal.ToUpper()=="Y");
        }
    }
}