using System;

namespace Sample{
class Sample{

static void display(){
Console.WriteLine("Hello World");
Console.WriteLine("I am Raghu");
Console.WriteLine("I am from Bangalore");
Console.WriteLine("I work on .Net");
}

static void inputExample(){

Console.WriteLine("Enter your Name: ");
string name = Console.ReadLine();


Console.WriteLine("Enter your Ph No: ");
string phno = Console.ReadLine();


Console.WriteLine("Enter your Age: ");
int age = int.Parse(Console.ReadLine());


Console.WriteLine("Mr. {0} Age: {1} Ph No: {2}",name,phno,age);
Console.WriteLine("Your age after years is: {0}",age+15);


}
static void Main(){
       display();
       inputExample();
}


}
}