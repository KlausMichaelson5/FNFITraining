using System;

class MyConsole{

public static string GetString(string message){
    Console.WriteLine(message);
    return Console.ReadLine();
}

public static int GetInt(String message){
    int result=0;
    do{
        Console.WriteLine(message);
    }while(!int.TryParse(Console.ReadLine(),out result));
  return result;
}

public static double GetDouble(string message){
  double result=0;
    do{
        Console.WriteLine(message);
    }while(!double.TryParse(Console.ReadLine(),out result));
  return result;
}
}