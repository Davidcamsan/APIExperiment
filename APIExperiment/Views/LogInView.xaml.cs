using System;
using System.Collections.Generic;
using APIExperiment.ViewModels;

using Xamarin.Forms;

namespace APIExperiment.Views
{
    public partial class LogInView : ContentPage
    {
        public LogInView()
        {
            InitializeComponent();
			BindingContext = ArtistViewModel.GetInstance();
        }
    }
}
