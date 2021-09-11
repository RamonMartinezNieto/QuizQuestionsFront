using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using QuizQuestionsFront.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using QuizQuestionsFront.Services.Storage;
using System;

namespace QuizQuestionsFront.Pages
{
    public enum AnswersType { CorrectAnswers, WrongAnswers }

    public partial class EndQuiz : ComponentBase
    {
        [Parameter]
        public List<QuestionAnswer> AnswersList { get; set; }

        [CascadingParameter]
        public int Category { get; set; }

        [CascadingParameter]
        public string CategoryName { get; set; }

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        [Inject]
        private ILocalStorage LocalStorage { get; set; }

        private List<QuestionAnswer> WrongAnswersList { get; set; } = new List<QuestionAnswer>();
        
        private List<QuestionAnswer> CorrectAnswerList { get; set; } = new List<QuestionAnswer>();

        private List<QuestionAnswer> CurrentList { get; set; } = new List<QuestionAnswer>();

        protected override async Task<Task> OnParametersSetAsync()
        {
            WrongAnswersList = GetAnswers(AnswersType.WrongAnswers);
            CorrectAnswerList = GetAnswers(AnswersType.CorrectAnswers);

            CurrentList = new List<QuestionAnswer>(AnswersList);

            //save in local storage
            Dictionary<int, List<QuestionAnswerLocalStorage>> quizesLocalStorage = await LocalStorage.ReadQuizOfCategory(JSRuntime, CategoryName);

            List<QuestionAnswerLocalStorage> listWithDataTime = new();

            foreach (QuestionAnswer questions in AnswersList) 
            {
                QuestionAnswerLocalStorage questionLocalStorage = new()
                {
                    CorrecValueAnswer = questions.CorrecValueAnswer,
                    DateTime = DateTime.Now,
                    QuestionId = questions.QuestionId,
                    QuestionName = questions.QuestionName,
                    SelectedByUser = questions.SelectedByUser,
                    ShuffleAnswersList = questions.ShuffleAnswersList
                };

                listWithDataTime.Add(questionLocalStorage);
            }

            LocalStorage.SaveQuizes(JSRuntime, quizesLocalStorage, listWithDataTime, CategoryName);

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
