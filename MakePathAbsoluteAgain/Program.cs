// See https://aka.ms/new-console-template for more information

using MakePathAbsoluteAgain;

var pfad1 = FilePathHelper.MakeAbsolute("~/Downloads/mountains.jpg");
var pfad2 = FilePathHelper.MakeAbsolute("./bin/debug/samples/config.json");


Console.WriteLine(pfad1);
Console.WriteLine(pfad2);