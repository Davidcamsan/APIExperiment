using System;
using System.Collections.Generic;
using APIExperiment.ViewModels;

using Xamarin.Forms;

namespace APIExperiment.Views
{
    public partial class SignUpView : ContentPage
    {
        public SignUpView()
        {
            InitializeComponent();
			BindingContext = ArtistViewModel.GetInstance();
        }
    }
}
