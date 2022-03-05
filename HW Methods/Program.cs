using HW_Methods;


Console.WriteLine("Для решения уравнения A(X*X)+B+C=0, введите число A:");
int a = Convert.ToInt32(Console.ReadLine());
string r;

r = IfElse.GetDoubleFiguresInLetters(a);
Console.WriteLine(r);