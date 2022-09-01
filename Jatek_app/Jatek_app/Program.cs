// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Hello!");

ColorWriteLine("Ez egy jatek app.",ConsoleColor.Red, ConsoleColor.Yellow);

//Animated();

String player_name = "";
do
{
player_name = Console.ReadLine();
}
while (true);

static void Animated()
{
    Console.Clear();
    Console.Write("Animated");
    Console.SetCursorPosition(0,0);
    Console.Write("Animated2");
}
Console.WriteLine("Animated");
    

static void ColorWriteLine(string text, ConsoleColor bgColor, ConsoleColor fgColor) {
    //int origRow;
    //int origCol;

    //Console.Clear();
    //origRow = Console.CursorTop;
    //origCol = Console.CursorLeft;
    
    ConsoleColor oriBgColor = Console.BackgroundColor;
    ConsoleColor oriFgColor = Console.ForegroundColor;
    Console.BackgroundColor = bgColor;
    Console.ForegroundColor = fgColor;
    for (int i = 0; i < text.Length; i++)
    {
        for (int j = Console.WindowWidth-52; j >= i; j--)
        {
            Console.SetCursorPosition(j+50, 1);
            Console.Write(text[i]);
            Console.BackgroundColor = oriBgColor;
            Console.ForegroundColor = oriFgColor;
            Console.Write(" ");
            Console.BackgroundColor = bgColor;
            Console.ForegroundColor = fgColor;


            System.Threading.Thread.Sleep(1);
    
        }
    }
    Console.WriteLine();
    Console.BackgroundColor = oriBgColor;
    Console.ForegroundColor = oriFgColor;
}
