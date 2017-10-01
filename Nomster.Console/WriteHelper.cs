using System;
namespace Nomster.Console
{
    /// <summary>
    /// Easify the usage of System.Console.WriteLine("...!");
    /// </summary>
    public static class WriteHelper
    {
        /// <summary>
        /// Writes a line to the console with default left padding.
        /// </summary>
        /// <param name="text">Text to write</param>
		public static void Write(string text)
		{
			System.Console.WriteLine($"  {text}");
		}

		/// <summary>
		/// Writes a colorized line to the console with default left padding.
		/// </summary>
		/// <param name="text">Text to write</param>
		/// <param name="textColor">Text color.</param>
		public static void Write(string text, ConsoleColor textColor)
		{
			System.Console.ForegroundColor = textColor;
			System.Console.WriteLine($"  {text}");
			System.Console.ResetColor();
		}

        /// <summary>
        /// Writes just a spacing line to the console.
        /// </summary>
		public static void WriteSpacer()
		{
			Write("");
		}
    }
}
