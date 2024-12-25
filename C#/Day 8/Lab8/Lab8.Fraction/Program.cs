using Lab8.Fraction;

clsFraction f1 = new clsFraction(1, 3);
clsFraction f2 = new clsFraction(2, 4);
Console.WriteLine(f1);
Console.WriteLine(f1.Equals(new clsFraction(1, 3)));
Console.WriteLine(clsFraction.Simplify(f1));
Console.WriteLine(f1 + f2);