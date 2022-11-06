using System;

namespace AlgorythmsLab3.Interface.functions
{
    public class ExitMenuItem : MenuItem
    {
        public ExitMenuItem() : base("Выход")
        {
        }

        public override void Execute()
        {
            Console.WriteLine("Выход");
        }
    }
}