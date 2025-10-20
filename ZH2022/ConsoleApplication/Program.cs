using Common;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pg = new PersonGrower();
            pg.N = 5;
            PrintAndModify(pg);
        }

        public static void PrintAndModify(IPersonModifier modifier)
        {
            var me = Person.GetMe();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(me.GetDiscription());
                modifier.Modify(me);
            }
        }
    }
}
