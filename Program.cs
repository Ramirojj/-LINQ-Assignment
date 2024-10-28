﻿using System.Text.Json;
// deserialize mario json from file into List<Mario>
List<Character> dks = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("dk.json"))!;
// deserialize mario json from file into List<Mario>
List<Character> marios = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("mario.json"))!;
// combine all characters into 1 list
List<Character> characters = [];
characters.AddRange(dks);
characters.AddRange(marios);
// display all characters

/*foreach(Character character in characters)
{
  Console.WriteLine(character.Display());
}*/
/*
Console.Clear();
// display first character
Console.WriteLine(characters.First().Display());
//
*/
/*foreach(Character character in characters.Take(5))
{
  Console.WriteLine(character.Display());
}*/
/*foreach(Character character in characters.Skip(5))*/
//foreach(Character character in characters.Skip(5).Take(5))
//{
 /* Console.WriteLine(character.Display());*/
 //Console.WriteLine(characters.Last().Display());
//}
//Console.WriteLine(characters.Last().Display());
Console.WriteLine(characters.Min(c => c.YearCreated));