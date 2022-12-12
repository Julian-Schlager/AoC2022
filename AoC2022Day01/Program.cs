string input = File.ReadAllText("C:/Users/Julian.Schlager/OneDrive - HTL Vöcklabruc/HTL VB/Swp/5AHWII/AoC2022/input.txt");

int maxCalories = input.Split("\r\n\r\n").Max(elf => elf.Split("\r\n").Sum(int.Parse));

Console.WriteLine(maxCalories.ToString());