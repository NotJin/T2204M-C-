// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using T2204M.news;

namespace T2204M.news
{
    class Program
    {
        static Hashtable NewsList = new Hashtable();
        static int count = 0;
        static void Menu()
        {
            Console.WriteLine("1. Insert news");
            Console.WriteLine("2. View list news");
            Console.WriteLine("3. Averate rate");
            Console.WriteLine("4. Exit");
        }
        static void InsertNews()
        {
            News news = new News();
            news.Id = ++count;
            Console.Write("Title: ");
            news.Title = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.Write("Publish date: ");
                    news.PulishDate = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Publish date is not formatted!");
                }
            }
            Console.Write("Author: ");
            news.Author = Console.ReadLine();
            Console.Write("Content: ");
            news.Content = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Rate " + (i + 1) + ": ");
                news[i] = int.Parse(Console.ReadLine());
            }
            NewsList.Add(news.Id, news);
        }
        static void ViewNews()
        {
            if (NewsList.Count > 0)
            {
                foreach (News news in NewsList.Values)
                {
                    news.Display();
                }
            }
            else
            {
                Console.WriteLine("News not found!");
            }
        }
        static void EverateRate()
        {
            if (NewsList.Count > 0)
            {
                foreach (News news in NewsList.Values)
                {
                    news.Calculate();
                    news.Display();
                }
            }
            else
            {
                Console.WriteLine("News not found!");
            }
        }
        static void Main(string[] args)
        {
            int choice;
            Menu();
            while (true)
            {
                Console.Write("Please select an item: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InsertNews();
                        break;
                    case 2:
                        ViewNews();
                        break;
                    case 3:
                        EverateRate();
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}