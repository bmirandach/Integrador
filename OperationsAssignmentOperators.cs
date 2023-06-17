using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
  internal class OperationsAssignmentOperators
  {
    public static int IncrementBy1(int value)
    {
      return value++;
    }

    //versión manual para usar +=
    public static int Multiply(int multiplier, int multiplicand)
    { 
      int counter = 0;
      int total = 0;
      while(counter < multiplier)
      {
        total += multiplicand;
        counter++;
      }
      return total;
    }

    public static bool  IsMultipleOf5(int value)
    {
      return value % 5 == 0;
    }

    public static bool IsMultipleOf3(int value)
    {
      return value % 3 == 0;
    }

    //para que un número sea múltiplo de 15 debe ser múltiplo de 3 y de 5 a la vez
    public static bool IsMultipleOf15(int value)
    {
      var bol = IsMultipleOf5(value);
      bol &= IsMultipleOf3(value); 
      return bol;
    }

    //para probar |=
    public static bool HasUnfriendlyCat()
    {
      return true;
    }

    public static bool HasTooManyDogs(int value)
    {
      return value > 3;
    }

    public static bool CanIGetAnotherDog(int value)
    {
      var bol = HasUnfriendlyCat();
      bol |= HasTooManyDogs(value);
      return !bol;
    }

    //para probar ?
    public static void ShowValueIfPossible(Calculator calculator)
    {
      calculator?.Add(3);
      Console.WriteLine(calculator?.GetValue());
    }

    //agregue un caso donde dado el número -7 (base 10) en 32 bits donde desplace el bit mas significativo realizando un desplazamiento aritmético, y
    //calcule el resultado final en base 10
    public static int GetFinalResult()
    {
      int number = -7;
      //          lo muestro para ver cómo se ve
      //          Console.WriteLine(Convert.ToString(number,toBase: 2).PadLeft(32, '0'));   ---> 11111111111111111111111111111001
      //          debe ser lo mismo que ~0b_111 + 0b_01;
      //          int bit = ~0b_111 + 0b_01;
      //          Console.WriteLine(Convert.ToString(bit, toBase: 2).PadLeft(32, '0'));
      //          si hago un desplazamiento aritmético sobre el bit mas significativo (el de izquierda a derecha) estoy afectando el signo
      //          con >> hace un desplazamiento lógico
      //          tengo que usar >>> para que sea un desplazamiento sin signo, que lo trate como positivo y sea aritmético
      string bin = Convert.ToString(number >>> 1, toBase: 2).PadLeft(32, '0');
      //          Console.WriteLine(bin);   ---> 01111111111111111111111111111100
      //pasar el resultado a base 10
      //            Console.WriteLine("Final result: " + Convert.ToInt32("11111111111111111111111111111001", 2));    ---> -7
      //int result = Convert.ToInt32(bin, 2);
      int result = int.Parse(Convert.ToString(number >>> 1, toBase: 10));
      return result;
    }
  }
}
