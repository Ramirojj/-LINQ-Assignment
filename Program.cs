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
//Console.WriteLine(characters.Min(c => c.YearCreated));
// oldest character
//Console.WriteLine(characters.First(c => c.YearCreated == characters.Min(c => c.YearCreated)).Display());
// are there any characters created in 1995?
/*bool Character1995 = characters.Any(c => c.YearCreated == 1995);
Console.WriteLine($"Are there characters created in 1995: {Character1995}");*/
 //how many characters were created in 1995
//Console.WriteLine($"How many? {characters.Count(c => c.YearCreated == 1995)}");
/*foreach(Character character in characters.Where(c => c.YearCreated == 1995))
{
  Console.WriteLine(character.Display());
}*/
// which characters were created in 1995 (name only)
/*foreach(Character character in characters.Where(c => c.YearCreated == 1995))
{
  Console.WriteLine(character.Name);
}*/
/*foreach(String? name in characters.Where(c => c.YearCreated == 1995).Select(c => c.Name))
{
  Console.WriteLine(name);
}*/
/*foreach(var obj in characters.Where(c => c.YearCreated == 1995).Select(c => new { c.Name, c.Description }))
{
  Console.WriteLine($"{obj.Name} - {obj.Description}");
}*/
/*foreach(var obj in characters.Where(c => c.YearCreated == 1995).Select(c => new { c.Name, c.Description }).OrderBy(c => c.Name))
{
  Console.WriteLine($"{obj.Name} - {obj.Description}");
}*/
/*foreach(CharacterDTO characterDTO in characters.Where(c => c.YearCreated == 1995).Select(c => new CharacterDTO{ Id = c.Id, Name = c.Name, Series = c.Series }).OrderBy(c => c.Name))
{
  Console.WriteLine(characterDTO.Display());
}*/
 //how many characters in total (all series)?
/*int CharacterCount = characters.Count();
Console.WriteLine($"There are {CharacterCount} characters in all series");*/
// how many characters appear in the Mario series?
/*int MarioCount = characters.Where(c => c.Series.Contains("Mario")).Count();
Console.WriteLine($"There are {MarioCount} characters in the Mario series");*/
//how many characters appear in the Donkey Kong series?
/*nt DkCount = characters.Where(c => c.Series.Contains("Donkey Kong")).Count();
Console.WriteLine($"There are {DkCount} characters in the Donkey Kong series");*/
// how many characters appear in the Donkey Kong series?

//int DkCount = characters.Where(c => c.Series.Contains("Donkey Kong")).Count();
//Console.WriteLine($"There are {DkCount} characters in the Donkey Kong series");
/*int DkNotMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && !c.Series.Contains("Mario")).Count();
Console.WriteLine($"There are {DkNotMarioCount} characters that appear in Donkey Kong and Not in Mario series");*/

foreach(var obj in characters.Where(c => c.Alias.Count() == characters.Max(c => c.Alias.Count())).Select(c => new {c.Name, c.Alias})){
  Console.WriteLine($"{obj.Name} has {obj.Alias.Count()} alias(s):\n\t{String.Join(", ", obj.Alias)}");
}