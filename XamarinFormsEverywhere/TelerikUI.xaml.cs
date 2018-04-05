using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsEverywhere
{
    public partial class TelerikUI : ContentPage
    {
        public TelerikUI()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Alert", "You have been alerted", "OK");
        }
    }
}
