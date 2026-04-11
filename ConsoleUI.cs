using System;

//This class is responsible for displaying the logo
public static class ConsoleUI
{
    public static void DisplayLogo()
    {
        //Changes text colour
        Console.ForegroundColor = ConsoleColor.Magenta;


        //ASCII Art Logo
            Console.WriteLine(@"
╔══════════════════════════════════════════════════════════════════════╗
║                                                                      ║
║   ██████╗██╗   ██╗██████╗ ███████╗██████╗ ███████╗██╗     ██████╗    ║
║  ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔════╝██║     ██╔══██╗   ║
║  ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝███████╗██║     ██║  ██║   ║
║  ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗╚════██║██║     ██║  ██║   ║
║  ╚██████╗   ██║   ██████╔╝███████╗██║  ██║███████║███████╗██████╔╝   ║
║   ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝╚══════╝╚══════╝╚═════╝    ║
║                                                                      ║
║                         CYBERSHIELD                                  ║
║                   AI Cyber Protection ChatBot                        ║
║                    SMARTER USER.SAFER USER                           ║
║                                                                      ║
╚══════════════════════════════════════════════════════════════════════╝
");

        //Reset colour back to defult
            Console.ResetColor();
    }
}
