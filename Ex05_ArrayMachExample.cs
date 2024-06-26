using System;
using System.Collections.Generic;

namespace Sample{
     
     class ArrayMachExample{
        
       static void Main() 
        {
       
        MachineDatabase md=new MachineDatabase();
        int input=0;
        do{
        Console.WriteLine("Select the function you want to perform.\n");
        input=MyConsole.GetInt("1 for Registering Device.\n2 for update.\n3 for getting all  registered devices.\n4 for exit.\n");  
        switch (input)
        {
            case 1:
                md.RegisterDevice();
                break;
            case 2:
                   int slno= MyConsole.GetInt("Enter slno to update");
                   string make=MyConsole.GetString("Enter new Make: ");
                   string model=MyConsole.GetString("Enter new Model: ");
                   double price=MyConsole.GetDouble("Enter new price: ");
                   Machine newmachine= new Machine{Slno=slno,Make=make,Model=model,price=price};
                    md.updateDeviceDetails(slno,newmachine);
                    break;
            case 3:
                List<Machine> _laptops=md.GetAllRegisteredDevices();
                Console.WriteLine();
                foreach(var item in _laptops){ Console.WriteLine(item);}
                Console.WriteLine();
                break;
            case 4:
                 Console.WriteLine("Thank You.");
                 break;
            default:
                Console.WriteLine("Wrong Input.\n");
                break;
        }

        }while(input!=4);
     }
     }
}