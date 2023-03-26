using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введиде название страны для поиска её столицы: ");
            string s = Console.ReadLine();
            // создание значения s которое будет вводить пользователь

            // создаю словарь стран
            Hashtable dict = new Hashtable()
            {
                ["Россия"] = "Москва",
                ["Польша"] = "Варшава",
                ["Япония"] = "Токио",
                ["Китай"] = "Пекин",
                ["Аргентина"] = "Буэнос-Айрес",
                ["Австралия"] = "Канберра",
                ["Австрия"] = "Вена",
                ["США"] = "Вашингтон",
                ["Турция"] = "Анкара",
                ["Португалия"] = "Лиссабон"
            };

            // вывод данных на экран
            Console.WriteLine($"Столица данной страны: {dict[s]}");
        }
    }
}