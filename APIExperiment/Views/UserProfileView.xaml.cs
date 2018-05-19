using System;
using System.Collections.Generic;
using APIExperiment.ViewModels;
using APIExperiment.Models;

using Xamarin.Forms;

namespace APIExperiment.Views
{
    public partial class UserProfileView : ContentPage
    {
		
        public UserProfileView()
        {
            InitializeComponent();
			BindingContext = ArtistViewModel.GetInstance();
        }

    }
}
