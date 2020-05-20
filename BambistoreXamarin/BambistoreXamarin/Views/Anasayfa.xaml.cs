using ImageCircle.Forms.Plugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace BambistoreXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Anasayfa : ContentPage
    {
        public Anasayfa()
        {
            InitializeComponent();
            List<string> slide = new List<string>()
            {
                "https://www.bambistore.com.tr/Uploads/Slider/kadin-yeni-sezon-ss20-209.jpg?t=20200512155012",
                "https://www.bambistore.com.tr/Uploads/Slider/erkek-yeni-sezon-210.jpg?t=20200512155021"
            };
            CarouseSlide.ItemsSource = slide;
            Textkdn.TextDecorations = TextDecorations.Underline;
        }
    
       private async void CarouselKadin(object sender, EventArgs e)
       {                      
            Textkdn.TextDecorations = TextDecorations.Underline;
            Texterk.TextDecorations = TextDecorations.None;
            kadınurunleri.IsVisible = true;
            erkekurunleri.IsVisible = false;
        }
        private async void CarouselErkek(object sender, EventArgs e)
        {
            Textkdn.TextDecorations = TextDecorations.None;
            Texterk.TextDecorations = TextDecorations.Underline;
            kadınurunleri.IsVisible = false;
            erkekurunleri.IsVisible = true;
        }
     
    }
}