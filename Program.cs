// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using System.Text.RegularExpressions;

var regexMatchNameAndPort = new Regex(@"([^\s:]:(\d+)").Match(string.Join(' ', args));

var name = regexMatchNameAndPort.Success ? 