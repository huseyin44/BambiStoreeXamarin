using Android.Opengl;
using Android.OS;
using Android.Provider;
using BambistoreXamarin.ViewModels;
using ImageCircle.Forms.Plugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace BambistoreXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Anasayfa : ContentPage
    {
        public Anasayfa()
        {
            InitializeComponent();          
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
        private void ListViewItem_Tabbed(object sender, ItemTappedEventArgs e)
        {
            var product = e.Item as Product;
            var vm = BindingContext as MainListView;
            vm?.ShoworHiddenProducts(product);
        }
    }
}