Console.WriteLine("Type probability of random variable: ");
string? input = Console.ReadLine();
float p;
if (!float.TryParse(input, out p))
{
    p = 0.0f;
}
float res = 0;
Console.WriteLine("Type numbers and then '#' to compute result: ");
input = Console.ReadLine();
iiiiiiii num;
while (input != "#")
{
    if (!int.TryParse(input, out num))
    {
        num = 0;
    }
    res += num * p;
    input = Console.ReadLine();
}

Console.WriteLine($"The mathematical expectation is: {res}");

