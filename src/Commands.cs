namespace Commands
{
    public class Commands
    {
        private readonly string[] avaiableLessons = ["AverageInventory", "USDToBRL", "CelToFah", "OutKey"];

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
                    //! new USDToBRL.Class().Exec();
                    break;
                case "CelToFah":
                    CelToFah.Class.Exec();
                    break;
                case "OutKey":
                    OutKey.Class.Exec();
                    break;
            }
        }
    }
}