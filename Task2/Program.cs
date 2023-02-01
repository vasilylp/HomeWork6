// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//-----------------------------Решение----------------------------------------

double InputNumber(string message)
{
              double number;
              while (true)
              {
                            System.Console.Write(message);
                            if (!(double.TryParse(Console.ReadLine(), out number)))
                            {
                                          System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
                            }
                            else
                            {
                                          break;
                            }
              }
              return number;
}

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
              double x = (b2 - b1) / (k1 - k2);
              double y = (k1 * x) + b1;
              System.Console.WriteLine($"b1 = {b1}, k1 = {k1},b2 = {b2}, k2 = {k2} ");
              System.Console.WriteLine($"Координаты пересечения двух прямых ({Math.Round(x, 2)}; {Math.Round(y, 2)})");
}


double b1 = InputNumber("Введите значение b1 : ");
double k1 = InputNumber("Введите значение k1 : ");
double b2 = InputNumber("Введите значение b2 : ");
double k2 = InputNumber("Введите значение k2 : ");
IntersectionPoint(b1, k1, b2, k2);













// void GetBinaryView(int num)
// {
//               if (num <= 0) return;
//               GetBinaryView(num / 2);
//               System.Console.Write(num % 2);
// }

// System.Console.Write("Введите число :");
// int n = Convert.ToInt32(Console.ReadLine());
// GetBinaryView(n);
