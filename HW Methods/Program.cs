using HW_Methods;
double a = Convert.ToInt32(Console.ReadLine());
double b = Convert.ToInt32(Console.ReadLine());
double c = Convert.ToInt32(Console.ReadLine());
double d = Convert.ToInt32(Console.ReadLine());


string result = Variables.GetStraightLineEquation(a, b, c, d);
Console.WriteLine(result);

