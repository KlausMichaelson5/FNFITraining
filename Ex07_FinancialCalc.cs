/*
Financial Calc 
Calc the emi for a given principal amount with certain roi and term (min 3 for car,10 for home).
Also calculator for calculating RD amount and provide final amount after RD is completed.
*/

using System;
namespace Sample{

    public enum EmiType{
        Car=3,
        Hoam=10
    }

class Ex07_FinancialCalc{


   static void PerformEmiCalculation(EmiType emitype,double principal,double roi,int term){
       
       Emi emi=new Emi();
       emi.emitype=emitype;
       emi.principal=principal;
       emi.roi=roi;
       emi.term=term;

       emi.CalculateEmi();
       emi.DisplayEmi();

   }

   static void PerformRdCalculation(double monthlyDeposit,int termInMonths,double annualRate){

        Rd rd=new Rd();
        rd.monthlyDeposit=monthlyDeposit;
        rd.termInMonths=termInMonths;
        rd.annualRate=annualRate;

        rd.CalculateRd();
        rd.DisplayRd();

   }

    static void EmiCalcultor(){

        EmiType emi=(EmiType)MyConsole.GetEmiType("Please select the type of Emi:");
        double principal=MyConsole.GetDouble("Enter the Principal amount:");
        double roi=MyConsole.GetDouble("Enter the Rate of Interest:");
        int term=MyConsole.GetInt("Enter the term duration:Min: "+(int)emi);

        PerformEmiCalculation(emi,principal,roi,term);

    }

    static void RdCalcultor(){

        double monthlyDeposit=MyConsole.GetDouble("Enter the Monthly Deposit amount:");
        int termInMonths=MyConsole.GetInt("Enter the Term in Months:");
        double annualRate=MyConsole.GetDouble("Enter the Annual Rate:");

        PerformRdCalculation(monthlyDeposit,termInMonths,annualRate);

    }

    static void Main(){
        do{
            int input=MyConsole.GetInt("Welcome to Finance Calculator.\n\nPress 1 for EMI Calculator.\nPress 2 for RD Calculator\nPress 3 for Exit.");
            switch(input){
                case 1:
                    EmiCalcultor();
                    break;
                case 2:
                    RdCalcultor();
                    break;
                case 3:
                    Console.WriteLine("Thank You.");
                    return;
                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }
        }while(true);
    }
}
}