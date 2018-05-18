using System;
using System.Collections.Generic;
using APIExperiment.Models;
using APIExperiment.ViewModels;

using Xamarin.Forms;

namespace APIExperiment.Views
{
    public partial class IndividualArtistView : ContentPage
    {
        public IndividualArtistView()
        {
            InitializeComponent();
            BindingContext = ArtistViewModel.GetInstance();
        }
    }
}
