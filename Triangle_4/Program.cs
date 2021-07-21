using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_4
{
  class Program
  {
    static void Main()
    {
      //Нарисовать треугольник
      Console.Write("Введите символ, с помощью которого будет начертан треугольник: ");
      char line = char.Parse(Console.ReadLine());
      Console.Write("Введите высоту треугольника: ");
      int height = int.Parse(Console.ReadLine());
      for (int i = 0; i < height; i++)
      {
        for (int j = 0; j < i + 1; j++)
        {
          Console.Write(" ");
        }
        for (int j = height; j > i; j--)
        {
          Console.Write(line);
        }
        Console.WriteLine();
      }
      Console.ReadLine();
    }
  }
}
