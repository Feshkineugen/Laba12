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
            if (dict.ContainsKey(s))
            // Метод ContainsKey(TKey)	Проверяет наличие в словаре указанного ключа.
            {
                Console.WriteLine($"Столица данной страны: {dict[s]}");

                dict.Remove(s);
                // Метод Remove(TKey)	Удаляет элемент с указанным ключом.

                foreach (var key in dict.Keys) Console.WriteLine("\n" + dict[key]);
                // Вывод оставшихся ключей. 
                dict.Clear();
                // Метод Clear()Удаляет из словаря все элементы.

                foreach (var key in dict.Keys) Console.WriteLine(dict[key]);
                // Здесь будет пустой вывод
            }
            else
                Console.WriteLine("Такого страны в словаре нет.");
        }
    }
}
