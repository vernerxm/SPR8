namespace SPR8;

public class CalculatorForVariousTasks
{
  public static int MinPositive(int[] array)
  {
      if (array == null)
      {
          Console.WriteLine("Null Reference Exception!");
          return -1;
      } 
      int min = Int32.MaxValue;
      for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
        }
        return min;
    }

   public static int SumOfNegativeNumbers(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine("Null Reference Exception!");
            return -1;
        } 
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
  public static int Fibonacci(int n)
    {
        if (n<0)
        {
            Console.WriteLine("Negative Number Exception!");
            return -1;
        } 
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
 public static string CurrentStrengthOnTheCircuit(int voltage, int resistance)
  {
      if (voltage < 0)
      {
         return "The voltage value is negative!";
      }
      else if (resistance < 0)
      {
          return "The resistance value is negative!";
      }
      int currentStrength ;
      currentStrength = voltage / resistance;
      return "Current strengt is : " + currentStrength.ToString();
  }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Run test =)");
    }
}