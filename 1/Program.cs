using System.Linq;

var result = new List<int>();

var input = System.IO.File.ReadAllLines("./puzzleInput.txt");

var accumulatedCalories = 0;

foreach (var line in input)
{
    if (line.Length == 0)
    {
        result.Add(accumulatedCalories);
        accumulatedCalories = 0;
        continue;
    }
    accumulatedCalories += int.Parse(line);

}
if (accumulatedCalories > 0)
{
    result.Add(accumulatedCalories);
}

Console.WriteLine("Part 1:");
Console.WriteLine(result.Max());

result.Sort();
Console.WriteLine("Part 2:");
int resCount = result.Count;
int result2 = 0;
for (int i = 1; i < 4; i++)
{
    result2 += result[resCount - i];
}

Console.WriteLine(result2);