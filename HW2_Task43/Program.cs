// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Two straight line equations are given: y = k1 * x + b1 and y = k2 * x + b2. Lets find out if these lines cross and at which point.");
Console.WriteLine("Please enter b1 parameter: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter k1 parameter: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter b2 parameter: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter k2 parameter: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = Convert.ToDouble((b2 - b1) / (k1 - k2));
double y = Convert.ToDouble(k2 * x + b2);

if (k1 == k2)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("The lines do not cross. Parametrs k1 and k2 must not be equal for lines to cross. Please re-enter. ");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine($"The lines meet at these dot coordinates:({Math.Round(x,1)}; {Math.Round(y,1)})");
}

// решение через массивы

// Console.Clear();
// Console.WriteLine("Two straight line equations are given: y = k1 * x + b1 and y = k2 * x + b2. Lets find out if these lines cross and at which point.");
// Console.WriteLine("Please enter b1, k1, b2 and k2 parameters via spacebar:");
// string numbers = Console.ReadLine();
// double[] para = GetArrayFromString(numbers);

// double[] GetArrayFromString(string stringarray)
// {
//     string[] nums = stringarray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
//     double[] result = new double[nums.Length];
//     for (int i = 0; i < nums.Length; i++)
//     {
//         result[i] = Convert.ToDouble(nums[i]);
//     }
//     return result;
// }

// double x = Convert.ToDouble((para[2] - para[0]) / (para[1] - para[3]));
// double y = Convert.ToDouble(para[3] * x + para[2]);

// if (para[1] == para[3])
// {
//     Console.ForegroundColor = ConsoleColor.DarkRed;
//     Console.WriteLine("The lines do not cross. Parametrs k1 and k2 must not be equal for lines to cross. Please re-enter. ");
// }
// else
// {
//     Console.ForegroundColor = ConsoleColor.DarkCyan;
//     Console.WriteLine($"The lines meet at these dot coordinates:({Math.Round(x,1)}; {Math.Round(y,1)})");
// }