using North.BLL;
using NorthModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORTH.UI.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // UI da DAL ekleyemeyiz. 


//        DAL- Data Access layer - veri erişim katmanı.SQL olabilir, Servis olabilir, xml ya da json data olabilir.Yada bunların bir kaçı veya hepsi olabilir. 
//O zaman kaç bağlantı olduğu sayısı* Dal.Şimdilik bir veri erişim katmanı olacak. İstediğimiz srguları bize getirmektir görevi.Veri erişimini
//görecek olan nesnedir.

//BLL- BUsiness Logic layer - İş mantık katmanı.Select, insert delete nasıl yapılır vs genel olarak veri erişim kurallarımızı burada yazarız. 
//Örn.tüm ürünleri listeleyen methodun BLL içinde yazılmış olması gerekmektedir.

//UI-  wfa, uapp, mvc, html, webform, consol, xamarin, api, wcf visual içinde ne yazabiliyorsak o olabilir.
//Kaç sunum katmanınız varsa o kadar UI ımız olur.

//Model veya Poco veya ntt - Poco class Nav. prop vs yazdığımız veri tabanı ilişkilendirme sınıflarıdır.


//DAL,BLL ve Poco nun olacağı projeler class librarydir. 

//şimdi kim kimden referans alıyor? 

//-DAL da model katmanı referans olarak almalıyız.

//-Dal da veriye erişim olacak.Dal verinin tipini poco dan görecek.

//- BLL hem poco yu hem DAL ı görmeli. BLL bunu görmezse, içine yazılacak kurallar çalıştırılacağı yeri göremez. Dal ne kadar çoksa bll den o kadar
//katmana gitmemiz lazım


//Şimdi DB first ile bunu bir uygulayalım

//---DB First te model katmanı yazamıyoruz. O yüzden pocu yok.
//--UI poco ve BLL i görmesi lazım.UI katmanları DAL ı göremez.UI DAL ı güvenlik açısından göremez. 
//--DAL ve BLL Class Lib olur. 
//--UI lar formapp olur. 
//BLL deki tüm public nesnelere erişebiliriz böylece.

//--BLL DAL ı görecek.Onun da referanslarına ekliyoruz.

//UI.da form a referanslarına BLL yi ekleriz.

//-- şimdi DAL da dbfirst yapacağız.Hepsine entity ekleyelim.
        private void Form1_Load(object sender, EventArgs e)
        {
            UrunRepo urunRepo = new UrunRepo();
            /* var urunler = urunRepo.TumUrunleriGetir();*/ // hata veriyor neden? Product.cs şu an NorthDal daki northmodelin içinde. Ana klasör içinde class lib north.Model adında  açsak. İçi şu an boş tabi. Northmodel class lib in içine de product.cs yi kesip yapıştırsak. Bu product.cs nin içini kopyalayıp, yeni açtığımız northmodel class içine yapıştırsak kullanabiliriz. 

            //---------------------------------------------------------------------------------------------------


            //BU ALTTAKİ KOD ÇALIŞMAZ
           // List<Product> urunler = urunRepo.TumUrunleriGetir(0); // ama bu da olmadı. İşte bu yüzden dbfirst içinde entire project yapamıyoruz. Sıkıntımız bu. Olmuyor dbfirst te bu. O yüzden CODE FIRST TE YAZACAĞIZ BUNU. ŞİMDİ BUNU GÖRECEĞİZ.  Bu PROJE SIÇIŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞ
            // BU BİR EŞEĞİ KAYBETME PROJESİYDİ. TAKILMA. SADECE OLMADIĞINI GÖRMEK İÇİN YAPTIK. 

        }
    }
}
