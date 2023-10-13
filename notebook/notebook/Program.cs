using notebook;
using System;
using System.Collections.Generic;

public class Diary
{
    private List<Note> notes;
    private int currentIndex;

    public Diary()
    {
        notes = new List<Note>
        {
            new Note("Покормить кота", "зайти к соседу, что бы покормить кота.", new DateTime(2023, 10, 6)),
            new Note("Полить цветы", "не забыть полить цветы в гостинной.", new DateTime(2023, 10, 8)),
            new Note("Практическая по C#", "написать ежедневник на шарпах.", new DateTime(2023, 10, 13)),
            new Note("Забрать документы", "сходить в мфц за документами.", new DateTime(2023, 10, 15)),
            new Note("Дописать заметку", "написать описание к заметке.", new DateTime(2023, 10, 22))
        };

        currentIndex = 0;
    }

    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Выбрана дата " + notes[currentIndex].Date.ToShortDateString());
        for (int i = 0; i < notes.Count; i++)
        {
            Console.Write(i == currentIndex ? "-> " : "  ");
            Console.WriteLine(i + 1 + ") " + notes[i].Title);
        }
    }

    public void DisplayNoteDetails()
    {
        Console.Clear();
        Console.WriteLine(notes[currentIndex]);
        Console.WriteLine("Нажмите любую клавишу, что бы вернутся в меню.");
    }

    public void MoveToNextDate()
    {
        if (currentIndex < notes.Count - 1)
            currentIndex++;
    }

    public void MoveToPreviousDate()
    {
        if (currentIndex > 0)
            currentIndex--;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Diary diary = new Diary();

        while (true)
        {
            diary.DisplayMenu();

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    diary.MoveToPreviousDate();
                    break;
                case ConsoleKey.RightArrow:
                    diary.MoveToNextDate();
                    break;
                case ConsoleKey.Enter:
                    diary.DisplayNoteDetails();
                    Console.ReadKey();
                    break;
            }
        }
    }
}
