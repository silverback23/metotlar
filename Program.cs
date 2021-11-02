using System;

namespace Metotlar
{ class Program
 {
static void Main(string[] args)
 {

    //erişim belirteci geris_dönüş_tipi metot_adi(paremetre listesi/argüman)
    //{
         ///komutlar
         //return;
    //}
    
    int a=2;
    int b=3;
    Console.Write(a+b);

    int sonuc=Topla(a+b);
    Console.Write(sonuc);

    Metotlar ornek =new Metotlar();
    ornek.EkranaYazdir(Convert.ToString(sonuc));

            
 }

 static int Topla(int deger1, int deger2)
 {
     return  (deger1+deger2);
 }
 
 }

 class Metotlar
 {
     public void EkranaYazdir(string veri)
     {
         Console.Write(veri);
     }
 }

}
