using System;

namespace Sample{
    class Machine
    {

        public int Slno{ get; set; }

        public string Make{ get; set;}

        public string Model{ get; set;}

        public double price{ get; set;}

        public override string ToString()
        {
        return "Slno: "+Slno + " Make: "+Make + " Model: "+Model+" Price: "+price;
        }

    }

    class Ex04_classes
    {
        static void Main(){
            //Machine machine1= new Machine(1,"India","1",120);
            int slno=MyConsole.GetInt("Enter slno: ");
            string make=MyConsole.GetString("Enter Make: ");
            string model=MyConsole.GetString("Enter Model: ");
            double price=MyConsole.GetDouble("Enter price: ");
            Machine machine1= new Machine{Slno=slno,Make=make,Model=model,price=price};
            Console.WriteLine(machine1);
            
        }
    }
}