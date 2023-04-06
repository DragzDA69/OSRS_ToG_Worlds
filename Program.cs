using OSRS_ToG_Worlds;

var userInput = new ConsoleKeyInfo();

Repeat:
do
{
    Console.Write("Press any key to look up Tears of Guthix world data.\n");
    userInput = Console.ReadKey();
}
while (
    userInput.KeyChar.ToString() == ""
);

Console.WriteLine("\n\nGetting ToG World Data\nPlease wait...");

try
{
    var worlds = await APIHelper.GetWorldInfo();
    var reset = await APIHelper.GetLastResetInfo();
    var date = DateTime.Parse(reset.ResetTime);

    if (worlds != null)
    {
        var gggbbb = worlds.Where(w => w.Order == "gggbbb").ToList();
        gggbbb.Sort((p, q) => q.Hits.CompareTo(p.Hits));

        var bbbggg = worlds.Where(w => w.Order == "bbbggg").ToList();
        bbbggg.Sort((p, q) => q.Hits.CompareTo(p.Hits));

        var list = gggbbb.Concat(bbbggg).ToList();
        
        Console.WriteLine($"\n\nLast Reset:\t{date:MM/dd/yyyy hh:mm:ss tt}\n");
        Console.WriteLine("World\t\tOrder\t\tHits\n====================================");
        foreach (var w in list) { Console.WriteLine($"{w.World}\t\t{w.Order}\t\t{w.Hits}"); }

        Console.WriteLine("\nWould you like to run the program again? (Y/N) ");
        userInput = Console.ReadKey();
        if (userInput.KeyChar == 'Y' || userInput.KeyChar == 'y')
        {
            Console.Clear();
            goto Repeat;
        }
        else
        {
            Console.WriteLine("\nApplication will now terminate.");
        }
    }
    else
    {
        Console.WriteLine("\nAn error occurred when loading the data.\nPlease try again.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"\nError: {ex.Message}\nApplication will now terminate.");
    Console.ReadKey();
}


