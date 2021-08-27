using System.Collections.Generic;

namespace QuizQuestionsFront.Models
{
    public class QuestionAnswer
    {
        public int QuestionId { get; set; }
        
        public int ValueAnswer { get; set; }
        
        public int SelectedByUser { get; set; }

        public Dictionary<string, int> ShuffleAnswersList { get; set; }
    }
}
