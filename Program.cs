using System;

class Program
{
    static int CountLat(string s)
    {
        int count = 0;
        foreach (char c in s)
        {
            if ("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".Contains(c)) count++;
        }
        return count;
    }

    static int CountRus(string s)
    {
        int count = 0;
        foreach (char c in s)
        {
            if ("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя".Contains(c)) count++;
        }
        return count;
    }

    delegate bool Uslovie(char c);//сигнатура (bool(char)) делегата

    static int Count(string s, Uslovie u)
    {
        int count = 0;
        foreach (char c in s)
        {
            if (u(c)) count++;
        }
        return count;
    }

    //создаем условие
    static bool IsLat(char c)
    {
        return "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".Contains(c);
    }

    static bool IsRus(char c)
    {
        return "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя".Contains(c);
    }

    static void Main()
    {
        string s = "Hello! Меня зовут Аксинья!";
        System.Console.WriteLine(CountLat(s));
        System.Console.WriteLine(Count(s, new Uslovie(IsLat)));
        System.Console.WriteLine(Count(s, IsLat));
        System.Console.WriteLine(Count(s, (c) =>
        {
            return "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".Contains(c);
        }));
        System.Console.WriteLine(Count(s, (c) => "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".Contains(c)));
        System.Console.WriteLine(s.Count((c) => "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".Contains(c)));
    }
}
