using System;
using Realms;
namespace APIExperiment.Models
{
	public class AnswerOptionModel : RealmObject
    {
        public AnswerOptionModel()
        {
        }

		public int ID { get; set; }
		public string Answer { get; set; }
		public bool IsSelected { get; set; }
		public bool IsCorrect { get; set; }


    }
}
