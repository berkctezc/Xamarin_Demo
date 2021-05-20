using System.ComponentModel;
using Xamarin.Forms;
using Xamarin_Demo.ViewModels;

namespace Xamarin_Demo.Views
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