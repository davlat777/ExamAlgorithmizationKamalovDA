using System;
using System.Collections.Generic;
using System.Linq;

public class Mark
{
    public DateTime[] date = new DateTime[10];
    public string[] Estimation = new string[30];
    public int kol_vo;


    public void Foonction()
    {
        Random rnd = new Random();
        DateTime today = DateTime.Today;


        for (int i = 0; i < date.Length; i++)
        {
            DateTime op = today.AddDays(i);
            date[i] = op;
        }
        string[] progyl = {"Иван", "Dima", "PAsha", "2", "3", "4", "5", "отсутствие (по уважительной причине", "прогул", "болезнь" };
        for (int i = 0; i < Estimation.Length; i++)
        {
            string ip = progyl[rnd.Next(progyl.Length)];
            Estimation[i] = ip;
        }
        kol_vo = Estimation.Count(x => x == "болезнь");


    }
    public void Print()
    {
        for (int i = 0; i < date.Length; i++)
        {
            Console.WriteLine($"Дата {date[i].ToString("yyyy-MM-dd")}, {Estimation[i]}");
        }
        Console.WriteLine($"Количество пропусков за месяц по болезни: {kol_vo}");
    }


    public static void Main()
    {
        Mark mr = new Mark();
        mr.Foonction();
        mr.Print();


        Console.ReadLine();
    }
}
