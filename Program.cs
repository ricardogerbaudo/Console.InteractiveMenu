using System.Text;

Console.Clear();
Console.OutputEncoding = Encoding.UTF8;
Console.CursorVisible = false;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Welcome to the world of C#!");
Console.ResetColor();
Console.WriteLine("\nUse ⬆️  and ⬇️  to navigate and press \u001b[32mEnter/Return\u001b[0m to select:");
(int left, int top) = Console.GetCursorPosition();
var option = 1;
var decorator = "✅ \u001b[32m";
ConsoleKeyInfo key;
bool isSelected = false;

while (!isSelected)
{
	Console.SetCursorPosition(left, top);

	Console.WriteLine($"{(option == 1 ? decorator : "   ")}Option 1\u001b[0m");
	Console.WriteLine($"{(option == 2 ? decorator : "   ")}Option 2\u001b[0m");
	Console.WriteLine($"{(option == 3 ? decorator : "   ")}Option 3\u001b[0m");

	key = Console.ReadKey(false);

	switch (key.Key)
	{
		case ConsoleKey.UpArrow:
			option = option == 1 ? 3 : option - 1;
			break;

		case ConsoleKey.DownArrow:
			option = option == 3 ? 1 : option + 1;
			break;

		case ConsoleKey.Enter:
			isSelected = true;
			break;
	}
}

Console.WriteLine($"\n{decorator}You selected Option {option}");
Console.ReadLine();
