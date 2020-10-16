using System.ComponentModel;
using Xamarin.Forms;
using EnglishFlashCards.ViewModels;

namespace EnglishFlashCards.Views
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