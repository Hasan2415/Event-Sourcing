using Core;

var personRepository = new PersonRepository();

var personv2 = personRepository.Get(1,2);
Console.WriteLine("Object with version");
Console.WriteLine($"Id : {personv2.Id} ; First Name : {personv2.FirstName} ; " +
    $"Last Name : {personv2.LastName} ; Email : {personv2.Email} ; " +
    $"Mobile : {personv2.Mobile}");

Console.WriteLine();
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

var person = personRepository.Get(1);
Console.WriteLine("Finally object");
Console.WriteLine($"Id : {person.Id} ; First Name : {person.FirstName} ; " +
    $"Last Name : {person.LastName} ; Email : {person.Email} ; " +
    $"Mobile : {person.Mobile}");
