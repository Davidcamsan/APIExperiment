using System;
using APIExperiment.ViewModels;
using System.Collections.Generic;

using Xamarin.Forms;

namespace APIExperiment.Views
{
    public partial class TriviaQuestionView : ContentPage
    {
        public TriviaQuestionView()
        {
            InitializeComponent();
			BindingContext = ArtistViewModel.GetInstance();
        }
    }
}
