using System.Collections.Generic;

namespace QuizQuestionsFront.Models
{
    public class QuestionAnswer
    {
        public int QuestionId { get; set; }
        
        public string QuestionName { get; set; }

        public int SelectedByUser { get; set; }

        public Dictionary<string, int> ShuffleAnswersList { get; set; }

        public int CorrecValueAnswer { get; set; }
    }
}
