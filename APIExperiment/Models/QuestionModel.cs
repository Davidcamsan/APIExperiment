using System;
using Realms;
using System.Collections.Generic;
namespace APIExperiment.Models
{
	public class QuestionModel : RealmObject
    {
        public QuestionModel()
        {
        }

		public int ID { get; set; }
		public string Image { get; set; }
		public string Question { get; set; }
		public bool IsAnswered { get; set; }
		public IList<AnswerOptionModel> Answers { get; }
    }
}
