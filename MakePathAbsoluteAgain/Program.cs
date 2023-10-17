// See https://aka.ms/new-console-template for more information

using MakePathAbsoluteAgain;

var eingabe = FilePathHelper.MakeAbsolute("~/Downloads/mountains.jpg");

Console.WriteLine(eingabe);