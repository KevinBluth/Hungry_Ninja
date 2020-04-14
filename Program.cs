using System;

namespace Hungry_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet NinjaBuffet = new Buffet();
            NinjaBuffet.Serve();
            Ninja Hayabusa = new Ninja();
            Hayabusa.Eat(NinjaBuffet.Serve());
            Hayabusa.Eat(NinjaBuffet.Serve());
            Hayabusa.Eat(NinjaBuffet.Serve());
            Hayabusa.Eat(NinjaBuffet.Serve());
            Hayabusa.Eat(NinjaBuffet.Serve());

        }
    }
}
