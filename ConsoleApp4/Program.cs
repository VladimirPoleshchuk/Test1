using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Примеры


            /*  string masseng = "Привет меня зовут Дима я живу в новосибирске .";

              string[] words = masseng.Split(' ');

              string[] newWords = new string[words.Length];
              Console.WriteLine(words.Length);

              for (int i = 0; i < words.Length; i++)
              {
                  char[] letters = words[i].ToCharArray();
                  Array.Reverse(letters);
                  newWords[i] = new string(letters);
              }

              string result = String.Join(" ", newWords);
              Console.WriteLine(result);*/

            //Поиск элемента в строке.
            /*string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] nambers = orderStream.Split(',');
            
            foreach (var namber in nambers)
            {
                if (namber.StartsWith("B"))
                {
                    Console.WriteLine(namber);
                }
            */
            /*
            //Создание масива
            string[] pallets = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("массив");
            print();

            //Сортировка массива
            Console.WriteLine("Sorted --");
            Array.Sort(pallets);
            print();

            // Изменение массива в обратную сторону
            Console.WriteLine("--Revers");
            Array.Reverse(pallets);
            print();

            //Удаление элементов в массиве
            Console.WriteLine("--Clear--");
            Array.Clear(pallets, 0, 2);
            print();

            //Добавление новых элементов массива
            Console.WriteLine("--Append--");
            Array.Resize(ref pallets, (pallets.Length + 3));
            pallets[4] = "A342";
            pallets[5] = "D456";
            pallets[6] = "B78";
            print();
           
            //Изменение размера массива
            Console.WriteLine("--Remove--");
            Array.Resize(ref pallets, 5);
            print();

            // Вызываемый метод для печати элементов массива
            void print ()
            {
                foreach (var pallet in pallets)
                {
                    Console.WriteLine(pallet);
                }
            */

            /*
             * // Изменение порядка в строке и содание новой строки
            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);
            string newValue = new string(valueArray);
            Console.WriteLine(newValue);
            */
            /*
            //Создание массива символов и сцепление массива с помощь символа в строку
            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);
            string newValue = String.Join(",", valueArray);
            Console.WriteLine(newValue);
            */
            /*
            //Создание массива подстрок из строки
            string value = "Кто ходти на улице?";
            string[] items = value.Split(' ');
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            */
            /*
            //Пример применения
            string messeng = "Быстрая хитрая рыжая лиса прыгает через спящую собаку";
            string[] word = messeng.Split(' ');
            string[] newMesseng = new string[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                char[] vs = word[i].ToCharArray();
                Array.Reverse(vs);
                newMesseng[i] = new string(vs);
            }
            string result = String.Join(" ", newMesseng);
            Console.WriteLine(result);
            */
            /*
            // Пример поиска символа в массиве
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] palets = orderStream.Split(',');
            foreach (var palet in palets)
            {
                if (palet.Contains("1"))
                {
                    Console.WriteLine(palet);
                }
            }
            */
            /*
            //Форматирование буквенно-цифровых данных.

            string first = "Привет";
            string second = "Мир";
             string result = string.Format("{0} {1}!", first, second);
            Console.WriteLine(result);
             Console.WriteLine("{0} {0}!", first, second);

            decimal price = 123.45m;
            int discount = 50;
            Console.WriteLine($"Price: {price:C} (Save {discount:C})");

            decimal measurement = 123456.78912m;
            Console.WriteLine($"Mesurement: {measurement:N3} units.");

            decimal tax = 0.256358m;
            Console.WriteLine($"Tax rate: {tax:P2}");
            */
            /*
            string text = "Привет как дела что нового дома?";
            Console.WriteLine(text.Length);
            Console.WriteLine(text);
            Console.WriteLine(text.PadLeft(35));
            Console.WriteLine(text.PadRight(39,'-'));
            *//*
            string paymentId = "769";
            string payeeName = "Mr. Stephen Ortega";
            string paymentAmount = "$5 000.00";

            var formattedLine = paymentId.PadRight(6);
            formattedLine += payeeName.PadRight(24);
            formattedLine += paymentAmount.PadLeft(10);
            Console.WriteLine("1234567890123456789012345678901234567890");
            Console.WriteLine(formattedLine);*/

            #endregion

            #region извлечение данных


            /*
            //Пример извлечения данных из строки
            string message = "(What if) I am (only interested) in the last (set of parenthesees)?";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');
            openingPosition += 1;
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition ,length));
            Console.WriteLine();

            int openingLast = message.LastIndexOf('(');
            int closingLast = message.LastIndexOf(')');
            openingLast += 1;
            int lengthLast = closingLast - openingLast;
            Console.WriteLine(message.Substring(openingLast, lengthLast));
            Console.WriteLine();

            while (true)
            {
                int openingPositionAll = message.IndexOf('(');
                if (openingPositionAll == -1) break;

                openingPositionAll += 1;
                int closingPositionAll = message.IndexOf(')');
                int lengthAll = closingPositionAll - openingPositionAll;
                Console.WriteLine(message.Substring(openingPositionAll,lengthAll));

                message = message.Substring(closingPositionAll + 1);
            }
            */
            /*
            // Пример с разными символами
            string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

            char[] openSymbols = { '[', '{', '(' };

            int closingPosition = 0;

            while (true)
            {
                int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

                if (openingPosition == -1) break;

                string currentSymbol = message.Substring(openingPosition, 1);

                char matchingSymbol = ' ';

                switch (currentSymbol)
                {
                    case "[":
                        matchingSymbol = ']';
                        break;
                    case "{":
                        matchingSymbol = '}';
                        break;
                    case "(":
                        matchingSymbol = ')';
                        break;
                }

                openingPosition += 1;
                closingPosition = message.IndexOf(matchingSymbol, openingPosition);

                int length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition,length));
            }
            */
            #endregion

            #region замена данных

/*
            string data = "12345John Smith          5000 3";
            string updatedData = data.Remove(5, 20);
            Console.WriteLine(updatedData);

            string message = "This--is--ex-amp-le--da-ta";
            message = message.Replace("--", " ");
            message = message.Replace("-", "");
            Console.WriteLine(message);
*/
            #endregion

            Console.WriteLine("Enter two integers.");

            int number = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number + number2;
            Console.Clear();
            Console.WriteLine($"Sum: {sum}");
            for (int i = 0; i <5; i++)
            {
              
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");                                     
                }
                Console.WriteLine();
            }



            Console.WriteLine("New string");

            int multi = number * number2;
            Console.WriteLine($"The product of nambers is equal to {multi}");
            Console.WriteLine("Added another line.");









            //






        }


    }

            
        }
    

