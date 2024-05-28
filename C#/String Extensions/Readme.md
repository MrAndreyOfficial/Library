This library has 2 extension methods:
1. Reverse() - reverses a string
2. IsRecursiveAcronym([bool useWordCase = false]) - check if the value is a recursive acronym

To use this libray, you should:
1. Add reference to your project
2. Use the StringUtility namespace

Example:
```
using StringUtility;

var phpWord = "pHP";

Console.WriteLine(phpWord.IsRecursiveAcronym()); // true

Console.WriteLine(phpWord.IsRecursiveAcronym(true)); // false

Console.WriteLine(phpWord.Reverse()); // PHp
```
