using NGSSTask.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGSSTask
{
    class Program
    {
        static void Main(string[] args)
        {
            git4:

            //alışveriş tutarını alma
            Console.Write("Yaptığınız alışveriş tutarını giriniz : ");
            double tutar ;

            //Klavyeden alınan alışveriş tutarı doğru ise değişkene atama
            if (double.TryParse(Console.ReadLine(), out tutar))
            {
                //Kullanıcıya kategori seçimi yaptırma
                Console.WriteLine("Alışveriş Kategorisini seçiniz \n1-Dizüstü Bilgisayar \n2-Masaüstü Bilgisayar\n3-Telefon \n4-Televizyon \n5-Oyun konsolu");
                int kategori;
                if (int.TryParse(Console.ReadLine(), out kategori))
                {
                    if (kategori < 0)
                        kategori *= -1;

                    //seçilen kategori telefon değilse indirim uygulanır
                    if (kategori != 3 && kategori<=5)
                    {

                        //Her 200$ için 5$ indirim tutarının hesaplanması.
                        int dis = Convert.ToInt32(tutar / 200);
                        tutar -= Convert.ToDouble(dis * 5);

                    git:

                        //Hangi %lik inirim türü uygulanacak.
                        Console.WriteLine("1-Gold Kartım Var \n2-Silver Kartım Var \n3-Kartım Yok");
                        int secim;

                        //Yapılan seçim int ise indirimleri uygula
                        if (int.TryParse(Console.ReadLine(), out secim))
                        {

                            switch (secim)
                            {
                                //Gold kart sahibiyse
                                case 1:
                                    using (Gold gold = new Gold())
                                    {
                                        gold.GoldCard = tutar;
                                        tutar = gold.GoldCard;
                                    }
                                    break;

                                //Silver kart sahibiyse
                                case 2:
                                    using (Silver silver = new Silver())
                                    {
                                        silver.SilverCard = tutar;
                                        tutar = silver.SilverCard;
                                    }
                                    break;
                                //Kart sahibi değilse mağaza müşterisi mi sorgusu
                                case 3:
                                git2:
                                    Console.WriteLine("Mağaza müşterisi misiniz ? (E/H)");
                                    string eh = Console.ReadLine().ToLower();
                                    if (eh == "e")
                                    {
                                    git3:
                                        Console.Write("Kaç yıldır müşterimizsiniz ? ");
                                        int yil;
                                        if (int.TryParse(Console.ReadLine(), out yil))
                                        {
                                            //negatif sayı girse de pozitife çevrildi
                                            if (yil < 0)
                                                yil *= (-1);

                                            //2 yıldan uzun süredir müşteri ise
                                            if (yil > 2)
                                            {
                                                using (Customer customer = new Customer())
                                                {
                                                    customer.Customer2 = tutar;
                                                    tutar = customer.Customer2;
                                                }
                                            }

                                            //2 yıldan daha az süredir müşteri ise
                                            else
                                            {
                                                using (Customer customer = new Customer())
                                                {
                                                    customer.Customerr = tutar;
                                                    tutar = customer.Customerr;
                                                }
                                            }
                                        }




                                    }

                                    //Mağaza müşterisi mi sorusuna e/h dışında değer girilirse
                                    else if (eh != "h" && eh != "e")
                                    {
                                        Console.WriteLine("E veya H harfi giriniz!");
                                        goto git2;
                                    }


                                    break;
                                //verilen seçimler ışında bir giriş yapıllıysa
                                default:
                                    Console.WriteLine("Hatalı giriş yaptınız...");
                                    goto git;
                            }
                        }

                        //Yapılan seçim int değilse başa dön
                        else
                        {
                            Console.WriteLine("Yaptığınız seçimin doğru olduğundan emin olun!");
                            goto git;
                        }

                        //Her 200$lık alışverişe 5$ indirimin tutardan düşülmesi
                        tutar -= Convert.ToDouble(dis * 5);
                    }

                    Console.WriteLine("Net Fatura Tutarı : " + tutar);
                }
            }

            //Klavyeden alınan alışveriş tutarı doğru değil ise başa dön
            else
            {
                Console.WriteLine("Alışveriş tutarını kontrol ediniz!");
                goto git4;
            }

            Console.ReadLine();


        }
    }
}
