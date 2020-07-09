﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StuHubPartnerShip
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void SignIn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());
        }
        async void FB_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new FB());
        }
        
    }
}