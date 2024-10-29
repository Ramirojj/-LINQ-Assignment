using System.Text.Json;
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

/*foreach(var obj in characters.Where(c => c.Alias.Count() == characters.Max(c => c.Alias.Count())).Select(c => new {c.Name, c.Alias})){
  Console.WriteLine($"{obj.Name} has {obj.Alias.Count()} alias(s):\n\t{String.Join(", ", obj.Alias)}");
}*/
/*
int LengthOfName = characters.Max(c => c.Name!.Length);
Console.WriteLine($"There are {characters.Max(c => c.Name!.Length)} letters in the longest character's name");*/
/*int LengthOfName = characters.Max(c => c.Name!.Length);
Console.WriteLine($"There are {characters.Max(c => c.Name!.Length)} letters in the longest character's name");

foreach(string? name in characters.Where(c => c.Name!.Length == LengthOfName).Select(c => c.Name))
{
  Console.WriteLine($"\t{name}");

}*/
/*
var CharactersByYearCreated = characters.GroupBy(c => c.YearCreated);
foreach(var characterByYearCreated in CharactersByYearCreated)
{
  Console.WriteLine(characterByYearCreated.Key);
  foreach(var character in characterByYearCreated) {
    Console.WriteLine($"\t{character.Name}");
  }
}*/

////1.19a] How many character(s) were created in 1981 (all series)?
/*int CharacterCount = characters.Count();
Console.WriteLine($"There are {CharacterCount} characters in all series");
*/


///How many character(s) were created in 1981 (all series)?////
//1.19a] How many character(s) were created in 1981 (all series)?
/*int characters1981 = characters.Count(c => c.YearCreated == 1981);
Console.WriteLine($"There are {characters1981} character(s) created in 1981");*/
/*int characters1990 = characters.Count(c => c.YearCreated == 1990);
Console.Wr.iteLine($"There are {characters1990} character(s) created in 1990");
int character2000 = characters.Count(c => c.YearCreated == 2000);
Console.WriteLine($"There are {character2000} character(s) created in 2000");*/

/*  List the character(s) created in that 1981 (all series) - return character name and series only */
/*foreach (var character in characters.Where(c => c.YearCreated == 1981))
{
    Console.WriteLine($"name : {character.Name},   series names: {string.Join(",  ", character.Series)}");
}*/
///[1.19c] How many character(s) were created in 1981 (Mario series)? ///
/*
int characters1981Mario = characters.Count(c => c.YearCreated ==1981 && c.Series.Contains("Mario"));
Console.WriteLine($"there are {characters1981Mario} characters created in 1981 in the mario series")
;*/


//[1.19d] List the character(s) created in that 1981 (Mario series) - return character name only. //
/*int characters1981Mario = characters.Count(c => c.YearCreated ==1981 && c.Series.Contains("Mario"));
foreach (var character in characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Mario")))
{
    Console.WriteLine($"name : {character.Name}");
}*/
//int characters1981Mario = characters.Count(c => c.YearCreated ==1981 && c.Series.Contains("Mario"));
//Console.WriteLine($"there are {characters1981Mario} characters created in 1981 in the mario series");

/*How many character(s) were created in 1981 (Donkey Kong series)?*/
/*int characters1981Dk = characters.Count(c => c.YearCreated ==1981 && c.Series.Contains("Donkey Kong"));
Console.WriteLine($"there are {characters1981Dk} characters created in 1981 in the Donkey Kong series");*/

/* [1.19f] List the character(s) created in that 1981 (Donkey Kong series) - return character name only    */

/*foreach (var character in characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Donkey Kong")))
{
    Console.WriteLine($"name : {character.Name}");
}*/
//How many character(s) made their first appearance in Donkey Kong 64?
/*int charactersdk = characters.Count(c => c.FirstAppearance == "Donkey Kong 64");
Console.WriteLine($"there are {charactersdk} characters made their first appearance in Donkey Kong 64");*/


///[1.20b] List the character(s) that made their first appearance in Donkey Kong 64 - return character name only
/*
foreach (var character in characters.Where(c => c.FirstAppearance == "Donkey Kong 64"))
{
    Console.WriteLine($"name : {character.Name}");
}*/
///[1.21a] Are there any character(s) with no alias (all series)?
///

/*bool Character1995 = characters.Any(c => c.YearCreated == 1995);
Console.WriteLine($"Are there characters created in 1995: {Character1995}");
bool Alias = characters.Any(c => c.Alias.Count == 0); 
Console.WriteLine($"Are there any characters with no alias: {Alias}");*/
/*   [1.21b] How many character(s) with no alias (all series)?*/
/*
int alias = characters.Count(c => c.Alias.Count == 0);
Console.WriteLine($"there are {alias} characters with no alias");*/

///[1.21c] List the character(s) with no alias (all series) - return character name, alias and series only.
/*

foreach (var character in characters.Where(c => c.Alias.Count == 0))
{
    Console.WriteLine($"name : {character.Name}, alias: {string.Join(",  ", character.Alias)}, series names: {string.Join(",  ", character.Series)}");
}*/
/*[1.21d] Are there any character(s) with no alias (Mario series)? */

/*
bool Character1995 = characters.Any(c => c.YearCreated == 1995);
Console.WriteLine($"Are there characters created in 1995: {Character1995}");

bool alias = characters.Any(c => c.Alias.Count == 0 && c.Series.Contains("Mario"));

Console.WriteLine($"are characters with no alias in the Mario series: {alias}");*/
///How many character(s) with no alias (Mario series)?
/*int alias = characters.Count(c => c.Alias.Count == 0 && c.Series.Contains("Mario"));
Console.WriteLine($"there are {alias} characters with no alias in the Mario series");*/







/*[1.21f] List the character(s) with no alias (Mario series) - return character name and alias only.*/

/*foreach (var character in characters.Where(c => c.Alias.Count == 0 && c.Series.Contains("Mario")))
{
   Console.WriteLine($"name:{character.Name}, alias: {string.Join(", ", character.Alias)}");}





bool alias = characters.Any(c => c.Alias.Count == 0 && c.Series.Contains("Donkey Kong"));

Console.WriteLine($"are characters with no alias in the Mario series: {alias}");*/


/////[1.21g] Are there any character(s) with no alias (Donkey Kong series)?
       
/*bool alias = characters.Any(c => c.Alias.Count == 0 && c.Series.Contains("Donkey Kong"));
Console.WriteLine($"are characters with no alias in the Donkey Kong series: {alias}");*/

//[1.21h] How many character(s) with no alias (Donkey Kong series)?  


int alias = characters.Count(c => c.Alias.Count == 0 && c.Series.Contains("Donkey Kong"));
Console.WriteLine($"there are {alias} characters with no alias in the Donkey Kong series");



