using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Pesho", 1);
            Elf elf = new Elf("Gosho", 1);
            MuseElf museElf = new MuseElf("Ivan", 1);
            Wizard wizard = new Wizard("Stamat", 1);
            DarkWizard darkWizard = new DarkWizard("Balmain", 1);
            SoulMaster soulMaster = new SoulMaster("Siro", 1);
            Knight knight = new Knight("Kay", 1);
            DarkKnight darkKnight = new DarkKnight("Dxy", 1);
            BladeKnight bladeKnight = new BladeKnight("Bray", 1);
            System.Console.WriteLine(hero);
            System.Console.WriteLine(elf);
            System.Console.WriteLine(museElf);
            System.Console.WriteLine(wizard);
            System.Console.WriteLine(darkWizard);
            System.Console.WriteLine(soulMaster);
            System.Console.WriteLine(knight);
            System.Console.WriteLine(darkKnight);
            System.Console.WriteLine(bladeKnight);
        }
    }
}
