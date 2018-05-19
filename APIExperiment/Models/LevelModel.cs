using System;
using Realms;
using System.Collections.Generic;
using System.Linq;

namespace APIExperiment.Models
{
	public class LevelModel : RealmObject
	{
		public LevelModel()
		{
		}

		[PrimaryKey]
		public int ID { get; set; }
		public IList<QuestionModel> QuestionSet { get; }


		public static void PopulateLevels(Realm realm)
		{
			//LEVEL 1
			QuestionModel QuestionL1_Q1 = new QuestionModel { ID = 1, Question="Where was Pablo Picasso From?", Image="Lev1Q1"};
			AnswerOptionModel Answer1_Q1_L1 = new AnswerOptionModel{ ID = 1, Answer = "Portugal", IsCorrect = false };
			AnswerOptionModel Answer2_Q1_L1 = new AnswerOptionModel { ID = 2, Answer = "Spain", IsCorrect = true };
			AnswerOptionModel Answer3_Q1_L1 = new AnswerOptionModel { ID = 3, Answer = "Mexico", IsCorrect = false };
			AnswerOptionModel Answer4_Q1_L1 = new AnswerOptionModel { ID = 4, Answer = "Italy", IsCorrect = false };
			QuestionL1_Q1.Answers.Add(Answer1_Q1_L1);
			QuestionL1_Q1.Answers.Add(Answer2_Q1_L1);
			QuestionL1_Q1.Answers.Add(Answer3_Q1_L1);
			QuestionL1_Q1.Answers.Add(Answer4_Q1_L1);
            

			QuestionModel QuestionL1_Q2 = new QuestionModel { ID = 2, Question = "Which of the following is true about the artistic movement known as Modernism?", Image="L1Q2"};
            AnswerOptionModel Answer1_Q2_L1 = new AnswerOptionModel { ID = 1, Answer = "Its effect was limited to Europe and the United States", IsCorrect = false };
            AnswerOptionModel Answer2_Q2_L1 = new AnswerOptionModel { ID = 2, Answer = "Dutch Artist Vincent Van Gogh was its leader", IsCorrect = false };
            AnswerOptionModel Answer3_Q2_L1 = new AnswerOptionModel { ID = 3, Answer = "The Nazi movement felt threatened by its ideals", IsCorrect = true };
            AnswerOptionModel Answer4_Q2_L1 = new AnswerOptionModel { ID = 4, Answer = "Italy was its biggest proponent", IsCorrect = false };
			QuestionL1_Q2.Answers.Add(Answer1_Q2_L1);
			QuestionL1_Q2.Answers.Add(Answer2_Q2_L1);
			QuestionL1_Q2.Answers.Add(Answer3_Q2_L1);
			QuestionL1_Q2.Answers.Add(Answer4_Q2_L1);
         

			QuestionModel QuestionL1_Q3 = new QuestionModel { ID = 3, Question = "What is Guerrilla Girlz?", Image="L1Q3"};
            AnswerOptionModel Answer1_Q3_L1 = new AnswerOptionModel { ID = 1, Answer = "A British work of Art from the modernist period", IsCorrect = false };
            AnswerOptionModel Answer2_Q3_L1 = new AnswerOptionModel { ID = 2, Answer = "Gaugin's nickname for Polynesian women", IsCorrect = false };
            AnswerOptionModel Answer3_Q3_L1 = new AnswerOptionModel { ID = 3, Answer = "A Feminist congregation of artists that use art to denounce the patriachy", IsCorrect = true };
            AnswerOptionModel Answer4_Q3_L1 = new AnswerOptionModel { ID = 4, Answer = "A Collection of works by female artists", IsCorrect = false };
            QuestionL1_Q3.Answers.Add(Answer1_Q3_L1);
            QuestionL1_Q3.Answers.Add(Answer2_Q3_L1);
            QuestionL1_Q3.Answers.Add(Answer3_Q3_L1);
            QuestionL1_Q3.Answers.Add(Answer4_Q3_L1);

			QuestionModel QuestionL1_Q4 = new QuestionModel { ID = 4, Question = "Which of the following artists belonged to the Negritude movement?", Image="L1Q4"};
            AnswerOptionModel Answer1_Q4_L1 = new AnswerOptionModel { ID = 1, Answer = "Wassily Kandinsky", IsCorrect = false };
            AnswerOptionModel Answer2_Q4_L1 = new AnswerOptionModel { ID = 2, Answer = "Wifredo Lam", IsCorrect = true };
            AnswerOptionModel Answer3_Q4_L1 = new AnswerOptionModel { ID = 3, Answer = "Frida Kahlo", IsCorrect = false };
            AnswerOptionModel Answer4_Q4_L1 = new AnswerOptionModel { ID = 4, Answer = "Gabriele Munter", IsCorrect = false };
			QuestionL1_Q4.Answers.Add(Answer1_Q4_L1);
			QuestionL1_Q4.Answers.Add(Answer2_Q4_L1);
			QuestionL1_Q4.Answers.Add(Answer3_Q4_L1);
			QuestionL1_Q4.Answers.Add(Answer4_Q4_L1);

			QuestionModel QuestionL1_Q5 = new QuestionModel { ID = 5, Question = "What were the main materials utilized in Costa Rican Indigenous Art?"};
            AnswerOptionModel Answer1_Q5_L1 = new AnswerOptionModel { ID = 1, Answer = "Jade and Stone", IsCorrect = false };
            AnswerOptionModel Answer2_Q5_L1 = new AnswerOptionModel { ID = 2, Answer = "Gold and Stone", IsCorrect = false };
            AnswerOptionModel Answer3_Q5_L1 = new AnswerOptionModel { ID = 3, Answer = "Emerald and Gold", IsCorrect = false };
            AnswerOptionModel Answer4_Q5_L1 = new AnswerOptionModel { ID = 4, Answer = "Jade and Gold", IsCorrect = true };
			QuestionL1_Q5.Answers.Add(Answer1_Q5_L1);
			QuestionL1_Q5.Answers.Add(Answer2_Q5_L1);
			QuestionL1_Q5.Answers.Add(Answer3_Q5_L1);
			QuestionL1_Q5.Answers.Add(Answer4_Q5_L1);


			QuestionModel QuestionL1_Q6 = new QuestionModel { ID = 6, Question = "Where was Albrecht Durer from and what medium is he best known for?"};
            AnswerOptionModel Answer1_Q6_L1 = new AnswerOptionModel { ID = 1, Answer = "The Netherlands and Drawing", IsCorrect = false };
            AnswerOptionModel Answer2_Q6_L1 = new AnswerOptionModel { ID = 2, Answer = "Belgium and Painting", IsCorrect = false };
            AnswerOptionModel Answer3_Q6_L1 = new AnswerOptionModel { ID = 3, Answer = "Germany and Engraving", IsCorrect = true };
            AnswerOptionModel Answer4_Q6_L1 = new AnswerOptionModel { ID = 4, Answer = "The Netherlands and Sculpture", IsCorrect = false };
			QuestionL1_Q6.Answers.Add(Answer1_Q6_L1);
			QuestionL1_Q6.Answers.Add(Answer2_Q6_L1);
			QuestionL1_Q6.Answers.Add(Answer3_Q6_L1);
			QuestionL1_Q6.Answers.Add(Answer4_Q6_L1);

            
			QuestionModel QuestionL1_Q7 = new QuestionModel { ID = 7, Question = "When was Costa Rican Artist Francisco Amighetti born?" };
            AnswerOptionModel Answer1_Q7_L1 = new AnswerOptionModel { ID = 1, Answer = "1907", IsCorrect = true };
            AnswerOptionModel Answer2_Q7_L1 = new AnswerOptionModel { ID = 2, Answer = "1922", IsCorrect = false };
            AnswerOptionModel Answer3_Q7_L1 = new AnswerOptionModel { ID = 3, Answer = "1888", IsCorrect = false };
            AnswerOptionModel Answer4_Q7_L1 = new AnswerOptionModel { ID = 4, Answer = "1934", IsCorrect = false };
			QuestionL1_Q7.Answers.Add(Answer1_Q7_L1);
			QuestionL1_Q7.Answers.Add(Answer2_Q7_L1);
			QuestionL1_Q7.Answers.Add(Answer3_Q7_L1);
			QuestionL1_Q7.Answers.Add(Answer4_Q7_L1);


			QuestionModel QuestionL1_Q8 = new QuestionModel { ID = 8, Question = "What does the term Chiaroscuro refer to?"};
            AnswerOptionModel Answer1_Q8_L1 = new AnswerOptionModel { ID = 1, Answer = "The use of bright and dark tones in a photograph", IsCorrect = false };
            AnswerOptionModel Answer2_Q8_L1 = new AnswerOptionModel { ID = 2, Answer = "The sharp contrast between light and shadows in paintings", IsCorrect = true };
            AnswerOptionModel Answer3_Q8_L1 = new AnswerOptionModel { ID = 3, Answer = "The sharp edges of marble sculptures in the renaissance", IsCorrect = false };
            AnswerOptionModel Answer4_Q8_L1 = new AnswerOptionModel { ID = 4, Answer = "The use of contrasting drawing techniques", IsCorrect = false };
			QuestionL1_Q8.Answers.Add(Answer1_Q8_L1);
			QuestionL1_Q8.Answers.Add(Answer2_Q8_L1);
			QuestionL1_Q8.Answers.Add(Answer3_Q8_L1);
			QuestionL1_Q8.Answers.Add(Answer4_Q8_L1);



			QuestionModel QuestionL1_Q9 = new QuestionModel { ID = 9, Question = "What did Contemporaries think of Gothic Architecture?" };
            AnswerOptionModel Answer1_Q9_L1 = new AnswerOptionModel { ID = 1, Answer = "It was an expression of modernity", IsCorrect = true };
            AnswerOptionModel Answer2_Q9_L1 = new AnswerOptionModel { ID = 2, Answer = "It seemed a bit outdated", IsCorrect = false };
            AnswerOptionModel Answer3_Q9_L1 = new AnswerOptionModel { ID = 3, Answer = "It was too sombre and cold", IsCorrect = false };
            AnswerOptionModel Answer4_Q9_L1 = new AnswerOptionModel { ID = 4, Answer = "It was a necessity", IsCorrect = false };
			QuestionL1_Q9.Answers.Add(Answer1_Q9_L1);
			QuestionL1_Q9.Answers.Add(Answer2_Q9_L1);
			QuestionL1_Q9.Answers.Add(Answer3_Q9_L1);
			QuestionL1_Q9.Answers.Add(Answer4_Q9_L1);


			QuestionModel QuestionL1_Q10 = new QuestionModel { ID = 10, Question = "Which of the following is a characteristic of Surrealism?" };
			AnswerOptionModel Answer1_Q10_L1 = new AnswerOptionModel { ID = 1, Answer = "The study of the subconscious and the fantastic", IsCorrect = true };
            AnswerOptionModel Answer2_Q10_L1 = new AnswerOptionModel { ID = 2, Answer = "The repression of desires", IsCorrect = false };
			AnswerOptionModel Answer3_Q10_L1 = new AnswerOptionModel { ID = 3, Answer = "The faithful representation of reality", IsCorrect = false };
            AnswerOptionModel Answer4_Q10_L1 = new AnswerOptionModel { ID = 4, Answer = "The idea of conformity", IsCorrect = false };
			QuestionL1_Q10.Answers.Add(Answer1_Q10_L1);
			QuestionL1_Q10.Answers.Add(Answer2_Q10_L1);
			QuestionL1_Q10.Answers.Add(Answer3_Q10_L1);
			QuestionL1_Q10.Answers.Add(Answer4_Q10_L1);
            

			LevelModel Level_1 = new LevelModel();
			Level_1.QuestionSet.Add(QuestionL1_Q1);
			Level_1.QuestionSet.Add(QuestionL1_Q2);
			Level_1.QuestionSet.Add(QuestionL1_Q3);
			Level_1.QuestionSet.Add(QuestionL1_Q4);
			Level_1.QuestionSet.Add(QuestionL1_Q5);
			Level_1.QuestionSet.Add(QuestionL1_Q6);
			Level_1.QuestionSet.Add(QuestionL1_Q7);
			Level_1.QuestionSet.Add(QuestionL1_Q8);
			Level_1.QuestionSet.Add(QuestionL1_Q9);
			Level_1.QuestionSet.Add(QuestionL1_Q10);






            //LEVEL 2
			QuestionModel QuestionL2_Q1 = new QuestionModel { ID = 1, Question = "QUESTION 1, LEVEL2" };
            AnswerOptionModel Answer1_Q1_L2 = new AnswerOptionModel { ID = 1, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer2_Q1_L2 = new AnswerOptionModel { ID = 2, Answer = "true", IsCorrect = true };
            AnswerOptionModel Answer3_Q1_L2 = new AnswerOptionModel { ID = 3, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer4_Q1_L2 = new AnswerOptionModel { ID = 4, Answer = "false", IsCorrect = false };
			QuestionL2_Q1.Answers.Add(Answer1_Q1_L2);
			QuestionL2_Q1.Answers.Add(Answer2_Q1_L2);
			QuestionL2_Q1.Answers.Add(Answer3_Q1_L2);
			QuestionL2_Q1.Answers.Add(Answer4_Q1_L2);


			QuestionModel QuestionL2_Q2 = new QuestionModel { ID = 2, Question = "QUESTION 2, LEVEL2" };
            AnswerOptionModel Answer1_Q2_L2 = new AnswerOptionModel { ID = 1, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer2_Q2_L2 = new AnswerOptionModel { ID = 2, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer3_Q2_L2 = new AnswerOptionModel { ID = 3, Answer = "true", IsCorrect = true };
            AnswerOptionModel Answer4_Q2_L2 = new AnswerOptionModel { ID = 4, Answer = "false", IsCorrect = false };
			QuestionL2_Q2.Answers.Add(Answer1_Q2_L2);
            QuestionL2_Q2.Answers.Add(Answer2_Q2_L2);
            QuestionL2_Q2.Answers.Add(Answer3_Q2_L2);
            QuestionL2_Q2.Answers.Add(Answer4_Q2_L2);
            
            
			QuestionModel QuestionL2_Q3 = new QuestionModel { ID = 3, Question = "QUESTION 3, LEVEL2"};
            AnswerOptionModel Answer1_Q3_L2 = new AnswerOptionModel { ID = 1, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer2_Q3_L2 = new AnswerOptionModel { ID = 2, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer3_Q3_L2 = new AnswerOptionModel { ID = 3, Answer = "true", IsCorrect = true };
            AnswerOptionModel Answer4_Q3_L2 = new AnswerOptionModel { ID = 4, Answer = "false", IsCorrect = false };
            QuestionL2_Q3.Answers.Add(Answer1_Q3_L2);
            QuestionL2_Q3.Answers.Add(Answer2_Q3_L2);
            QuestionL2_Q3.Answers.Add(Answer3_Q3_L2);
            QuestionL2_Q3.Answers.Add(Answer4_Q3_L2);
            
			QuestionModel QuestionL2_Q4 = new QuestionModel { ID = 4, Question = "QUESTION 4, LEVEL2" };
            AnswerOptionModel Answer1_Q4_L2 = new AnswerOptionModel { ID = 1, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer2_Q4_L2 = new AnswerOptionModel { ID = 2, Answer = "true", IsCorrect = true };
            AnswerOptionModel Answer3_Q4_L2 = new AnswerOptionModel { ID = 3, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer4_Q4_L2 = new AnswerOptionModel { ID = 4, Answer = "false", IsCorrect = false };
            QuestionL2_Q4.Answers.Add(Answer1_Q4_L2);
			QuestionL2_Q4.Answers.Add(Answer2_Q4_L2);
            QuestionL2_Q4.Answers.Add(Answer3_Q4_L2);
            QuestionL2_Q4.Answers.Add(Answer4_Q4_L2);
            
			QuestionModel QuestionL2_Q5 = new QuestionModel { ID = 5, Question = "QUESTION 5, LEVEL2" };
            AnswerOptionModel Answer1_Q5_L2 = new AnswerOptionModel { ID = 1, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer2_Q5_L2 = new AnswerOptionModel { ID = 2, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer3_Q5_L2 = new AnswerOptionModel { ID = 3, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer4_Q5_L2 = new AnswerOptionModel { ID = 4, Answer = "true", IsCorrect = true };
            QuestionL2_Q5.Answers.Add(Answer1_Q5_L2);
            QuestionL2_Q5.Answers.Add(Answer2_Q5_L2);
            QuestionL2_Q5.Answers.Add(Answer3_Q5_L2);
            QuestionL2_Q5.Answers.Add(Answer4_Q5_L2);


			QuestionModel QuestionL2_Q6 = new QuestionModel { ID = 6, Question = "QUESTION 6, LEVEL2" };
            AnswerOptionModel Answer1_Q6_L2 = new AnswerOptionModel { ID = 1, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer2_Q6_L2 = new AnswerOptionModel { ID = 2, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer3_Q6_L2 = new AnswerOptionModel { ID = 3, Answer = "true", IsCorrect = true };
            AnswerOptionModel Answer4_Q6_L2 = new AnswerOptionModel { ID = 4, Answer = "false", IsCorrect = false };
            QuestionL2_Q6.Answers.Add(Answer1_Q6_L2);
            QuestionL2_Q6.Answers.Add(Answer2_Q6_L2);
            QuestionL2_Q6.Answers.Add(Answer3_Q6_L2);
            QuestionL2_Q6.Answers.Add(Answer4_Q6_L2);
            

			QuestionModel QuestionL2_Q7 = new QuestionModel { ID = 7, Question = "QUESTION 7, LEVEL2" };
            AnswerOptionModel Answer1_Q7_L2 = new AnswerOptionModel { ID = 1, Answer = "true", IsCorrect = true };
            AnswerOptionModel Answer2_Q7_L2 = new AnswerOptionModel { ID = 2, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer3_Q7_L2 = new AnswerOptionModel { ID = 3, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer4_Q7_L2 = new AnswerOptionModel { ID = 4, Answer = "false", IsCorrect = false };
            QuestionL2_Q7.Answers.Add(Answer1_Q7_L2);
            QuestionL2_Q7.Answers.Add(Answer2_Q7_L2);
            QuestionL2_Q7.Answers.Add(Answer3_Q7_L2);
            QuestionL2_Q7.Answers.Add(Answer4_Q7_L2);

            
			QuestionModel QuestionL2_Q8 = new QuestionModel { ID = 8, Question = "QUESTION 8, LEVEL2"};
            AnswerOptionModel Answer1_Q8_L2 = new AnswerOptionModel { ID = 1, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer2_Q8_L2 = new AnswerOptionModel { ID = 2, Answer = "True", IsCorrect = true };
            AnswerOptionModel Answer3_Q8_L2 = new AnswerOptionModel { ID = 3, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer4_Q8_L2 = new AnswerOptionModel { ID = 4, Answer = "false", IsCorrect = false };
            QuestionL2_Q8.Answers.Add(Answer1_Q8_L2);
            QuestionL2_Q8.Answers.Add(Answer2_Q8_L2);
            QuestionL2_Q8.Answers.Add(Answer3_Q8_L2);
            QuestionL2_Q8.Answers.Add(Answer4_Q8_L2);
            

            
			QuestionModel QuestionL2_Q9 = new QuestionModel { ID = 9, Question = "QUESTION 9, LEVEL2" };
            AnswerOptionModel Answer1_Q9_L2 = new AnswerOptionModel { ID = 1, Answer = "true", IsCorrect = true };
            AnswerOptionModel Answer2_Q9_L2 = new AnswerOptionModel { ID = 2, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer3_Q9_L2 = new AnswerOptionModel { ID = 3, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer4_Q9_L2 = new AnswerOptionModel { ID = 4, Answer = "false", IsCorrect = false };
            QuestionL2_Q9.Answers.Add(Answer1_Q9_L2);
            QuestionL2_Q9.Answers.Add(Answer2_Q9_L2);
            QuestionL2_Q9.Answers.Add(Answer3_Q9_L2);
            QuestionL2_Q9.Answers.Add(Answer4_Q9_L2);
            
            
			QuestionModel QuestionL2_Q10 = new QuestionModel { ID = 10, Question = "QUESTION 10, LEVEL2" };
            AnswerOptionModel Answer1_Q10_L2 = new AnswerOptionModel { ID = 1, Answer = "True", IsCorrect = true };
            AnswerOptionModel Answer2_Q10_L2 = new AnswerOptionModel { ID = 2, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer3_Q10_L2 = new AnswerOptionModel { ID = 3, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer4_Q10_L2 = new AnswerOptionModel { ID = 4, Answer = "false", IsCorrect = false };
            QuestionL2_Q10.Answers.Add(Answer1_Q10_L2);
            QuestionL2_Q10.Answers.Add(Answer2_Q10_L2);
            QuestionL2_Q10.Answers.Add(Answer3_Q10_L2);
            QuestionL2_Q10.Answers.Add(Answer4_Q10_L2);

            
            LevelModel Level_2 = new LevelModel();
			Level_2.QuestionSet.Add(QuestionL2_Q1);
			Level_2.QuestionSet.Add(QuestionL2_Q2);
			Level_2.QuestionSet.Add(QuestionL2_Q3);
			Level_2.QuestionSet.Add(QuestionL2_Q4);
			Level_2.QuestionSet.Add(QuestionL2_Q5);
			Level_2.QuestionSet.Add(QuestionL2_Q6);
			Level_2.QuestionSet.Add(QuestionL2_Q7);
			Level_2.QuestionSet.Add(QuestionL2_Q8);
			Level_2.QuestionSet.Add(QuestionL2_Q9);
			Level_2.QuestionSet.Add(QuestionL2_Q10);




            //LEVEL 3
            QuestionModel QuestionL3_Q1 = new QuestionModel { ID = 1, Question = "QUESTION 1, LEVEL3"};
            AnswerOptionModel Answer1_Q1_L3 = new AnswerOptionModel { ID = 1, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer2_Q1_L3 = new AnswerOptionModel { ID = 2, Answer = "true", IsCorrect = true };
            AnswerOptionModel Answer3_Q1_L3 = new AnswerOptionModel { ID = 3, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer4_Q1_L3 = new AnswerOptionModel { ID = 4, Answer = "false", IsCorrect = false };
            QuestionL3_Q1.Answers.Add(Answer1_Q1_L3);
            QuestionL3_Q1.Answers.Add(Answer2_Q1_L3);
            QuestionL3_Q1.Answers.Add(Answer3_Q1_L3);
            QuestionL3_Q1.Answers.Add(Answer4_Q1_L3);


            QuestionModel QuestionL3_Q2 = new QuestionModel { ID = 2, Question = "QUESTION 2, LEVEL3"};
            AnswerOptionModel Answer1_Q2_L3 = new AnswerOptionModel { ID = 1, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer2_Q2_L3 = new AnswerOptionModel { ID = 2, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer3_Q2_L3 = new AnswerOptionModel { ID = 3, Answer = "true", IsCorrect = true };
            AnswerOptionModel Answer4_Q2_L3 = new AnswerOptionModel { ID = 4, Answer = "false", IsCorrect = false };
            QuestionL3_Q2.Answers.Add(Answer1_Q2_L3);
            QuestionL3_Q2.Answers.Add(Answer2_Q2_L3);
            QuestionL3_Q2.Answers.Add(Answer3_Q2_L3);
            QuestionL3_Q2.Answers.Add(Answer4_Q2_L3);
            

            QuestionModel QuestionL3_Q3 = new QuestionModel { ID = 3, Question = "QUESTION 3, LEVEL3" };
            AnswerOptionModel Answer1_Q3_L3 = new AnswerOptionModel { ID = 1, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer2_Q3_L3 = new AnswerOptionModel { ID = 2, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer3_Q3_L3 = new AnswerOptionModel { ID = 3, Answer = "true", IsCorrect = true };
            AnswerOptionModel Answer4_Q3_L3 = new AnswerOptionModel { ID = 4, Answer = "false", IsCorrect = false };
			QuestionL3_Q3.Answers.Add(Answer1_Q3_L3);
            QuestionL3_Q3.Answers.Add(Answer2_Q3_L3);
            QuestionL3_Q3.Answers.Add(Answer3_Q3_L3);
            QuestionL3_Q3.Answers.Add(Answer4_Q3_L3);
            
            QuestionModel QuestionL3_Q4 = new QuestionModel { ID = 4, Question = "QUESTION 4, LEVEL3" };
            AnswerOptionModel Answer1_Q4_L3 = new AnswerOptionModel { ID = 1, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer2_Q4_L3 = new AnswerOptionModel { ID = 2, Answer = "true", IsCorrect = true };
            AnswerOptionModel Answer3_Q4_L3 = new AnswerOptionModel { ID = 3, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer4_Q4_L3 = new AnswerOptionModel { ID = 4, Answer = "false", IsCorrect = false };
            QuestionL3_Q4.Answers.Add(Answer1_Q4_L3);
            QuestionL3_Q4.Answers.Add(Answer2_Q4_L3);
            QuestionL3_Q4.Answers.Add(Answer3_Q4_L3);
            QuestionL3_Q4.Answers.Add(Answer4_Q4_L3);

            QuestionModel QuestionL3_Q5 = new QuestionModel { ID = 5, Question = "QUESTION 5, LEVEL3" };
            AnswerOptionModel Answer1_Q5_L3 = new AnswerOptionModel { ID = 1, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer2_Q5_L3 = new AnswerOptionModel { ID = 2, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer3_Q5_L3 = new AnswerOptionModel { ID = 3, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer4_Q5_L3 = new AnswerOptionModel { ID = 4, Answer = "true", IsCorrect = true };
            QuestionL3_Q5.Answers.Add(Answer1_Q5_L3);
            QuestionL3_Q5.Answers.Add(Answer2_Q5_L3);
            QuestionL3_Q5.Answers.Add(Answer3_Q5_L3);
            QuestionL3_Q5.Answers.Add(Answer4_Q5_L3);
            

            QuestionModel QuestionL3_Q6 = new QuestionModel { ID = 6, Question = "QUESTION 6, LEVEL3" };
            AnswerOptionModel Answer1_Q6_L3 = new AnswerOptionModel { ID = 1, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer2_Q6_L3 = new AnswerOptionModel { ID = 2, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer3_Q6_L3 = new AnswerOptionModel { ID = 3, Answer = "true", IsCorrect = true };
            AnswerOptionModel Answer4_Q6_L3 = new AnswerOptionModel { ID = 4, Answer = "false", IsCorrect = false };
            QuestionL3_Q6.Answers.Add(Answer1_Q6_L3);
            QuestionL3_Q6.Answers.Add(Answer2_Q6_L3);
            QuestionL3_Q6.Answers.Add(Answer3_Q6_L3);
            QuestionL3_Q6.Answers.Add(Answer4_Q6_L3);
            

            QuestionModel QuestionL3_Q7 = new QuestionModel { ID = 7, Question = "QUESTION 7, LEVEL3" };
            AnswerOptionModel Answer1_Q7_L3 = new AnswerOptionModel { ID = 1, Answer = "true", IsCorrect = true };
            AnswerOptionModel Answer2_Q7_L3 = new AnswerOptionModel { ID = 2, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer3_Q7_L3 = new AnswerOptionModel { ID = 3, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer4_Q7_L3 = new AnswerOptionModel { ID = 4, Answer = "false", IsCorrect = false };
            QuestionL3_Q7.Answers.Add(Answer1_Q7_L3);
            QuestionL3_Q7.Answers.Add(Answer2_Q7_L3);
            QuestionL3_Q7.Answers.Add(Answer3_Q7_L3);
            QuestionL3_Q7.Answers.Add(Answer4_Q7_L3);


            QuestionModel QuestionL3_Q8 = new QuestionModel { ID = 8, Question = "QUESTION 8, LEVEL3" };
            AnswerOptionModel Answer1_Q8_L3 = new AnswerOptionModel { ID = 1, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer2_Q8_L3 = new AnswerOptionModel { ID = 2, Answer = "True", IsCorrect = true };
            AnswerOptionModel Answer3_Q8_L3 = new AnswerOptionModel { ID = 3, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer4_Q8_L3 = new AnswerOptionModel { ID = 4, Answer = "false", IsCorrect = false };
            QuestionL3_Q8.Answers.Add(Answer1_Q8_L3);
            QuestionL3_Q8.Answers.Add(Answer2_Q8_L3);
            QuestionL3_Q8.Answers.Add(Answer3_Q8_L3);
            QuestionL3_Q8.Answers.Add(Answer4_Q8_L3);
            


            QuestionModel QuestionL3_Q9 = new QuestionModel { ID = 9, Question = "QUESTION 9, LEVEL3" };
            AnswerOptionModel Answer1_Q9_L3 = new AnswerOptionModel { ID = 1, Answer = "true", IsCorrect = true };
            AnswerOptionModel Answer2_Q9_L3 = new AnswerOptionModel { ID = 2, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer3_Q9_L3 = new AnswerOptionModel { ID = 3, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer4_Q9_L3 = new AnswerOptionModel { ID = 4, Answer = "false", IsCorrect = false };
            QuestionL3_Q9.Answers.Add(Answer1_Q9_L3);
            QuestionL3_Q9.Answers.Add(Answer2_Q9_L3);
            QuestionL3_Q9.Answers.Add(Answer3_Q9_L3);
            QuestionL3_Q9.Answers.Add(Answer4_Q9_L3);
            

            QuestionModel QuestionL3_Q10 = new QuestionModel { ID = 10, Question = "QUESTION 10, LEVEL3" };
            AnswerOptionModel Answer1_Q10_L3 = new AnswerOptionModel { ID = 1, Answer = "True", IsCorrect = true };
            AnswerOptionModel Answer2_Q10_L3 = new AnswerOptionModel { ID = 2, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer3_Q10_L3 = new AnswerOptionModel { ID = 3, Answer = "false", IsCorrect = false };
            AnswerOptionModel Answer4_Q10_L3 = new AnswerOptionModel { ID = 4, Answer = "false", IsCorrect = false };
            QuestionL3_Q10.Answers.Add(Answer1_Q10_L3);
            QuestionL3_Q10.Answers.Add(Answer2_Q10_L3);
            QuestionL3_Q10.Answers.Add(Answer3_Q10_L3);
            QuestionL3_Q10.Answers.Add(Answer4_Q10_L3);
            
            
            LevelModel Level_3 = new LevelModel();
            Level_3.QuestionSet.Add(QuestionL3_Q1);
            Level_3.QuestionSet.Add(QuestionL3_Q2);
            Level_3.QuestionSet.Add(QuestionL3_Q3);
            Level_3.QuestionSet.Add(QuestionL3_Q4);
            Level_3.QuestionSet.Add(QuestionL3_Q5);
            Level_3.QuestionSet.Add(QuestionL3_Q6);
            Level_3.QuestionSet.Add(QuestionL3_Q7);
            Level_3.QuestionSet.Add(QuestionL3_Q8);
            Level_3.QuestionSet.Add(QuestionL3_Q9);
            Level_3.QuestionSet.Add(QuestionL3_Q10);


            //ADDING LEVELS TO DATABASE
			LevelModel[] levels = new LevelModel [] { Level_1, Level_2, Level_3 };


			for (int x = 0; x < levels.Length; x++)
			{
				levels[x].ID = realm.All<LevelModel>().Count() + 1;

				realm.Write(() =>
				{
					realm.Add(levels[x]);
				});
				
			}
				

            
		}
	}
}
