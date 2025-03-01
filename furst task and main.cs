class Program
{
    static int FirstTask(int baseNumber, int exponent)
    {
      Console.Write("Введите основание степени: ");
      baseNumber = Convert.ToInt32(Console.ReadLine());
      Console.Write("Введите показатель степени: ");
      exponent = Convert.ToInt32(Console.ReadLine());

      if (exponent == 0)
      {
        Console.WriteLine("Степень равна нулю, ответ: 1");
        return 0;
      }

      int multiplier = baseNumber;

      while (exponent > 1)
      {
        baseNumber *= multiplier;
        --exponent;
      }

      Console.WriteLine(baseNumber);
      return 0;
    }

    static int SecondTask(double valueOfX)
    {
      
    }
