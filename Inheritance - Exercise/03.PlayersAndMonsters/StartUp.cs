namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main()
        {
            var hero = new PlayersAndMonsters.Hero("HeroUser", 1);
            var elf = new PlayersAndMonsters.Elf("ElfUser", 2);
            var darkWizard = new PlayersAndMonsters.DarkWizard("DarkWizardUser", 3);
            var bladeKnight = new PlayersAndMonsters.BladeKnight("BladeKnightUser", 4);

            Console.WriteLine(hero);
            Console.WriteLine(elf);
            Console.WriteLine(darkWizard);
            Console.WriteLine(bladeKnight);
        }
    }
}