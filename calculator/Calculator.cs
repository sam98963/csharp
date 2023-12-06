using System;

class Calculator{
  static void Main(){
    Console.Write("Enter a number: ");
    string firstInput = Console.ReadLine();
    Console.Write("Enter another number: ");
    string secondInput = Console.ReadLine();
    Console.Write("Now give an operator: +, -, * or / ");
    string operatorInput = Console.ReadLine();
    Console.WriteLine(calculate(firstInput, secondInput, operatorInput));
  }

  static string calculate(string firstInput, string secondInput, string operatorInput){
    return("You entered: " + firstInput + " " + secondInput+ " " + operatorInput);
  }
}