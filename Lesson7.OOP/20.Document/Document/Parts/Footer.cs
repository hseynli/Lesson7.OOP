﻿class Footer
{
    string content;

    public string Content
    {
        private get
        {
            if (content != null)
                return content;
            else
                return "Foot bosdur.";
        }
        set
        {
            content = value;
        }
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Content);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
