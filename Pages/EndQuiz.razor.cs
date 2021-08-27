using Microsoft.AspNetCore.Components;
using QuizQuestionsFront.Models;
using System.Collections.Generic;
using System.Linq;

namespace QuizQuestionsFront.Pages
{
    public partial class EndQuiz : ComponentBase
    {
        [Parameter]
        public List<QuestionModel> ListQuestions { get; set; }

        [Parameter]
        public Dictionary<int, int> AnswersList { get; set; }

        public List<QuestionModel> _questionsFault { get; set; } = new List<QuestionModel>();

        protected override void OnInitialized()
        {
            _questionsFault = GetQuestionsFault();
            base.OnInitialized();
        }

        private List<QuestionModel> GetQuestionsFault() 
        {
            List<QuestionModel> answerFail = new List<QuestionModel>();
            List<int> listQuestionsWrokng = AnswersList.Where(x => x.Value == 0).Select(x => x.Key).ToList();

            foreach (int questionId in listQuestionsWrokng) 
            {
                foreach (QuestionModel question in ListQuestions) 
                {
                    if(question.Id == questionId) {  answerFail.Add(question); }
                }
            }

            return answerFail;
        }
    }
}
