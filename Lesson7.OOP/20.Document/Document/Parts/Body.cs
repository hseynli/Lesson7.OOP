class Body
{
    string content;

    public string Content
    {
        private get
        {
            if (content != null)
                return content;
            else
                return "Senedin bedeni bosdur.";
        }
        set
        {
            content = value;
        }
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(Content);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
