using Lab8.Fraction;

ClsFraction f1 = new ClsFraction(3, 5);
ClsFraction f2 = new ClsFraction(4, 2);
Console.WriteLine(f1);
Console.WriteLine(f1.Equals(new ClsFraction(1, 3)));
Console.WriteLine(ClsFraction.Simplify(f1));
Console.WriteLine(f1 + f2);
Console.WriteLine(++f1);
Console.WriteLine(f1 + 2);
Console.WriteLine(f1 - f2);
Console.WriteLine($"f1 : {f1}");
Console.WriteLine(f1 * f2);
Console.WriteLine(f1 * 1);
Console.WriteLine(f1 / f2);
Console.WriteLine(f1 / 1);
if (f1 > f2)
    Console.WriteLine($"{f1} > {f2}");
if (f1 < f2)
    Console.WriteLine($"{f1} < {f2}");

