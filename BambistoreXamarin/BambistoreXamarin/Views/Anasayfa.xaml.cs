using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
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
        }
    }
}