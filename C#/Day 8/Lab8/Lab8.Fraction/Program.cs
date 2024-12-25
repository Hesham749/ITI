using Lab8.Fraction;

clsFraction f1 = new clsFraction(32, 24);
Console.WriteLine(f1);
Console.WriteLine(f1.Equals(new clsFraction(1, 3)));
Console.WriteLine(clsFraction.Simplify(f1));