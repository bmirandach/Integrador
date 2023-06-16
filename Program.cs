using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Integrador
{
  class Program
  {
    static void Main(string[] args)
    {
      //EJERCICIO 1

      Console.WriteLine("ADDITION");
      var resultSum = Operations.Add(3, 10);
      var resultSum2 = Operations.Add(5.5, 7.5);
      Console.WriteLine("Result of the first addition: " + resultSum);
      Console.WriteLine("Result of the second addition: " + resultSum2);
      Console.WriteLine("\n");

      Console.WriteLine("SUBTRACTION");
      var resultDifference = Operations.Subtract(23, 10);
      var resultDifference2 = Operations.Subtract(25.5, 8);
      Console.WriteLine("Result of the first subtraction: " + resultDifference);
      Console.WriteLine("Result of the second subtraction: " + resultDifference2);
      Console.WriteLine("\n");

      Console.WriteLine("MULTIPLICATION");
      var resultProduct = Operations.Multiply(2, 10);
      var resultProduct2 = Operations.Multiply(2.5, 4);
      Console.WriteLine("Result of the first multiplication: " + resultProduct);
      Console.WriteLine("Result of the second multiplication: " + resultProduct2);
      Console.WriteLine("\n");

      Console.WriteLine("DIVISION");
      var resultDivision = Operations.Divide(200, 10);
      var resultDivision2 = Operations.Divide(9.5, 0);
      if (double.IsNaN(resultDivision))
      {
       Console.WriteLine("Can't divide by zero.");
      }
      else
      {
       Console.WriteLine("Result of the first division: " + resultDivision);
      }
      if (double.IsNaN(resultDivision2))
      {
       Console.WriteLine("Can't divide by zero.");
      }
      else
      {
       Console.WriteLine("Result of the second division: " + resultDivision2);
      }
      Console.WriteLine("\n");

      Console.WriteLine("MODULO");
      var resultModulo = Operations.Modulo(12, 5);
      var resultModulo2 = Operations.Modulo(12, 6);
      Console.WriteLine("Result of the first modulo: " + resultModulo);
      Console.WriteLine("Result of the second modulo: " + resultModulo2);
      Console.WriteLine("\n");

      Console.WriteLine("POWER");
      var resultPower = Operations.Power(2, 5);
      var resultPower2 = Operations.Power(9.5, 0);
      Console.WriteLine("Result of the first exponentiation: " + resultPower);
      Console.WriteLine("Result of the second exponentiation: " + resultPower2);
      Console.WriteLine("\n");

      Console.WriteLine("AVERAGE OF 3 NUMBERS");
      var resultAverage = Operations.GetAverage3(11, 9, 19);
      Console.WriteLine("Result of the average of 3 numbers: " + resultAverage);
      Console.WriteLine("\n");

      //para los siguientes casos asumo que el usuario va a ingresar numeros
      Console.WriteLine("AREA TRIANGLE");
      Console.WriteLine("Enter the base: ");
      var baseTriangle = Console.ReadLine();
      Console.WriteLine("Enter the height: ");
      var heightTriangle = Console.ReadLine();
      var resultArea = Operations.GetAreaTriangle(double.Parse(baseTriangle), double.Parse(heightTriangle));
      Console.WriteLine("Area of the triangle: " + resultArea);
      Console.WriteLine("\n");

      Console.WriteLine("PERIMETER CIRCLE");
      Console.WriteLine("Enter the value of the radius: ");
      var radius = Console.ReadLine();
      var resultPerimeter = Operations.GetPerimeterCicle(double.Parse(radius));
      Console.WriteLine("Perimeter of the circle: " + resultPerimeter);
      Console.WriteLine("\n");

      Console.WriteLine("CONVERSION CELSIUS TO FAHRENHEIT");
      Console.WriteLine("Enter the temperature value in Celsius: ");
      var degrees = Console.ReadLine();
      var resultConversion = Operations.ConvertToFahrenheit(double.Parse(degrees));
      Console.WriteLine("Value in Fahrenheit degrees: " + resultConversion);
      Console.WriteLine("\n");


      Console.WriteLine("||CALCULATOR||");
      Console.WriteLine("Enter 'y' to activate the calculator");
      var activateCalculator = Console.ReadKey();
      if (activateCalculator.KeyChar.ToString() == "y")
      {
       Console.Clear();
       CalculatorInterface calculator = new CalculatorInterface();
       calculator.Activate();

      }
      Console.WriteLine("\n");

      //EJERCICIO 2

      Console.WriteLine("AVERAGE OF 4 NUMBERS");
      Console.WriteLine("Enter first grade: ");
      var firstGrade = Console.ReadLine();
      Console.WriteLine("Enter second grade: ");
      var secondGrade = Console.ReadLine();
      Console.WriteLine("Enter third grade: ");
      var thirdGrade = Console.ReadLine();
      Console.WriteLine("Enter fourth grade: ");
      var fourthGrade = Console.ReadLine();
      Console.WriteLine("First grade: " + firstGrade + "\nSecond grade: " + secondGrade + "\nThird grade: " + thirdGrade + "\nFourth grade: " + fourthGrade);
      double resultAverage4 = Operations.GetAverage4(double.Parse(firstGrade), double.Parse(secondGrade), double.Parse(thirdGrade), double.Parse(fourthGrade));
      Console.WriteLine("The average is: " + resultAverage4);
      Console.WriteLine("\n");


      //EJERCICIO 3

      Console.WriteLine("CONVERSION CM TO IN");
      Console.WriteLine("Enter value in cm: ");
      var valueCm = Console.ReadLine();
      var valueIn = Math.Round(Operations.ConvertToInches(double.Parse(valueCm)), 4);
      Console.WriteLine("Length: " + valueCm + "\n" + valueIn + " in");
      Console.WriteLine("\n");


      //EJERCICIO 4

      //esto si o si en español
      Console.WriteLine("CONVERSIÓN PESO A DÓLAR");
      Console.WriteLine("Ingrese valor en pesos: ");
      var pesos = Console.ReadLine();
      Console.WriteLine("Ingrese cotización: ");
      var cotizacion = Console.ReadLine();
      var dolares = Math.Round(Operations.ConvertToDollar(double.Parse(pesos), double.Parse(cotizacion)), 3);
      Console.WriteLine(pesos + " pesos son " + dolares + " dólares :D");
      Console.WriteLine("\n");


      //EJERCICIO 5

      Console.WriteLine("~~~MENU~~~~\nHot dog - $2 \nFrench Fries - $1 \nSoda - $0.85"); //menu
      Console.WriteLine("Enter number of hot dogs: ");
      var qHotDogs = Console.ReadLine();
      Console.WriteLine("Enter number of french fries: ");
      var qFrenchFries = Console.ReadLine();
      Console.WriteLine("Enter number of sodas: ");
      var qSodas = Console.ReadLine();
      var totalBill = Math.Round(Operations.GetTotalBill(double.Parse(qHotDogs), double.Parse(qFrenchFries), double.Parse(qSodas)), 3);
      Console.WriteLine("Your bill is $" + totalBill);
      Console.WriteLine("\n");


      //EJERCICIO 6
      Host.CreateDefaultBuilder(args)
        .ConfigureServices(services => { services.AddHostedService<HostedService>(); })
        .Build()
        .RunAsync();
      Console.WriteLine("\n");


      //EJERCICIO 7

      Console.WriteLine(OperationsAssignmentOperators.Multiply(2,3));

      Console.WriteLine(OperationsAssignmentOperators.IsMultipleOf5(300) & OperationsAssignmentOperators.IsMultipleOf3(300));
      Console.WriteLine(OperationsAssignmentOperators.IsMultipleOf15(300));
      Console.WriteLine(OperationsAssignmentOperators.IsMultipleOf15(27));
      //gato amargo y pocos perros
      Console.WriteLine(!(OperationsAssignmentOperators.HasUnfriendlyCat() || OperationsAssignmentOperators.HasTooManyDogs(1)));
      //no hay gato amargo pero si muchos perros
      Console.WriteLine(!(!OperationsAssignmentOperators.HasUnfriendlyCat() || OperationsAssignmentOperators.HasTooManyDogs(4)));
      //gato amargo y muchos perros
      Console.WriteLine(!(OperationsAssignmentOperators.HasUnfriendlyCat() || OperationsAssignmentOperators.HasTooManyDogs(3)));
      //no hay gato amargo y hay pocos perros
      Console.WriteLine(!(!OperationsAssignmentOperators.HasUnfriendlyCat() || OperationsAssignmentOperators.HasTooManyDogs(1)));

      Console.WriteLine(OperationsAssignmentOperators.CanIGetAnotherDog(2));

      //prueba con Calculator
      Calculator calculator2 = new Calculator();
      OperationsAssignmentOperators.ShowValueIfPossible(calculator2);
      calculator2 = null;
      OperationsAssignmentOperators.ShowValueIfPossible(calculator2);

      //dezplazamiento
      Console.WriteLine("Final result: " + OperationsAssignmentOperators.GetFinalResult());

    }
  }
}
