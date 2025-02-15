using System;

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
      int numberOfCharacters = 0;
      double clone, secondDigit;
      Console.Write("Введите Х: ");
      valueOfX = Convert.ToDouble(Console.ReadLine());

      if (valueOfX < 100)
      {
        Console.Error.WriteLine("Неверный ввод числа. Введите число Х >= 100");
        return 0;
      }

      clone = valueOfX;

      // Подсчет количества цифр
      while (clone >= 1)
      {
        clone /= 10;
        numberOfCharacters++;
      }

      clone = valueOfX;
      int[] array = new int[numberOfCharacters];

      // Заполнение массива цифрами
      for (int arrayNumber = 0; arrayNumber < numberOfCharacters; arrayNumber++)
      {
        array[arrayNumber] = (int)(clone % 10);
        clone = Math.Floor(clone / 10);
      }

      int secondNumberArray = numberOfCharacters - 2; // Вторая цифра с конца
      secondDigit = array[secondNumberArray + 1]; // Вторая цифра

      Console.Write("Число N: ");
      for (int arrayNumber = numberOfCharacters - 1; arrayNumber >= 0; --arrayNumber)
      {
        if (arrayNumber != secondNumberArray + 1) // Пропускаем вторую цифру
        {
          Console.Write(array[arrayNumber]);
        }
      }
      Console.WriteLine(secondDigit);
      return 0;
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
