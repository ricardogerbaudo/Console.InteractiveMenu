using System.Text;

Console.Clear();
Console.OutputEncoding = Encoding.UTF8;
Console.CursorVisible = false;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Welcome to the world of C#!");
Console.ResetColor();
Console.WriteLine("\nUse ⬆️  and ⬇️  to navigate and press \u001b[32mEnter/Return\u001b[0m to select:");
(int left, int top) = Console.GetCursorPosition();
var selectedOption = 0;
var decorator = "✅ \u001b[32m";
ConsoleKeyInfo key;
bool isSelected = false;

var options = new[]
{
	"Bulbasaur",
	"Charmander",
	"Squirtle"
};

while (!isSelected)
{
	Console.SetCursorPosition(left, top);

	for (int i = 0; i < options.Length; i++)
	{
		Console.WriteLine($"{(selectedOption == i ? decorator : "   ")}{options[i]}\u001b[0m");
	}

	key = Console.ReadKey(false);

	switch (key.Key)
	{
		case ConsoleKey.UpArrow:
			selectedOption = selectedOption == 0 ? options.Length - 1 : selectedOption - 1;
			break;

		case ConsoleKey.DownArrow:
			selectedOption = selectedOption == options.Length - 1 ? 0 : selectedOption + 1;
			break;

		case ConsoleKey.Enter:
			isSelected = true;
			break;
	}
}

Console.WriteLine($"\n{decorator}You selected {options[selectedOption]}");
Console.ReadLine();
