using System;
using System.Collections.Generic;
using EnglishFlashCards.ViewModels;
using EnglishFlashCards.Views;
using Xamarin.Forms;

namespace EnglishFlashCards
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
