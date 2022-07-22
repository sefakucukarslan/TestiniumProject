using TechTalk.SpecFlow;
using TestiniumProject.Steps.BaseSteps;
using TestiniumProject.Models;
using NUnit.Framework;

namespace TestiniumProject.Steps
{
    [Binding,Scope(Feature ="KitapYurdu")]
    public class KitapYurduSteps : BaseStep
    {
        KitapYurduModel model = new KitapYurduModel();


        [StepDefinition(@"Kitap Yurdu sitesi acılır")]
        public void OpenPage()
        {
            model.OpenPage("https://www.kitapyurdu.com/");
        }


        [StepDefinition(@"Ana sayfanın acıldıgı kontrol edilir")]
        public void AnasayfaKontrol()
        {
            model.AnasayfaKontrol();
        }

        [StepDefinition(@"Ürün arama alanına csv dosyasındaki veri yazılır ve klavyeden enter tusuna basılır")]
        public void UrunArama()
        {
            model.UrunArama(@"C:\Users\autum\Desktop\Deneme.csv");
        }
        
        [StepDefinition(@"Listelenen kitapların arasından rastgele bir kitap secilir")]
        public void KitapSecimi()
        {
            model.KitapSecimi();
        }
        
        [StepDefinition(@"Sepete ekle butonuna basılır")]
        public void SepetEkle()
        {
            model.SepetEkle();
        }
        
        [StepDefinition(@"Sayfanın sag ust kısmında bulunan sepet ikonundaki deger kontrol edilir")]
        public void IkonKontrol()
        {
            Assert.AreEqual(model.IkonKontrol(), "1");
        }
        
        [StepDefinition(@"Sepetim butonuna tıklanır")]
        public void SepetimClick()
        {
            model.SepetimClick();
        }
        
        [StepDefinition(@"Sepete git butonuna tıklanır")]
        public void SepeteGitClick()
        {
            model.SepeteGitClick();
        }
        
        [StepDefinition(@"Urun miktarı 1 adet arttırılır")]
        public void UrunAdet()
        {
            model.UrunAdet();
        }
        
        [StepDefinition(@"Yenile butonuna basılır")]
        public void YenileClick()
        {
            model.YenileClick();
        }
        
        [StepDefinition(@"Sepetiniz guncelleniyor yazısının geldigi kontrol edilir")]
        public void GuncellemeKontrol()
        {
            Assert.AreEqual(model.GuncellemeKontrol(), "Sepetiniz güncelleniyor!");
        }
        
        [StepDefinition(@"Carpı butonuna basılır")]
        public void CarpıClick()
        {
            model.CarpıClick();
        }
        
        [StepDefinition(@"Sepetin bos oldugu kontrol edilir")]
        public void SepetKontrol()
        {
            Assert.AreEqual(model.SepetKontrol(), "0");
        }

    }
}
