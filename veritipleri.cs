    internal class Program
    {
        static void Main(string[] args)
        {
            //İlkel (Primitive) Veri Tipleri:
            /*
             * Özellikleri:
             * - Her biri sayı temellidir.
             * - Dijital elektronik yapıları herbirinde aynı şekilde farklı isimlerle bulunur.
             * - Pozitif tamsayılar 0'dan, negatif tamsayılar -1'den başlar.
             */

            //Tam sayılar:
            byte bayt = 255; //Bellekte 1byte (8bit) yer kaplar. 0 ~ 255 (2^8-1) arası değer alır.
            Console.WriteLine(bayt);

            short kisa = 30000; //Bellekte 2byte (16bit) yer kaplar. -2^15 ~ 2^15-1
            Console.WriteLine(kisa);

            ushort isaretsiz_kisa = 60000; //Bellekte 2byte (16bit) yer kaplar. 0 ~ 2^16-1
            Console.WriteLine(isaretsiz_kisa);

            int tam = 2147000000; //* 4byte (32bit) yer kaplar. -2^31 ~ 2^31-1
            uint isaretsiz_tam = 4294000000; // 4byte (32bit) yer kaplar. 0 ~ 2^32-1

            long uzun = 123456789123456789L; //* 8byte (64bit) yer kaplar. -2^63 ~ 2'63-1. Sonuna belirteç olaral L karakteri gelebilir.
            ulong isaretsiz_long = 123456; // 8byte (64bit) yer kaplar. 0 ~ 2'64-1 

            //Kayan Nokta (Floating Point): Genel olarak ondalıklı sayıları tanımlamak için kullanılan yapılardır.

            float tek = 14.475F; // 4byte (32bit) yer kaplar, sonuna F karakteri yazılmalıdır.

            double cift = 14.475; //* 8byte (64bit) yer kaplar, sonuna D karakteri yazılabilir.

            decimal ondalik = 14.475M; //* 16byte (128bit) yer kaplar, sonuna M karakteri yazılmalıdır. Bu yapı sadece C# dilinde vardır.

            //Karakter: 2byte (16bit) yer kaplar. Karakterler tek tırnak içerisine yazılır.
            char karakter = 'A'; //A: 65

            //Mantıksal: 1byte yer kaplar. true(1) veya false(0) olmak üzere iki değerden birini alır.
            bool mantiksal_dogru = true;
            bool mantiksal_yanlis = false;

            //Referans Veri Tipler: İlkel veya başka referans veri tipleri kullanarak yeni veri tipleri oluşturabiliriz, bu yapılara referans veri tipi denir.

            //Karakter Dizisi/Metin veri tipi: Birden fazla char tipinin birleşimin oluşur.Çift tırnak kullanır.
            string isim = "ismin";

            Console.WriteLine(isim);
        }
    }
