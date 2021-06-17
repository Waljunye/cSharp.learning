using System;
using cSharp.learning;

namespace cSharp.learning
{
    class Program
    {
        static void Main(string[] args)
        {
            //var stringConvert = Convert.ToString("2234");
            //Console.WriteLine(stringConvert);
            //int i;
            //if(int.TryParse(stringConvert, out i))
            //{
            //    Console.Write(i.GetType());
            //}

            // int.tryParse
            // double.tryParse
            // float.tryParse

            // Convert.toString
            // Convert.to@тип объекта/структуры@

            //System.Object - объект или ссылочный тип (reference type)
            // array
            // string
            // object

            //String.ValueType - структура(struct)
            // int
            // double
            // float
            // long

            /*Рекомендации*/
            // .toLower() - к нижнему регистру
            // .toUpper() - к верхнему регистру


            //var key = "q";

            //if(key.ToLower() == "q")
            //{
            //    Console.WriteLine("passed");
            //}

            // Склеивание массива объектов/структур
            // string.Join

            //Console.WriteLine(string.Join(" ABIBA ", new int[] { 1, 2, 3, 4, 5 }));

            // Формат выведения строк
            // string.Format

            //Console.WriteLine(string.Format("Вес: {0}, Пол: {1}, Возраст: {2}", 71, "Мужской", 16));

            // нельзя давать неосмысленные переменные !!!
            // Записывать все camelCase'ом

            // локальные переменные, которые определенны в классе пишутся так:
            // _object
            // m_object - так пишет Microsoft
            // начиная с нижнего подчеркивания

            // Классы называют с большой буквы

            // Создание пустой строки 
            // вместо string someString = "" писать string someString = string.Empty

            // Стараться не писать магических переменных(int something = 30 * 24 * 365)
            // В этом случае лучше будет объявить константу

            // Обязательно писать комментарии к основным элементам кода


            cSharp.learning.Learning_2.HomeWork();
        }
    }
}
