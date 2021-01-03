using RecordsDemo;
using System;


// a record is just a class with some fancy (prebuilt code), features:
// Immutable (readonly class)
// overwritten == operator to do value comparison
// overwritten GetHashCode to match with value comparison
// overwritten Equals to do value comparison
// can be easily deconstructed to tupple variables (however full syntax should be used)
// copying records with making changes ('with' keyword)
// can be inheritted
// can have access of properties changes
// can have methods
// Thread safe by definition (because its ummutable)

Console.WriteLine("Uing Records!");
PersonRecord personRec1 = new("Krasimir", "Atanasov"); 
PersonRecord personRec2 = new("Krasimir", "Atanasov");
PersonRecord personRec3 = new("Krassy", "Atanasov");

PersonClass personClass1 = new("Krasimir", "Atanasov");
PersonClass personClass2 = new("Krasimir", "Atanasov");
PersonClass personClass3 = new("Krassy", "Atanasov");

Console.WriteLine("Records have their ToString overwritten");
Console.WriteLine($"personRec1: {personRec1}, personClass1: {personClass1}");
Console.WriteLine($"personRec2: {personRec2}, personClass2: {personClass2}");
Console.WriteLine($"personRec3: {personRec3}, personClass3: {personClass3}");
Console.WriteLine("-------");

Console.WriteLine($"records have their GetHashCode overwritten to match value comparison:");
Console.WriteLine($"personRec1.GetHashCode(): {personRec1.GetHashCode()}, personClass1.GetHashCode(): {personClass1.GetHashCode()}");
Console.WriteLine($"personRec2.GetHashCode(): {personRec2.GetHashCode()}, personClass2.GetHashCode(): {personClass2.GetHashCode()}");
Console.WriteLine($"personRec3.GetHashCode(): {personRec3.GetHashCode()}, personClass3.GetHashCode(): {personClass3.GetHashCode()}");
Console.WriteLine("-------");

Console.WriteLine($"records have their == operator overwritten to match value comparison:");
Console.WriteLine($"personRec1 == personRec2: {personRec1 == personRec2}, personClass1 == personClass2: {personClass1 == personClass2}");
Console.WriteLine($"personRec1 == personRec3: {personRec1 == personRec3}, personClass1 == personClass3: {personClass1 == personClass3}");
Console.WriteLine("-------");

Console.WriteLine($"records have their Equals operator overwritten to match value comparison:");
Console.WriteLine($"Equals(personRec1, personRec2): {Equals(personRec1, personRec2)}, Equals(personClass1, personClass2): {Equals(personClass1, personClass2)}");
Console.WriteLine($"Equals(personRec1, personRec3): {Equals(personRec1, personRec3)}, Equals(personClass1, personClass3): {Equals(personClass1, personClass3)}");
Console.WriteLine("-------");

Console.WriteLine($"records are still different objects, as seen by ReferenceEquals method:");
Console.WriteLine($"ReferenceEquals(personRec1, personRec2): {ReferenceEquals(personRec1, personRec2)}, ReferenceEquals(personClass1, personClass2): {ReferenceEquals(personClass1, personClass2)}");
Console.WriteLine($"ReferenceEquals(personRec1, personRec3): {ReferenceEquals(personRec1, personRec3)}, ReferenceEquals(personClass1, personClass3): {ReferenceEquals(personClass1, personClass3)}");
Console.WriteLine("-------");

Console.WriteLine("If using full notation records can be deconstructed to tupples:");
(var fn, var ln) = personRec1;
Console.WriteLine($"(var fn, var ln) = personRec1; fn: {fn}, ln: {ln}");

var personRec4 = personRec1 with
{
    FirstName = "K."
};
Console.WriteLine($"Copying records and applying changes (with keyword): {personRec4}");

CustomerRecord custRec1 = new CustomerRecord(1, "Krasimir", "Atanasov");
Console.WriteLine($"adding properties to default definition: {custRec1}");
Console.WriteLine($"custRec1.FirstName: {custRec1.FirstName}");








