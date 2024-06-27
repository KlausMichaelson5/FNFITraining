using System;
using System.Collections.Generic;

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

    class MachineDatabase{
        private List<Machine> _laptops = new List<Machine>();

        public void RegisterDevice(){

            Machine newmachine=MachineUI.GetMachine();
            this._laptops.Add(newmachine);

        }

        public bool updateDeviceDetails(int slno,Machine mac){

            foreach(var item in _laptops){
                if(item.Slno==slno){
                    item.Make=mac.Make;
                    item.Model=mac.Model;
                    item.price=mac.price;
                    return true;
                }
                
            }
             return false;
        }

        public List<Machine> GetAllRegisteredDevices(){
            return _laptops;
        }
    }

    class MachineUI{

        public static Machine GetMachine(){

            Console.WriteLine("Enter details of device to Register");
            int slno=MyConsole.GetInt("Enter slno: ");     
            string make=MyConsole.GetString("Enter Make: ");
            string model=MyConsole.GetString("Enter Model: ");
            double price=MyConsole.GetDouble("Enter price: ");
            Machine newmachine= new Machine{Slno=slno,Make=make,Model=model,price=price};

            return newmachine;
        }

         public static Machine GetMachineUpdate(){

            int slno=MyConsole.GetInt("Enter slno: "); 
            Console.WriteLine("Enter details of device to Update");
            string make=MyConsole.GetString("Enter Make: ");
            string model=MyConsole.GetString("Enter Model: ");
            double price=MyConsole.GetDouble("Enter price: ");
            Machine newmachine= new Machine{Slno=slno,Make=make,Model=model,price=price};

            return newmachine;
        }
    }

}
