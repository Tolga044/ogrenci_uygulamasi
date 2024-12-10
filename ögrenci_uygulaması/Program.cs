using ögrenci_uygulaması;

internal class Program
{
    private static void Main(string[] args)
    {
        bool kontrol = true;
        Ogrenci ogrenci1 = new Ogrenci("tolga", "pektaş", "pamukkale üniversitesi", 44, 100, 100, 100);
        Console.WriteLine("uygulamamıza hoşgeldiniz... yapmak istediğiniz işlemi seçiniz");
        islemleriGoster();



        while (kontrol)
        {
            string? secim = Console.ReadLine();


            switch (secim)

            {


                case "1":

                    ogrenci1.ÖgrenciBilgileriniGoster();
                    break;

                case "2":
                    double ögrenciortalama = ogrenci1.ögrenciOrtalaması();
                    Console.WriteLine( "ögrenci ortalaması:"+ögrenciortalama );
                    break;

                case "3":
                    ogrenci1.ögrenciokul();
                    break;
                
                case "4":
                    kontrol= false;
                    break;
            }





        }

        static void islemleriGoster()
        {
            Console.WriteLine("1-ögrenci bilgilerini göster");
            Console.WriteLine("2- ögrenci ortalaması göster");
            Console.WriteLine("3- ögrenci okulunu ögren" );
            Console.WriteLine("4-cıkış yap");
        }
    }
}