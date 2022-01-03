

namespace _1._2._2_random_uden_dubletter
{
    class Program
    {

        public static int[] Lotto()
        {
            int[] tab = new int[5];

            Random random = new Random();

            int i = 0;
            bool fundet = false;

            //antal tal der skal udskrives - her udskriver den 5
            while (i < 5)
            {
                // tal mellem hvad i denstående 1-5
                int tal = random.Next(1, 6);

                for (int j = 0; j < tab.Length; j++)
                {
                    if (tab[j] == tal)
                    {
                        fundet = true;
                    }
                }
                if (fundet)
                {
                    fundet = false;
                    i--;
                }
                else
                {
                    tab[i] = tal;
                }
                i++;
            }
            return tab;

        }
        static void Main(string[] args)
        {
            int[] tab = Lotto();

            for (int k = 0; k < tab.Length; k++)
            {
                Console.WriteLine(tab[k]);
            }
        }
    }
}
