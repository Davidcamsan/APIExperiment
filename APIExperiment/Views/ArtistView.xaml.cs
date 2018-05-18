using System;
using System.Collections.Generic;
using APIExperiment.Models;
using APIExperiment.ViewModels;

using Xamarin.Forms;

namespace APIExperiment.Views
{
    public partial class ArtistView : ContentPage
    {
        public ArtistView()
        {
            
            InitializeComponent();
            BindingContext = ArtistViewModel.GetInstance();

        }
    }
}
