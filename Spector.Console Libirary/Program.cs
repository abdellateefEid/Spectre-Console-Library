using Spectre.Console;

namespace Spector.Console_Libirary
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuOptions mainMenuOption = MenuHandler.DisplayMenu<MenuOptions>("Main Menu");
            AnsiConsole.MarkupLine($"You selected main menu option: [yellow]{mainMenuOption}[/]");
            //Console.WriteLine($"You selected main menu option: {mainMenuOption}");

            ActionOptions actionMenuOption = MenuHandler.DisplayMenu<ActionOptions>("Action Menu");
            AnsiConsole.MarkupLine($"You selected action menu option: [yellow]{actionMenuOption}[/]");
            //Console.WriteLine($"You selected main menu option: {actionMenuOption}");

        }
    }




}
