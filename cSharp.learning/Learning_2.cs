using System;
using System.IO;

namespace cSharp.learning
{
    public class Learning_2
    {
        private static string _login = "admin";
        private static string _password = "foobar";
        

        // enum
        public enum PhoneType
        {
            IOS = 0,
            ANDROID = 1,
            LINUX = 2,
            WINDOWS = 3,
            FIREOS = 4,

        }
        public static void ClassWork()
        {
            // Тернарный оператор
            // var number = условие? если истина: если ложь;

            //var number = true ? 0 : 1;

            // Циклы по классике - while, for, do while,  foreach
            // break - окончить цикл
            // continue - начинай блок заново

            // for записывается так же как в java
            //for(var i = 0; i <= 1000; i++)
            //{
            //    Console.WriteLine(i);
            //}
            // do while 
            //do
            //{

            //} while (false);
            // цикл с постусловием

            // инкремент и дикримент работают так же как и в java
            // i++;
            // i--;

            // также сдвиги работают как в python
            // i += 1;
            // i -= 1;
            // i *= 1;
            // i /= 1;

            // Префиксная и постфиксная форма записи также присутствует
            // i++; - постфиксная(сначала действия)
            // ++i; - префиксная(сначала инкремент)

            // foreach - цикл обхода коллекции

            //string[] strings = new string[] { "ABIBA", "ABABA", "ABOBA", "ABUBA" };

            //foreach(var abba in strings){
            //    Console.WriteLine(abba);
            //}

            // Оператор switch, оператор множественного выбора

            //int switchNumber = int.Parse(Console.ReadLine());
            //bool toContinue = true;
            //while (toContinue)
            //{
            //    switch (switchNumber)
            //    {
            //        case 5: // условия : действие
            //            {
            //                toContinue = false;
            //                Console.WriteLine("Correct");
            //                break;
            //            }
            //        default: // Во всех остальных случаях(else)
            //            {
            //                Console.Write("Enter another switchNumber value: ");
            //                switchNumber = int.Parse(Console.ReadLine());
            //                break;
            //            }
            //    }
            //}

            // Оператор switch на основе enum

            //var phone = Enum.Parse(typeof(PhoneType), Console.ReadLine());

            //switch (phone)
            //{
            //    case PhoneType.IOS:
            //        Console.WriteLine("ye im reach");
            //        break;
            //    default:
            //        Console.WriteLine("I WANT TO BE FREEE!!!");
            //        break;
            //}


            //Console.WriteLine(FactorialFunction(1));

            // Логические Операторы:
            // && - и
            // || - или
            // ^ - XOR исключающее или
            // 0 0 - false
            // 1 0 - true
            // 0 1 - true
            // 1 1 - false
            // ! - инверсия

            var a = 1;
            var b = 2;

            b = a ^ b;
            Console.WriteLine(String.Format("a = {0}, b = {1} ", a, b));
            b = a ^ b;
            Console.WriteLine(String.Format("a = {0}, b = {1} ", a, b));
            b = a ^ b;
            Console.WriteLine(String.Format("a = {0}, b = {1} ", a, b));


            Console.ReadKey();
        }
        private static int FactorialFunction(int value)
        {
            if (value <= 1)
            {
                return value;
            }
            return value * FactorialFunction(value - 1);

        }

        public static void HomeWork()
        {
            //StreamReader sr = new StreamReader("/Users/waljunye/Projects/cSharp.learning/cSharp.learning/login-info.txt");
            float firstNumber;
            float secondNumber;
            char operation;

            Console.Write("Операция");
            Char.TryParse(Console.ReadLine(), out operation);

            Console.Write("Первое число: ");
            float.TryParse(Console.ReadLine(), out firstNumber);
            Console.Write("Второе число");
            float.TryParse(Console.ReadLine(), out secondNumber);

            Calculate(operation, firstNumber, secondNumber);

        }

        public static bool LogIn(string login, string password)
        {
            return login == _login && password == _password;
        }

        public static bool LogIn(StreamReader streamReader)
        {
            var login = streamReader.ReadLine();
            var password = streamReader.ReadLine();
            return login == _login && password == _password;
        }

        public static void Calculate(char operation, float firstNumber, float secondNumber)
        {
            float result = 0;

            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    if(secondNumber == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя");
                    }
                    else
                    {
                        result = firstNumber / secondNumber;
                    }
                    break;
                default:
                    Console.WriteLine("Введите корректную операцию");
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
