﻿using JhonnyGuilcapiexamen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JhonnyGuilcapi_examen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
                await Navigation.PushAsync(new Vista_dos(user,pass));

        }
    }
}
