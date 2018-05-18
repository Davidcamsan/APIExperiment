using System;
using System.Collections.Generic;
using APIExperiment.ViewModels;

using Xamarin.Forms;

namespace APIExperiment.Views
{
    public partial class WelcomeView : ContentPage
    {
        public WelcomeView()
        {
            InitializeComponent();
            BindingContext = ArtistViewModel.GetInstance();
        }
    }
}
