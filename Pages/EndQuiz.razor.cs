using Microsoft.AspNetCore.Components;
using QuizQuestionsFront.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizQuestionsFront.Pages
{

    public enum AnswersType { CorrectAnswers, WrongAnswers }

    public partial class EndQuiz : ComponentBase
    {
        [Parameter]
        public List<QuestionAnswer> AnswersList { get; set; }

        private List<QuestionAnswer> WrongAnswersList { get; set; } = new List<QuestionAnswer>();
        
        private List<QuestionAnswer> CorrectAnswerList { get; set; } = new List<QuestionAnswer>();

        private List<QuestionAnswer> CurrentList { get; set; } = new List<QuestionAnswer>();

        protected override Task OnParametersSetAsync()
        {
            WrongAnswersList = GetAnswers(AnswersType.WrongAnswers);
            CorrectAnswerList = GetAnswers(AnswersType.CorrectAnswers);

            CurrentList = new List<QuestionAnswer>(AnswersList);

            return base.OnParametersSetAsync();
        }

        private List<QuestionAnswer> GetAnswers(AnswersType answerType)
        {
            List<QuestionAnswer> listAnswersRequest = new List<QuestionAnswer>();
            foreach (QuestionAnswer questionAnswer in AnswersList)
            {
                switch (answerType) 
                {
                    case AnswersType.WrongAnswers:
                        if (questionAnswer.SelectedByUser != questionAnswer.CorrecValueAnswer)
                            listAnswersRequest.Add(questionAnswer);
                        break;
                    case AnswersType.CorrectAnswers:
                        if (questionAnswer.SelectedByUser == questionAnswer.CorrecValueAnswer)
                            listAnswersRequest.Add(questionAnswer);
                        break;
                }
            }
            return listAnswersRequest;
        }

        private void SetListView(List<QuestionAnswer> listToSee) 
        {
            CurrentList.Clear();
            CurrentList = new List<QuestionAnswer>(listToSee);
            StateHasChanged();
        }
    }
}
