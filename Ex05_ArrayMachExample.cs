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
        input=MyConsole.GetInt("Press 1 for Registering Device.\nPress 2 to Update Registered Device.\nPress 3 for Displaying all  Registered Devices.\nPress 4 for Exit.\n");  
        switch (input)
        {
            case 1:
                md.RegisterDevice();
                Console.WriteLine("Added Succesfully \n");
                break;
            case 2:
                  Machine newmachine=MachineUI.GetMachineUpdate();
                  bool result=md.updateDeviceDetails(newmachine.Slno,newmachine);
                  if(result){ Console.WriteLine("Updated Succesfully \n"); }
                  else { Console.WriteLine("Machine Not Found. \n"); }
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
