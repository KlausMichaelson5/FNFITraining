// /////////////////////CRUD EXAMPLE//////////////////////////////////////////////////////////
/*
How to create entity classes in c# that has properties in it.
How to create instance of that class and access properties to set and read the values and display it in console.
How to create a class that uses collections to store multiple objects of the entity class.Here the data is
 hidden and functions are created to access the data like add, remove,update and find.
How to consume the class in main method and call its methods
*/

/*
Create a file called CrudExample.cs in vs code.
Create a class called Expense that has properties as Id(int),Description(string),Amount(double) and
 Date(DateTime).
Create a Main Class and have an SVM in it. Create the instance of the Expense,set values to it and display the
 expense details of object.
Create few more objects and set values to each object and display the result.
*/
using System;
using System.Collections.Generic; 
namespace Sample{
class Expense{
    public int Id;
    public string Description;
    public double Amount;
    public DateTime Date;

    public override string ToString()
    {
        return "Id: "+Id + " Description: "+Description + " Amount: "+Amount+" Date: "+Date;
    }
}

class ExpenseCollection{

    private List<Expense> _expenses = new List<Expense>();

    public void AddExpense(Expense expense){
        _expenses.Add(expense);
    }

    public void RemoveExpense(int Id){
        foreach (var expense in _expenses)
        {
            if(expense.Id==Id){
                _expenses.Remove(expense);
                return;
            }
        }
    }

    public void UpdateExpense(int Id, Expense expense){
        foreach (var expenseItem in _expenses)
        {
            if(expenseItem.Id==Id){
                expenseItem.Description=expense.Description;
                expenseItem.Amount=expense.Amount;
                expenseItem.Date=expense.Date;
                return;
            }
        }
    }

    public Expense FindExpense(int Id){
        foreach (var expense in _expenses)
        {
            if(expense.Id==Id){
                return expense;
            }
        }
        return null;
    }
}

class Ex08_CrudExample{

    private static ExpenseCollection collection=new ExpenseCollection();

    static void Main(){

        int input=0;
        do
        {
        Console.WriteLine("Select the function you want to perform.\n");
        input=MyConsole.GetInt("Press 1 for Adding Expense.\nPress 2 to Remove Expense.\nPress 3 to Update Expense.\nPress 4 to Find Expense.\nPress 5 for Exit\n");  
        switch (input)
        {
            case 1:
                addExpenseFeature();
                break;

            case 2:
                removeExpenseFeature();
                break;
            
            case 3:
                updateExpenseFeature();
                 break;
            
            case 4:
                findExpenseFeature();
                break;
            case 5:
                Console.WriteLine("Thank you.");
                return;
            default:
                Console.WriteLine("Invalid Input.");
                break;
        }
        }while(input!=5);
    }
    
    private static void addExpenseFeature(){
        int Id=MyConsole.GetInt("Enter expense Id:");
        string Description=MyConsole.GetString("Enter expense description:");
        double Amount=MyConsole.GetDouble("Enter expense amount:");
        Expense expense=new Expense{Id=Id,Description=Description,Amount=Amount,Date=DateTime.Now};

        collection.AddExpense(expense);
        Console.WriteLine("Expense added succesfully.");
    }

    private static void removeExpenseFeature(){
        int Id=MyConsole.GetInt("Enter expense Id to remove it:");

        collection.RemoveExpense(Id);
        Console.WriteLine("Expense removed succesfully.");
    }

    private static void updateExpenseFeature(){
        int Id=MyConsole.GetInt("Enter expense Id to update it:");
        string Description=MyConsole.GetString("Enter expense description:");
        double Amount=MyConsole.GetDouble("Enter expense amount:");
        Expense expense=new Expense{Id=Id,Description=Description,Amount=Amount,Date=DateTime.Now};

        collection.UpdateExpense(Id,expense);
        Console.WriteLine("Expense updated succesfully.");
    }

    private static void findExpenseFeature(){
            int Id=MyConsole.GetInt("Enter expense Id to search:");

            Expense expense=collection.FindExpense(Id);
            if(expense!=null) {
                Console.WriteLine("Expense found succesfully.");
                Console.WriteLine(expense);
            }
            else Console.WriteLine("Expense not found.");}
    }
}