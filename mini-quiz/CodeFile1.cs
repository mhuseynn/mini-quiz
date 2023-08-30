// Save the current console colors
ConsoleColor originalForegroundColor = Console.ForegroundColor;
ConsoleColor originalBackgroundColor = Console.BackgroundColor;

// Change the console text color
Console.ForegroundColor = ConsoleColor.Yellow;

// Write text with the new color
Console.WriteLine("This text is in yellow.");

// Restore the original console colors
Console.ForegroundColor = originalForegroundColor;
Console.BackgroundColor = originalBackgroundColor;

// Write text with the original colors
Console.WriteLine("This text is in the original colors.");

// Keep the console window open
Console.ReadLine();