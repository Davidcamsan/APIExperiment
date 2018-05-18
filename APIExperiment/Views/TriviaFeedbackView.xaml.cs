using System;
using System.Collections.Generic;
using APIExperiment.ViewModels;

using Xamarin.Forms;

namespace APIExperiment.Views
{
    public partial class TriviaFeedbackView : ContentPage
    {
        public TriviaFeedbackView()
        {
            InitializeComponent();
			BindingContext = ArtistViewModel.GetInstance();
        }
    }
}
