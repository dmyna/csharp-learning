using System;
using System.IO;
using AverageInventory;

namespace Commands
{
    public class Commands
    {
        private string[] avaiableLessons = ["AverageInventory", "USDToBRL"];

        public void ListLessons()
        {
            Console.WriteLine("These are the available lessons: ");
            foreach (string lesson in avaiableLessons)
            {
                Console.WriteLine($"- {lesson}");
            }
        }
        public void ExecLesson(string lesson)
        {
            bool lessonFound = false;

            foreach (string avaiableLesson in avaiableLessons)
            {
                if (avaiableLesson == lesson)
                {
                    lessonFound = true;
                }
            }

            if (!lessonFound)
            {
                Console.WriteLine("Lesson not found!");
                Environment.Exit(1);
            }

            switch (lesson)
            {
                case "AverageInventory":
                    AverageInventory.Class.Exec();
                    break;
                case "USDToBRL":
                    new USDToBRL.Class().Exec();
                    break;
            }
        }
    }
}