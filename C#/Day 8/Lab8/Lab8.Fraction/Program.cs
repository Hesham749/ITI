using Lab8.Fraction;

clsFraction f1 = new clsFraction(162, 15);
clsFraction f2 = new clsFraction(1, 2);
Console.WriteLine(f1);
Console.WriteLine(f1.Equals(new clsFraction(1, 3)));
Console.WriteLine(clsFraction.Simplify(f1));
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

