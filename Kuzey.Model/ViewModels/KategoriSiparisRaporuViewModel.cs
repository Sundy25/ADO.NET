
public class KategoriSiparisRaporuViewModel
{
    public int SiparisId { get; set; }
    public string KategoriAdi { get; set; }
    //public string UrunAdi { get; set; }
    //public decimal UrunFiyati { get; set; }
    public decimal Toplam { get; set; }
    //public short Adet { get; set; }

    // selectte bunların hepsini seçmesen bile repository classının içinde çalıştırdığın zaman tablonun hepsi gelir. Buradan iptal etmen lazım istemediklerini. 
}