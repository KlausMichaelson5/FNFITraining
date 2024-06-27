//////////////////////////////////////////////ENUMS/////////////////////////////////////////////////////////
/*
Learn how to create Enum
How to display the possible values in enum.
How to convert an input value type to an enum value type.
*/

using System;

namespace Sample{

    public enum AccountType{
        SBAccount,
        FDAccount,
        CAccount
    }
    class Ex03Enums{


        static void enumInputExample(){

            Console.WriteLine("Please select the account :");
            var accountTypes=Enum.GetValues((typeof(AccountType)));
            foreach(var accountType in accountTypes){
                Console.WriteLine(accountType);
            }
            
            AccountType acc=(AccountType)Enum.Parse(typeof(AccountType),Console.ReadLine(),true);
             Console.WriteLine("The Account type selected is : "+acc);

        }

        static void Main(string[] args){
            // AccountType acc=AccountType.SBAccount;
            // Console.WriteLine("The Account type selected is : "+acc);
            enumInputExample();
        }
    }
}