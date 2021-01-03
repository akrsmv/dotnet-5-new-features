// 1. Top level code
// 2. init keyword (private set improvements)
// 3. constructors improvements (new())
// 4. Relational pattern matching (see in BlazorServerApp/WhetherService.cs)
// 5. Logical Pattern Matching (in BlazorUI project)
// 6. Records


// change to .Net 5
// tools->options->text editor->c#->Advanced-> "Display inline parameters(experimental)"


using System;
using ConsoleUI;

// top level calls - useful for avoiding boilerplate, ex when doing microservices and have 100ds of public static void Main....
Console.WriteLine("Hello World!");
Console.WriteLine(Add(4, 3));
Console.WriteLine(args); // args input params still there

var c1 = new CustomerModel { Id=1, FirstName="Krassimir", LastName="Atanasov"};
// c1.Id = 2; // not possible, allowed ^^ only once, because of the init keyword
c1.FirstName = "Krassy";

// clearer ctors:
CustomerModel c2 = new(2,"Krassy","akrsmv");

// however AVOID this:
CustomerModel c3;
//... lots of code
c3 = new(); // whats c3??
if (c3 is not null) // 'not' keyword part of the logical pattern matchers
{
    //...
}


// the method Add is actually with the clojure of Main (local methods)
static double Add(double x, double y)
{
    return x + y;
}

// some exception - public classes still possible here, but NOT a good idea
public class PersonModel
{
    public int MyProperty { get; set; }
}