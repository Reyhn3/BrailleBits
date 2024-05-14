using System.Text;

Console.InputEncoding = Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Hello, BrailleBits!");

var braille = new BrailleBits.BrailleBits();

foreach (var octet in braille.Octets)
	Console.WriteLine(string.Join(" ", octet));
