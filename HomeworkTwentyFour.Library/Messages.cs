namespace HomeworkTwentyFour.Library
{
    public class Messages
    {
        public string Welcome(string prefix, string lastName)
        {
            return $"Welcome {prefix} {lastName}. Enjoy your time!";
        }

        public string Farewell(string prefix, string lastName)
        {
            return $"Hope you enjoyed your time {prefix} {lastName}. Come again!";
        }
    }
}
