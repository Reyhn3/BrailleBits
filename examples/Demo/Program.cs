using System.Text;
using BrailleBits;

Console.InputEncoding = Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Hello, BrailleBits!");

var cells = new BrailleCells();
var braille = new BrailleBits.BrailleBits();

foreach (var octet in cells.Octets)
	Console.WriteLine(string.Join(" ", octet));
