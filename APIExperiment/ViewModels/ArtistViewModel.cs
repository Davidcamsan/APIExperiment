using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;
using APIExperiment.Models;
using APIExperiment.Views;
using Realms;
using System.Runtime.CompilerServices;

using System.Collections.Generic;

namespace APIExperiment.ViewModels
{
	public class ArtistViewModel : INotifyPropertyChanged
	{
		#region Singleton 
		private static ArtistViewModel instance = null;

		public static ArtistViewModel GetInstance()
		{
			if (instance == null)
				instance = new ArtistViewModel();

			return instance;
		}


		public static void DeleteInstance()
		{
			if (instance != null)
				instance = null;
		}


		public ArtistViewModel()
		{
			InitClass();
			InitCommands();
		}
		#endregion SINGLETON



		#region INSTANCES FOR API
		//**** START OF INSTANCES FOR API SECTION
		private ObservableCollection<Artists> _lstArtist = new ObservableCollection<Artists>();

		public ObservableCollection<Artists> lstArtist
		{
			get
			{
				return _lstArtist;
			}

			set
			{
				_lstArtist = value;
				OnPropertyChanged("lstArtist");
			}
		}

		private ObservableCollection<ArtWorks> _CurrenArtistsWorks = new ObservableCollection<ArtWorks>();
		private ObservableCollection<ArtWorks> CurrenArtistsWorks
		{
			get
			{
				return _CurrenArtistsWorks;
			}
			set
			{
				_CurrenArtistsWorks = value;
				OnPropertyChanged("CurrentArtistsWorks");
			}
		}

		private Artists _CurrentArtist = new Artists();
		public Artists CurrentArtist
		{
			get
			{
				return _CurrentArtist;
			}
			set
			{
				_CurrentArtist = value;
				OnPropertyChanged("CurrentArtist");
			}
		}



		public HttpsStack ArtsyHttpStack = new HttpsStack();

		private bool isLoading = false;
		public bool IsLoading
		{
			get { return isLoading; }
			set
			{
				isLoading = value;
				OnPropertyChanged("IsLoading");
			}
		}

		private bool isEnabled = true;
		public bool IsEnabled
		{
			get { return isEnabled; }
			set
			{
				isEnabled = value;
				OnPropertyChanged("IsEnabled");
			}
		}

		private bool isTherePrevious = false;
		public bool IsTherePrevious
		{
			get { return isTherePrevious; }
			set
			{
				isTherePrevious = value;
				OnPropertyChanged("IsTherePrevious");
			}
		}

		//****** END OF INSTANCES FOR ARTIST API SECTION

		#endregion INSTANCES FOR API


		#region INSTANCES USER

		private UserModel _CurrentUser = new UserModel();

		public UserModel CurrentUser
		{
			get { return _CurrentUser; }

			set
			{
				_CurrentUser = value;
				OnPropertyChanged("CurrentUser");
			}
		}

		private ObservableCollection<UserModel> _lstUsers = new ObservableCollection<UserModel>();
		public ObservableCollection<UserModel> lstUsers
		{
			get { return _lstUsers; }

			set
			{
				_lstUsers = value;
				OnPropertyChanged("lstUsers");
			}
		}

        //Instances For LogIn
		public string Username { get; set; }
		public string password { get; set; }
        
		#endregion INSTANCES USER

		#region INSTANCES LEVELS, QUESTIONS, ANSWERS
        //LIST OF LEVELS
		private ObservableCollection<LevelModel> _lstLevels = new ObservableCollection<LevelModel>();
		public ObservableCollection<LevelModel> lstLevels 
		{
			get { return _lstLevels; }

			set
			{
				_lstLevels = value;
				OnPropertyChanged("lstLevels");
			}
			
		}

        //CHOSEN LEVEL
		private LevelModel _CurrentLevel = new LevelModel();
		public LevelModel CurrentLevel 
		{
			get { return _CurrentLevel; }

			set
			{
				_CurrentLevel = value;
				OnPropertyChanged("CurrentLevel");
			}
		}

		//QUESTIONS OF CHOSEN LEVEL
		private ObservableCollection<QuestionModel> _UnansweredQuestions = new ObservableCollection<QuestionModel>();
		public ObservableCollection<QuestionModel> UnansweredQuestions
		{
			get { return _UnansweredQuestions; }
			set
			{
				_UnansweredQuestions = value;
				OnPropertyChanged("UnansweredQuestions");
			}
		}

		private ObservableCollection<QuestionModel> _IncorrectlyAnsweredQuestions = new ObservableCollection<QuestionModel>();
        public ObservableCollection<QuestionModel> IncorrectlyAnsweredQuestions
        {
            get { return _IncorrectlyAnsweredQuestions; }
            set
            {
                _IncorrectlyAnsweredQuestions = value;
                OnPropertyChanged("IncorrectlyAnsweredQuestions");
            }
        }

		private QuestionModel _CurrentQuestion = new QuestionModel();
		public QuestionModel CurrentQuestion
		{
			get { return _CurrentQuestion; }
			set
			{
				_CurrentQuestion = value;
				OnPropertyChanged("CurrentQuestion");
			}
		}


		private ObservableCollection<AnswerOptionModel> _Answers = new ObservableCollection<AnswerOptionModel>();
		public ObservableCollection<AnswerOptionModel> Answers
		{
			get { return _Answers; }
			set
			{
				_Answers = value;
				OnPropertyChanged("Answers");
			}
		}

		private AnswerOptionModel _CurrentAnswer = new AnswerOptionModel();
		public AnswerOptionModel CurrentAnswer 
		{
			get { return _CurrentAnswer; }
            set 
			{
				_CurrentAnswer = value;
				OnPropertyChanged("CurrentAnswer");
			}
		}

		private AnswerOptionModel _CorrectAnswer = new AnswerOptionModel();
        public AnswerOptionModel CorrectAnswer
        {
            get { return _CorrectAnswer; }
            set
            {
                _CorrectAnswer = value;
                OnPropertyChanged("CorrectAnswer");
            }
        }

		private bool _IsCorrect { get; set; } = false;
		public bool IsCorrect
		{
			get { return _IsCorrect; }
			set
			{
				_IsCorrect = value;
				OnPropertyChanged("IsCorrect");
			}
		}

		private int _HowManyCorrect { get; set; } = 0;
		public int HowManyCorrect
		{
			get { return _HowManyCorrect; }
			set
			{
				_HowManyCorrect = value;
				OnPropertyChanged("HowManyCorrect");
			}
		}
        

		#endregion



		#region DATABASE COMMANDS

		Realm _getRealmInstance = Realm.GetInstance();

        //COMMANDS RELATING TO USER PROFILE
		public ICommand CreateUserCommand { get; set; }

		private void CreateUser()
		{
			CurrentUser.Level = 1;
			CurrentUser.ID = _getRealmInstance.All<UserModel>().Count() + 1;
			_getRealmInstance.Write(() =>
			{
				_getRealmInstance.Add(CurrentUser);
			});


			lstUsers = new ObservableCollection<UserModel>(_getRealmInstance.All<UserModel>().AsEnumerable());


		}
        

        //COMMANDS RELATING TO TRIVIA
		public ICommand TakeToTriviaQuestionCommand { get; set; }
		private void TakeToTriviaQuestion()
		{
			UnansweredQuestions = new ObservableCollection<QuestionModel>(CurrentLevel.QuestionSet);
			CurrentQuestion = UnansweredQuestions.First();
			Answers =new ObservableCollection<AnswerOptionModel>(CurrentQuestion.Answers);
			CorrectAnswer = Answers.Where(x => x.IsCorrect == true).ToList().First();
			HowManyCorrect = 0;

			App.Current.MainPage = new TriviaQuestionView();
		}


		public ICommand SelectAnswerCommand { get; set; }
		private void SelectAnswer(int id)
		{

			CurrentAnswer = Answers.Where(x => x.ID == id).First();
            
		}

		public ICommand SubmitAnswerCommand { get; set; }
		private void SubmitAnswer()
		{
			if (CorrectAnswer == CurrentAnswer)
				IsCorrect = true;
			else
				IsCorrect = false;


			App.Current.MainPage = new TriviaFeedbackView();
		}



		public ICommand NextQuestionCommand { get; set; }
		private void NextQuestion()
		{
			if (IsCorrect)
				HowManyCorrect++;

			UnansweredQuestions.Remove(CurrentQuestion);
			if (UnansweredQuestions.Count() > 0)
			{
				CurrentQuestion = UnansweredQuestions.First();
				Answers = new ObservableCollection<AnswerOptionModel>((CurrentQuestion.Answers).ToList());
				CorrectAnswer = Answers.Where(x => x.IsCorrect == true).ToList().First();

				App.Current.MainPage = new TriviaQuestionView();
			}
			else
				App.Current.MainPage = new GradeView();
		}


		#endregion 


        







		#region NAVIGATION COMMANDS
		public ICommand NextArtsyPageCommand { get; set; }

		private async void NextArtsyPage()
		{
			if (IsLoading)
				return;
			else
			{
				IsLoading = true;
				IsEnabled = false;
			}


			lstArtist = await ArtsyCallDocs.getArtistDocs(ArtsyHttpStack.root.NextHttps, ArtsyHttpStack);

			IsTherePrevious = ArtsyHttpStack.IsTherePreviousNode();
			IsLoading = false;
			IsEnabled = true;

		}


		public ICommand PreviousArtsyPageCommand { get; set; }

		private async void PreviousArtsyPage()
		{
			if (IsLoading)
				return;
			else
			{
				IsLoading = true;
				IsEnabled = false;
			}


			ArtsyHttpStack.Pop();
			lstArtist = await ArtsyCallDocs.getArtistDocs(ArtsyHttpStack.root.SelfHttps);

			IsTherePrevious = ArtsyHttpStack.IsTherePreviousNode();
			IsLoading = false;
			IsEnabled = true;

		}

		public ICommand SeeSpecificArtistCommand { get; set; }

		private async void SeeSpecificArtist(string id)
		{
			CurrentArtist = lstArtist.Where(x => x.id == id).FirstOrDefault();

			await App.Current.MainPage.Navigation.PushAsync(new IndividualArtistView());

		}

		public ICommand DirectToArtsyCommand { get; set; }

		private void DirectToArtsy()
		{
			Device.OpenUri(new Uri(CurrentArtist._links.permalink.href));
		}

        
		public ICommand GoToSignUpCommand { get; set; }

		private void GoToSignUp()
		{
			App.Current.MainPage.Navigation.PushAsync(new SignUpView());
		}

		public ICommand GoToLogInCommand { get; set; }

		private void GoToLogIn()
		{
			App.Current.MainPage.Navigation.PushAsync(new LogInView());
		}
        
		public ICommand GoToProfileCommand { get; set; }
        
        private void GoToProfile()
        {
			App.Current.MainPage.Navigation.PushAsync(new UserProfileView());
        }


		public ICommand VerifyUserCommand { get; set; }
        private void VerifyUser()
        {
			CurrentUser = lstUsers.Where(x => x.Email == Username && x.Password == password).FirstOrDefault();
			App.Current.MainPage = new UserProfileView();         
        }

		public ICommand GoToLevelsCommand { get; set; }
		private void GoToLevels()
		{
			App.Current.MainPage = new LevelsView();
		}


		#endregion NAVIGATION COMMANDS



		#region INITIALIZATION COMMANDS
		private void InitCommands()
		{

            //API SECTION COMMANDS
			NextArtsyPageCommand = new Command(NextArtsyPage);
			PreviousArtsyPageCommand = new Command(PreviousArtsyPage);
			SeeSpecificArtistCommand = new Command<string>(SeeSpecificArtist);
			DirectToArtsyCommand = new Command(DirectToArtsy);

            //WELCOME SECTION COMMANDS
			GoToSignUpCommand = new Command(GoToSignUp);
			GoToLogInCommand = new Command(GoToLogIn);
			CreateUserCommand = new Command(CreateUser);
			GoToProfileCommand = new Command(GoToProfile);
			VerifyUserCommand = new Command(VerifyUser);



			//GAME SECTION COMMANDS
			TakeToTriviaQuestionCommand = new Command(TakeToTriviaQuestion);
			SubmitAnswerCommand = new Command(SubmitAnswer);
			NextQuestionCommand = new Command(NextQuestion);
			SelectAnswerCommand = new Command<int>(SelectAnswer);
			GoToLevelsCommand = new Command(GoToLevels);

		}

		private async void InitClass()
		{
			lstArtist = await ArtsyCallDocs.getArtistDocs($"https://api.artsy.net/api/artists?offset=69&size=100", ArtsyHttpStack);
			lstUsers = new ObservableCollection<UserModel>(_getRealmInstance.All<UserModel>().ToList());
			if (_getRealmInstance.All<LevelModel>().Count() == 0)
				LevelModel.PopulateLevels(_getRealmInstance);
			lstLevels = new ObservableCollection<LevelModel>(_getRealmInstance.All<LevelModel>().AsEnumerable());

		}
		#endregion INITIALIZATION COMMANDS


		#region INotifyPropertyChange Interface

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
		#endregion

	}
}
