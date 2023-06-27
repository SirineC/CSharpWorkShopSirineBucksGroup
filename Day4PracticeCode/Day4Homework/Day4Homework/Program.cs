using Day4Homework;

//then, use this class to create at least 3 objects in Program.cs

Name firstperson = new Name();

firstperson.FirstName = "Tom";
firstperson.LastName = "Jones";
firstperson.Age = 23;
firstperson.Adult = true;
firstperson.BirthYear = 2000;

//build an output with the values stored in these 3 objects

string firstpersoninfo = $"Name: {firstperson.FirstName} {firstperson.LastName} Age: {firstperson.Age} Birth Year: {firstperson.BirthYear} Adult: {firstperson.Adult}";

Console.WriteLine(firstpersoninfo);