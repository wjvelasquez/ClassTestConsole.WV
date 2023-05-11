public static class Functions
{
    public static void SeparatorColor(byte c)
    {
        Random random = new Random();

        var originalForegroundColorColor = Console.ForegroundColor;
        var originalBackgroundColorColor = Console.BackgroundColor;

        var colorCount = Enum.GetValues(typeof(ConsoleColor)).Length;
    
        var colorIndexForeground = 0 ;
        var colorIndexBackground = 4 ;
        
        do
        {
            colorIndexForeground = random.Next(colorCount);
            colorIndexBackground = random.Next(colorCount);
        } while (colorIndexForeground == colorIndexBackground);


        Console.ForegroundColor = (ConsoleColor)colorIndexForeground;
        Console.BackgroundColor = (ConsoleColor)colorIndexBackground;

        Separator(c);
        Console.WriteLine();
        Console.ForegroundColor = originalForegroundColorColor;
        Console.BackgroundColor = originalBackgroundColorColor;
        Console.ResetColor();
    }
    public static void Separator(byte c) => Console.WriteLine(new string('*', c));

    public static void PrintMsg(string msg, byte c)
    {
        Console.WriteLine(msg);
        SeparatorColor(c); 
    }

}

