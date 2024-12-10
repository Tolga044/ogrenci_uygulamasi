using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ögrenci_uygulaması
{
    internal class Ogrenci
    {
        private string? isim;
        private string? soyisim;
        private string? okulAdı;
        private int okulNo;
        private int vize1;
        private int vize2;
        private int final;



        public Ogrenci(string? _isim,string? _soyisim,string? _okulAdı, int _okulNo , int _vize1,int _vize2,int _final)
        {
              isim= _isim;
            soyisim= _soyisim;
            okulAdı = _okulAdı;
            okulNo = _okulNo;
             vize1= _vize1;
            vize2= _vize2;
            final= _final;
        }


        public void ÖgrenciBilgileriniGoster()
        {
            Console.WriteLine( "ögrenci adı:"+isim );
            Console.WriteLine( "ögrenci soyadı:"+soyisim);
            Console.WriteLine( "ögrenci okul adı:"+okulAdı );
            Console.WriteLine("ögrenci okul numarası:"+okulNo);
            Console.WriteLine("ögrenci vize notu"+vize1);
            Console.WriteLine("ögrenci 2. vize notu:"+vize2);
            Console.WriteLine("ögrenci final notu:"+final);
        }

      public double ögrenciOrtalaması()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;

            return ortalama;
        }

        public void ögrenciokul()
        {
            Console.WriteLine("okul adı:"+okulAdı);
        }
    }
}
