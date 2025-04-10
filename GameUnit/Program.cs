using System;

namespace GameUnit
{
    public class Program
    {
        private static void Main(string[] args)
        {
            MilitaryUnit militaryUnit = new MilitaryUnit(3, 8, 10);
            militaryUnit.Move();
            Console.WriteLine($"Health: {militaryUnit.Health}");
            Console.WriteLine($"Cost: {militaryUnit.Cost}\n");

            SettlerUnit settlerUnit = new SettlerUnit();
            settlerUnit.Move();
            Console.WriteLine($"Health: {settlerUnit.Health}");
            Console.WriteLine($"Cost: {settlerUnit.Cost}\n");
            
            militaryUnit.Attack(settlerUnit);
            Console.WriteLine($"Health: {militaryUnit.Health}");
            Console.WriteLine($"Health: {settlerUnit.Health}");
            
        }
    }
}
