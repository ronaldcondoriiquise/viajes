﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace traveling1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        private void Registrarse_Clicked(object sender, EventArgs e)
        {

            Navigation.PushModalAsync(new MainPage());

        }
        private void iniciar_sesion_Clicked(object sender, EventArgs e)
        {

            Navigation.PushModalAsync(new MainPage());

        }
    }
}