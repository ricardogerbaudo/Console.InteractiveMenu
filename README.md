# Console.InteractiveMenu

A small C# console app that renders an interactive, keyboard-navigable menu: arrow keys to move, Enter to select, with coloured output and emoji built using raw ANSI escape codes and cursor positioning, no external libraries.

It is the companion source code for my YouTube tutorial, where I walk through building it step by step:

▶️ **How To Create an Interactive Menu in a Console App Using C#** — https://www.youtube.com/watch?v=YyD1MRJY0qI

## What it demonstrates

- Reading key presses with `Console.ReadKey` and driving menu state from `UpArrow` / `DownArrow` / `Enter`
- Redrawing in place using `Console.GetCursorPosition` and `Console.SetCursorPosition` instead of reprinting the whole screen
- Colouring output with ANSI foreground codes (for example `[32m`) and resetting cleanly
- Setting `Console.OutputEncoding` to UTF-8 so emoji render correctly across terminals
- Wrapping selection in a simple input loop that exits on confirmation

## Run it

Requires the .NET SDK (.NET 6 or later).

```bash
git clone https://github.com/ricardogerbaudo/Console.InteractiveMenu.git
cd Console.InteractiveMenu
dotnet run
```

Use the up and down arrow keys to move between options and press Enter to select.

## Why it exists

I published this as a teaching resource for developers learning C#. The goal was a short, readable example that shows how much you can do with the standard `Console` API alone, before reaching for a menu library. If it helped you, a star is appreciated, and feel free to open an issue or PR with improvements.

## License

MIT
