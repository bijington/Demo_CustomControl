using Demo_CustomControl.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Demo_CustomControl.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}