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
  static void Main()
    {
      int taskNumber, exponent;
      double baseNumber = 0, valueOfX = 0;

      Console.Write("Введите номер задания: ");
      taskNumber = Convert.ToInt32(Console.ReadLine());

      if (taskNumber == 1)
      {
        int FirstTask((int)baseNumber, exponent);
      }
      else if (taskNumber == 2)
      {
        SecondTask(valueOfX);
      }
      else
      {
        Console.Error.WriteLine("Неверный номер задания. Введите 1 или 2");
      }
    }
}
