using System;

namespace Sample{
class ArrayExample{


static void creatingArray(){

Console.WriteLine("Enter the size of the Array: ");
int size=int.Parse(Console.ReadLine());

int [] elements=new int[size];

for(int i=0;i<size;i++){
Console.WriteLine("Enter value at position {0}",i+1);
elements[i]=int.Parse(Console.ReadLine());
}

Console.WriteLine("All the values have been set.");

foreach(var element in elements){
Console.Write(element+" ");
}

}


static void creatingArrayDynamically(){

Console.WriteLine("Enter the size of the Array: ");
int size=int.Parse(Console.ReadLine());

Console.WriteLine("Enter the CTS type for the type of the Array: ");
			
Type arrayType=Type.GetType(Console.ReadLine());

if(arrayType==null){ Console.WriteLine("Invalid type"); return; }
Array array=Array.CreateInstance(arrayType,size);

for(int i=0;i<size;i++){
Console.WriteLine("Enter the value at index {0} for type {1}: ",i,arrayType.FullName);
object value=Convert.ChangeType(Console.ReadLine(),arrayType);
array.SetValue(value,i);
}

Console.WriteLine("All the values have been set.");

foreach(var element in array){
Console.Write(element+" ");
}

}

static void Main(){
	//creatingArray();
	creatingArrayDynamically();

}

}
}