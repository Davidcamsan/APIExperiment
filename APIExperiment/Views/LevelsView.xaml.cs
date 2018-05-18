using System;
using APIExperiment.ViewModels;
using System.Collections.Generic;

using Xamarin.Forms;

namespace APIExperiment.Views
{
    public partial class LevelsView : ContentPage
    {
        public LevelsView()
        {
            InitializeComponent();
			BindingContext = ArtistViewModel.GetInstance();
        }
    }
}
