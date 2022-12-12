string input = File.ReadAllText("input.txt");
Console.WriteLine(input);

int maxCalories = input.Split("\r\n\r\n").Max(elf => elf.Split("\r\n").Sum(int.Parse));

Console.WriteLine(maxCalories.ToString());