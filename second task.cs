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
