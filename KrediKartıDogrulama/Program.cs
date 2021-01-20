using System;

namespace KrediKartıDogrulama
{
    class Program
    {
        static void Main(string[] args)
        {

            int tek = 0, cift = 0, sayi = 0, k = 0;
            long a = 8468335964683359;
            int b = a.ToString().Length;
            if (b == 16)
            {
                for (int i = 0; i <= 15; i++)
                {
                    sayi = Convert.ToInt32(a.ToString().Substring(i, 1));
                    if (sayi % 2 == 0)
                    {
                        cift += sayi;
                    }
                    if (sayi % 2 == 1)
                    {
                        tek += (sayi * 2);
                    }

                }
                if ((cift + tek) % 10 == 0 && (cift * 2) > 80)
                {
                    Console.WriteLine("doğru kredi kartı no girdin");
                }
                else
                {
                    Console.WriteLine(" kk no yanlış");
                }



            }

        }
    }
}