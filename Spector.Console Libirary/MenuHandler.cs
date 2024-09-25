using Spectre.Console;

namespace Spector.Console_Libirary
{
    public static class MenuHandler
    {
        // Static method to display a menu for any enum type
        public static T DisplayMenu<T>(string menuTitle) where T : Enum
        {
            var options = new SelectionPrompt<T>()
                .Title($"[green]{menuTitle}[/]")
                .AddChoices((T[])Enum.GetValues(typeof(T)));//Retrieve all values of the specified enum type T and cast them to T[]
            //The result of Enum.GetValues is an array of object, containing all the values defined in the enum.
            //(T[]):This is a cast operation that converts the resulting array of object into an array of the specific enum type T.


            return AnsiConsole.Prompt(options);
        }
    }
}
