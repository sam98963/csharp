using System;

class Calculator{
  private double firstInput;
  private double secondInput;
  private string operatorInput;
  private double result;

  static void Main(){
    Calculator calculator = new Calculator();
    calculator.GetInputs();
    Console.WriteLine(calculator.Calculate());
  }

    public Calculator(){
    this.firstInput = 0;
    this.secondInput = 0;
    this.operatorInput = "";
    this.result = 0.0;
    }


  void GetInputs(){
    Console.Write("Enter a number: ");
    this.firstInput = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter another number: ");
    this.secondInput = Convert.ToDouble(Console.ReadLine());
    Console.Write("Now give an operator: +, -, * or / ");
    this.operatorInput = Console.ReadLine();
  }

   double Calculate(){
    switch (this.operatorInput)
    {
      case "+":
      this.result = this.firstInput + this.secondInput;
      break;
      case "-":
      this.result = this.firstInput - this.secondInput;
      break;
      case "*":
      this.result = this.firstInput * this.secondInput;
      break;
      case "/":
      this.result = this.firstInput / this.secondInput;
      break;
    }
    return(result);
  }
}