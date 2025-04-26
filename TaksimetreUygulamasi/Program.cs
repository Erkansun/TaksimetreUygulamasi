namespace TaksimetreUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************");
            Console.WriteLine("* TAKSİMETRE UYGULAMASI *");
            Console.WriteLine("*************************");

            Console.WriteLine();

            decimal acilisUcreti = 150;

            Console.WriteLine("Gittiğiniz mesafeyi (km) giriniz:");
            int gidilenMesafe = Convert.ToInt32(Console.ReadLine());

        yenidenDene:

            Console.WriteLine("Lütfen seyahat tipinizi belirtin. Gündüz için 1, gece için 2 seçin:");
            int seyahatSekli = Convert.ToInt32(Console.ReadLine());

            if (gidilenMesafe > 0)
            {
                if (seyahatSekli == 1)
                {
                    decimal taksimetreUcreti = acilisUcreti + (gidilenMesafe * 25);
                    Console.WriteLine($"Gündüz tarifeli takismetre ücretiniz: {taksimetreUcreti} TL'dir.");
                }else if (seyahatSekli == 2)
                {
                    decimal taksimetreUcreti = acilisUcreti + (gidilenMesafe * 25) + ((gidilenMesafe * 25) * 20 / 100);
                    Console.WriteLine($"Gece tarifeli taksimetre ücretiniz: {taksimetreUcreti} TL'dir.");
                }
                else
                {
                    Console.WriteLine("Geçerli olmayan bir seçim yaptınız. Tekrar deneyin ...");
                    goto yenidenDene;
                }
            }else if (gidilenMesafe == 0)
            {
                Console.WriteLine($"İndi bindi ücreti {acilisUcreti} TL'dir.");
            }
            else
            {
                Console.WriteLine("Hata: Mesafe 0'dan küçük olamaz.");
            }

            Console.ReadLine();
        }
    }
}
