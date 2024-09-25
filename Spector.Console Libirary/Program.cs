using Spectre.Console;

namespace Spector.Console_Libirary
{
    public class Program
    {
        static void Main(string[] args)
        {
            YourMenuOptions mainMenuOption = MenuHandler.DisplayMenu<YourMenuOptions>("Main Menu");
            AnsiConsole.MarkupLine($"You selected main menu option: [yellow]{mainMenuOption}[/]");
            //Console.WriteLine($"You selected main menu option: {mainMenuOption}");

            YourActionOptions actionMenuOption = MenuHandler.DisplayMenu<YourActionOptions>("Action Menu");
            AnsiConsole.MarkupLine($"You selected action menu option: [yellow]{actionMenuOption}[/]");
            //Console.WriteLine($"You selected main menu option: {actionMenuOption}");

        }
    }




}
