using System;
using System.Collections.Generic;

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

            Console.WriteLine("Выполняется Задача 2 (Dictionary):");
                        
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
            Console.WriteLine("Результирующий список:");

            foreach (KeyValuePair<string, float> kvp in DictHW)
            {
                Console.WriteLine("Имя = {0}, Средняя оценка = {1}", kvp.Key, kvp.Value);
            }
        }
    }

    //приватный класс для Задания 3 (двусвязный список)
    private class Task3_DoubleLinkedList
    {
        public void TaskLoop()
        {
            Console.WriteLine("Выполняется Задача 3 (Double Linked List):");
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