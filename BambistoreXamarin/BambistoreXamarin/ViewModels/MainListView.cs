using Android.Opengl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BambistoreXamarin.ViewModels
{
    public class MainListView
    {
        private Product _oldProduct;
        public ObservableCollection<Product> Products { get; set; }
        
        public MainListView()
        {
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Title = "KURUMSAL",
                    Altbaslik="Hakkımızda",
                    Altbaslik2="Mağazalarımız",
                    Altbaslik3="Kampanyalar Ve Duyurular",
                    Altbaslik4="Bilgi Toplum Hizmeti",
                    Altbaslik5=null,
                    Altbaslik6=null,
                    Altbaslik7=null,
                    Altbaslik8=null,
                    Vsblty=true,
                    Vsblty2=false,
                    Isvisible =false
                },
                  new Product
                {
                    Title = "Müşteri Hizmetleri",
                    Altbaslik="İletişim",
                    Altbaslik2="Kargo ve Teslimat",
                    Altbaslik3="Kargom Nerede",
                    Altbaslik4="İade ve İptal Koşulları",
                    Altbaslik5="Sıkça Sorulan Sorular",
                    Altbaslik6="İzinli İletişim",
                    Altbaslik7="Ödeme Seçenekleri",
                    Altbaslik8="Gizlilik - Veri Güvenliği Ve Çerez Politakası",
                    Vsblty=true,
                    Vsblty2=true,
                    Isvisible =false
                },
                new Product
                {
                    Title = "Hesabım",
                    Altbaslik="Hesap Bilgilerim",
                    Altbaslik2="Sipariş Takip",
                    Altbaslik3="Sepetim",
                    Vsblty=false,
                    Vsblty2=false,
                    Isvisible =false
                }
            };
   

        }
        public void ShoworHiddenProducts(Product product)
        {
            if (_oldProduct == product)
            {
                product.Isvisible = !product.Isvisible;
                UpDateProducts(product);
            }
            else
            {
                if (_oldProduct != null)
                {
                    _oldProduct.Isvisible = false;
                    UpDateProducts(_oldProduct);

                }
                product.Isvisible = true;
                UpDateProducts(product);
            }
            _oldProduct = product;
        }

        private void UpDateProducts(Product product)
        {

            var Index = Products.IndexOf(product);
            Products.Remove(product);
            Products.Insert(Index, product);

        }
    }
}
