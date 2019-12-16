using System;
using MathOperationsLib;
namespace CalOperations
{
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IMathOperations _MathOperations=new MathOperations();
                Logger.Info("This is Math Operations");
                Console.WriteLine("Enter Number:");
                int n1=  Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another Number:");
                int n2= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Math Operation: \n Press 1 to Addition \n Press 2 to substract\n Press 3 to Multiplication\n Press 4 to Division\n");
                int n3= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your Option is : "+n3);
                Logger.Info("You have entered numbers are "+n1+" and "+n2);
                switch (n3)
                {
                    case 1:
                        Logger.Info("Your Option is Addition");
                        int sum=_MathOperations.Addition(n1,n2);
                        Console.WriteLine("Addition of "+n1+" and "+n2+" is "+sum);
                        Logger.Info("Addition of "+n1+" and "+n2+" is "+sum);
                    break; 
                    case 2:
                        Logger.Info("Your Option is Substraction");
                        int sum2=_MathOperations.Substraction(n1,n2);
                        Console.WriteLine("Substraction of "+n1+" and "+n2+" is "+sum2);
                        Logger.Info("Substraction of "+n1+" and "+n2+" is "+sum2);
                    break;
                    case 3:
                        Logger.Info("Your Option is Multiplication");
                        int result=_MathOperations.Multiplication(n1,n2);
                        Console.WriteLine("Multiplication of "+n1+" and "+n2+" is "+result);
                        Logger.Info("Multiplication of "+n1+" and "+n2+" is "+result);
                    break;
                    case 4:
                        Logger.Info("Your Option is Division");
                        int result2=_MathOperations.Division(n1,n2);
                        Console.WriteLine("Division of "+n1+" and "+n2+" is "+result2);
                        Logger.Info("Division of "+n1+" and "+n2+" is "+result2);
                    break;
                    default:
                        Console.WriteLine("Invalid option!!!");
                        Logger.Info("User has selected - Invalid option!: "+n3+"to do operations");
                    break;
                }
            }
            catch (Exception ex)
            {
                  Logger.Error(ex.Message, ex);
                  Console.WriteLine("Some thing went wrong !!");  
            }
            Console.ReadKey();            
        }
    }
}
