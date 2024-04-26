using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    //приватный класс для Задания 1 (список)
    private class Task1_List
    {
        public List<string> ListHW = new List<string>() { "One","Two","Three"};

        public void TaskLoop()
        {
            Console.WriteLine("Выполняется Задача 1 (List):");

            Console.WriteLine("Введите текст для добавления в список:");
            ListHW.Add(Console.ReadLine());

            Console.WriteLine("Результирующий список после добавления вашего элемента:");

            foreach (var value in ListHW)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("");
            Console.WriteLine("Введите текст для добавления в середину списка:");
            ListHW.Insert(2, Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Результирующий список после добавления элемента в середину списка:");

            foreach (var value in ListHW)
            {
                Console.WriteLine(value);
            }
        }
    }

    //приватный класс для Задания 2 (словарь)
    private class Task2_Dictionary
    {
        public Dictionary<string, float> DictHW = new Dictionary<string, float>();

        public void TaskLoop()
        {
            string name;
            float rating;
            bool input;
            bool stop;

            Console.WriteLine("Выполняется Задача 2 (Dictionary):");

            //цикл по добавлению записей в словарь
            do
            {
                do
                {
                    Console.WriteLine("Введите имя студента для добавления в базу (имя не должно быть пустым):");
                    name = Console.ReadLine();
                }
                while (name == "");

                do
                {
                    Console.WriteLine("Введите его среднюю оценку (от 2 до 5):");
                    input = float.TryParse(Console.ReadLine(), out var value);
                    rating = value;
                }
                while (!input | rating < 2 | rating > 5);

                DictHW.Add(name, rating);
                Console.WriteLine("Имя студента и средняя оценка добавлены!");

                Console.WriteLine("");
                Console.WriteLine("Введите 1, чтобы ввести следующую запись, другое значения для прекращения ввода:");

                var a = Console.ReadLine();

                if (a == "1") { stop = false; } else { stop = true; }
            }
            while (!stop);

            //вывод получившейся коллекции
            Console.WriteLine("");
            Console.WriteLine("Результирующий список:");

            foreach (KeyValuePair<string, float> kvp in DictHW)
            {
                Console.WriteLine("Имя = {0}, Средняя оценка = {1}", kvp.Key, kvp.Value);
            }

            //поиск и вывод средней оценки по имени студента
            Console.WriteLine("");
            Console.WriteLine("Введите имя студента для поиска и вывода его средней оценки:");

            var findName = Console.ReadLine();

            if (DictHW.TryGetValue(findName, out var findRating))
            { Console.WriteLine($"Средняя оценка студента {findName}: {findRating}"); }
            else { Console.WriteLine($"Студента с именем {findName} не существует!"); }

        }
    }

    //приватный класс для Задания 3 (двусвязный список)
    private class Task3_DoubleLinkedList
    {
        public LinkedList<string> DoubleLinkedList = new LinkedList<string>();

        public void TaskLoop()
        {
            Console.WriteLine("Выполняется Задача 3 (Double Linked List):");

            Console.WriteLine("");
            Console.WriteLine("Введите значения для добавления в двусвязный список:");

            for (int i = 0; i < 3; i++)
            {
                var element = Console.ReadLine();
                DoubleLinkedList.AddFirst(element);
            }

            //вывод результата
            Console.WriteLine("");
            Console.WriteLine("Результирующий список:");

            foreach (var item in DoubleLinkedList)
            {
                Console.WriteLine(item);
            }

            //вывод результата в обратном порядке
            Console.WriteLine("");
            Console.WriteLine("Результирующий список (в обратном порядке):");

            var currentNode = DoubleLinkedList.Last;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Previous;
            }
        }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Домашнее задание 'Коллекции'");
        Console.WriteLine("Выберите выполняемую задачу:");
        Console.WriteLine("1-список, 2-словарь, 3-двусвязный список:");

        //вызов задачи, выбранной пользователем
        //создание класса, соответствующего выбранному пользователю номеру задачи

        var TaskNumber = Console.ReadLine();

        switch (TaskNumber)
        {
            case "1":
                var Task1 = new Task1_List();
                Task1.TaskLoop();
                break;
            case "2":
                var Task2 = new Task2_Dictionary();
                Task2.TaskLoop();
                break;
            case "3":
                var Task3 = new Task3_DoubleLinkedList();
                Task3.TaskLoop();
                break;
            default:
                Console.WriteLine("Введено некорректное значение, попробуйте еще раз.");
                break;
        }

        
    }
}