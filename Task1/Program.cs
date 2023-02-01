// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//----------------------Решение--------------------------------

int[] InputNumbers(string str, int m, string str1)
{
              int[] array = new int[m];
              int number;
              string? text;
              for (int i = 0; i < m; i++)
              {
                            Console.Write($"{str} {m} {str1}, {i + 1}-е число :");
                            text = Console.ReadLine();
                            if (int.TryParse(text, out number))
                            {
                                          array[i] = number;

                            }
                            else
                            {
                                          System.Console.WriteLine("Введено не корректное число, попробуйте ещё раз!");
                                          i = i - 1;
                            }
              }
              return array;
}

void PrintArray(int[] arr)
{
              System.Console.WriteLine("[ " + String.Join(", ", arr) + " ]");
}



void MoreZero(int[] array)
{
              int numMoreZero = 0;
              for (int i = 0; i < array.Length; i++)
              {
                            if (array[i] > 0)
                            {
                                          numMoreZero++;
                            }
              }
              System.Console.WriteLine($"Чисел больше 0 : {numMoreZero}");
}


int[] arr = InputNumbers("Введите", 6, "чисел");
PrintArray(arr);
MoreZero(arr);