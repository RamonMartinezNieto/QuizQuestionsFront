namespace QuizQuestionsFront.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }

        public string Question { get; set; }

        public string[] WrongAnswers { get; set; }

        public string CorrectAnswer { get; set; }

        public int IdCategory { get; set; }
    }
}