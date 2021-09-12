using Blazorise;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using QuizQuestionsFront.Models;
using QuizQuestionsFront.Services.QuestionsApiRest;
using QuizQuestionsFront.Services.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuizQuestionsFront.Pages
{
    public partial class SesionsTrainingStorage : ComponentBase
    {
        private string _categoryName;
        [Parameter]
        public string CategoryName {
            get { return _categoryName; }
            set 
            {
                _categoryName = value;
                ShowResultsOfQuiz = false;
            } 
        }

        [Inject]
        private IJSRuntime JsRuntime { get; set; }

        [Inject]
        private ILocalStorage LocalStorage { get; set; }

        [Inject]
        private IHttpClientFactory ClientFactory { get; set; }
        
        [Inject]
        private IRestApiQuestions RestApiQuestions { get; set; }

        public bool ShowResultsOfQuiz { get; set; } = false;

        public List<QuestionAnswer> AnswersList { get; set; }

        Dictionary<int, List<QuestionAnswerLocalStorage>> ListOfQuizes { get; set; }

        protected async override Task OnParametersSetAsync()
        {
            ListOfQuizes = new();
            ListOfQuizes = await LoadCategoriesSaved();
        }

        private async Task<Dictionary<int, List<QuestionAnswerLocalStorage>>> LoadCategoriesSaved() 
        {
            return await LocalStorage.ReadQuizOfCategory(JsRuntime, CategoryName);
        }

        public Color GetColor(int isOdd)
        {
            if (isOdd % 2 == 0) return Color.Primary;
            else return Color.Secondary;
        }

        public void ShowResults(DateTime dateTimeSelected) 
        {
            //No estoy cargando la lista se ejecuta
            AnswersList = LoadConcreteAnswerList(dateTimeSelected);
            ShowResultsOfQuiz = !ShowResultsOfQuiz;
        }

        public void GoBack()
        {
            ShowResultsOfQuiz = !ShowResultsOfQuiz;
        }

        private async Task<int> GetCategory() 
        {
            return await RestApiQuestions.GetCategoryId(ClientFactory, CategoryName);
        }

        private List<QuestionAnswer> LoadConcreteAnswerList(DateTime dateTimeSelected)
        {
            List<QuestionAnswer> _tempList = new();

            foreach (var item in ListOfQuizes) 
            {
                if (item.Value.First().DateTime.Equals(dateTimeSelected)) 
                {
                    foreach (var question in item.Value) 
                    {
                        _tempList.Add(new QuestionAnswer() 
                        {
                            CorrecValueAnswer = question.CorrecValueAnswer,
                            QuestionId = question.QuestionId,
                            QuestionName = question.QuestionName,
                            SelectedByUser = question.SelectedByUser,
                            ShuffleAnswersList = question.ShuffleAnswersList
                        });
                    }
                    return _tempList;
                }
            }
            return _tempList;
        }
    }
}
