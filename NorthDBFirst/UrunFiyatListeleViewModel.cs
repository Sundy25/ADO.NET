using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthDBFirst
{
   public class UrunFiyatListeleViewModel
    {
        // ürünlerimi ürün adı fiyat ve stopktaki toplam ürünlerimin fiyatı olacak şeklde raporlayalım.

        public string UrunAdi { get; set; }
        public Nullable<decimal> Fiyat { get; set; } // bu eski yöntem nullable yapma
        public short? Stok { get; set; } // bu yeni yöntem nullable yapmak.
        public decimal? ToplamFiyat { get; set; } // fiyatı null olan ürün var mı? Null girebiliriz fiyat tablosuna, stok kategori vs de null girebilir. NUll bir değer atarsak patlar mı? Patlar. Neden? 
        // çünkü value tiplidir. Bunları nullable diye bir class açmışlar.  Mesela Fiyatı öyle yapalkım.
    }
}
