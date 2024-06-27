using System;
namespace Sample{

    class Emi{

        public EmiType emitype;
        public double principal;
        public double roi;
        public int term;

        private double emi;
        private double totalPayment;
        private double totalInterest;


        public void  CalculateEmi(){

            double monthlyRate=roi/(12*100);
            int termInMonths=term*12;
            emi=(principal*monthlyRate*Math.Pow(1+monthlyRate,termInMonths))/(Math.Pow(1+monthlyRate,termInMonths)-1);
            totalPayment=emi*termInMonths;
            totalInterest=totalPayment-principal;

        }

        public void DisplayEmi(){

            Console.WriteLine("Emi:"+emi+"\nTotal Interest:"+totalInterest+"\nTotal Payment:"+totalPayment+"\n");

        }

    }

    class Rd{

        public double monthlyDeposit;
        public int termInMonths;
        public double annualRate;

        private double maturityAmount;
        private double totalDeposits;
        private double totalInterest;

        public void CalculateRd(){

            double monthlyRate=annualRate/(12*100);
            maturityAmount=0;

            for(int i=1;i<=termInMonths;i++){
                maturityAmount+=monthlyDeposit*Math.Pow(1+monthlyRate,termInMonths-i+1);
            }
            totalDeposits=monthlyDeposit*termInMonths;
            totalInterest=maturityAmount-totalDeposits;

        }
        
        public void DisplayRd(){

            Console.WriteLine("Total Interest:"+totalInterest+"\nTotal Deposits:"+totalDeposits+"\nMaturity Amount:"+maturityAmount+"\n");

        }

    }

}