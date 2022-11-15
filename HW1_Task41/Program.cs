// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Clear();

int[] GetArrayFromString(string stringarray)
{
    string[] nums = stringarray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = Convert.ToInt32(nums[i]);
    }
    return result;
}

Console.WriteLine("Please enter any amount of numbers via space (use spacebar):");
string numbers = Console.ReadLine();
int[] array = GetArrayFromString(numbers);
int count = 0;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("The numbers above 0 are: ");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
        Console.Write($"{array[i]} ");
    }
}
Console.ResetColor();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"You have entered {count} numbers which are bigger than 0.");