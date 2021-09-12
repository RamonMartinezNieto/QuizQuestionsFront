using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using System;
using QuizQuestionsFront.Models;
using Microsoft.JSInterop;
using QuizQuestionsFront.MockDataManualTesting;
using QuizQuestionsFront.Services.QuestionsApiRest;
using QuizQuestionsFront.Services.Storage;

namespace QuizQuestionsFront.Pages
{
    public partial class StartQuiz : ComponentBase
    {
        private bool _shouldRender = false;

        [Parameter]
        public int Category { get; set; }

        [Parameter]
        public string CategoryName {  get; set; }   

        [Parameter]
        public int NumberOfQuestions { get; set; }

        [Inject]
        private IHttpClientFactory ClientFactory { get; set; }

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        [Inject]
        private IRestApiQuestions RestApiQuestions { get; set; }

        [Inject]
        private ILocalStorage LocalStorage { get; set; }

        PersonalizedProgressBarsQuestions PersonalizedProgressBar { get; set; }

        private bool IsButtonEnable { get; set; } = false;
        private List<QuestionModel> ListQuestions { get; set; } = new List<QuestionModel>();
        private Dictionary<string, int> ShuffleAnswers { get; set; } = new Dictionary<string, int>();
        private QuestionModel CurrentQuestion { get; set; } = new QuestionModel();
        private int CurrentQuestionNumber { get; set; } = 0;
        private ErrorModel Error { get; set; } = new ErrorModel();
        private List<QuestionAnswer> AnswersList { get; set; } = new List<QuestionAnswer>();
        private QuestionAnswer _questionAnswer { get; set; } = new QuestionAnswer();
        public bool IsLastQuestion { get; private set; } = false;
        public bool EndQuizReport { get; private set; } = false;

        private string _questionSelectedByUser;

        protected override bool ShouldRender() => _shouldRender;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                if (ConstVariables.IS_DEBUG_MODE) 
                {
                    ListQuestions = MockData.GetQuestionsMock();
                } else {
                    ListQuestions = await RestApiQuestions.GetQuestions(ClientFactory, Category, NumberOfQuestions);
                }

                if (ListQuestions.Any())
                {
                    CurrentQuestion = ListQuestions.First();
                    ShuffleAnswers = GenerateShuffleQuestions(CurrentQuestion.CorrectAnswer, CurrentQuestion.WrongAnswers);
                    _questionAnswer.QuestionId = CurrentQuestion.Id;
                    _questionAnswer.QuestionName = CurrentQuestion.Question;
                    _questionAnswer.ShuffleAnswersList = ShuffleAnswers;
                }

                _shouldRender = true;
            }
            catch (Exception ex)
            {
                Error.Message = ex.Message;
                Error.IsError = true;
            }

            await base.OnInitializedAsync();
        }


        public Dictionary<string, int> GenerateShuffleQuestions(string correctAnswer, params string[] answers)
        {
            int counter = 0;
            Dictionary<string, int> listOfAnswers = new Dictionary<string, int>();
            listOfAnswers.Add(correctAnswer, 1);
            answers.ToList().ForEach(x => listOfAnswers.Add(x, 0));

            Random rand = new Random();
            listOfAnswers = listOfAnswers.OrderBy(x => rand.Next()).ToDictionary(item => item.Key, item => {
                counter++;
                int valueToReturn = Convert.ToInt32(String.Format("{0}{1}", counter, item.Value));

                if (valueToReturn == 11 || valueToReturn == 21 || valueToReturn == 31 || valueToReturn == 41) 
                {
                    _questionAnswer.CorrecValueAnswer = valueToReturn;
                }

                return valueToReturn;
            });
            return listOfAnswers;
        }

        private void NextQuestion()
        {
            SaveAnsweredQuestion(_questionAnswer);
            ResetNecesaryVariables();

            if (ListQuestions.Count > (CurrentQuestionNumber))
            {
                CurrentQuestion = ListQuestions[CurrentQuestionNumber];
                ShuffleAnswers = GenerateShuffleQuestions(CurrentQuestion.CorrectAnswer, CurrentQuestion.WrongAnswers);
                _questionAnswer.QuestionId = CurrentQuestion.Id;
                _questionAnswer.QuestionName = CurrentQuestion.Question;

                if (ListQuestions.Count == (CurrentQuestionNumber + 1)) IsLastQuestion = true;
            }
        }

        private void ResetNecesaryVariables()
        {
            _questionSelectedByUser = "0";
            _questionAnswer.SelectedByUser = 0;
            CurrentQuestionNumber++;
            IsButtonEnable = false;
            ClearAllRadioButtons();
            PersonalizedProgressBar.ResetVariablesTimmer();
        }

        private async Task ClearAllRadioButtons() => await JSRuntime.InvokeVoidAsync("ClearAllRadioButtons");

        private void SaveAnsweredQuestion(QuestionAnswer answeredQuestion) =>
            AnswersList.Add(new QuestionAnswer()
            {
                QuestionId = answeredQuestion.QuestionId,
                QuestionName = answeredQuestion.QuestionName,
                ShuffleAnswersList = ShuffleAnswers,
                SelectedByUser = Convert.ToInt32(_questionSelectedByUser),
                CorrecValueAnswer = _questionAnswer.CorrecValueAnswer
            });

        private async void EnableButton() {
            await CheckSelected();
            IsButtonEnable = true;
        }

        private void FinishQuiz()
        {
            SaveAnsweredQuestion(_questionAnswer);
            SaveCurrentQuiz();
            EndQuizReport = true;
        }

        private async void SaveCurrentQuiz() 
        {
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

            //TODO el save aquí me está matando por que no puedo hacer que el componente sea reutilizable
            // save en local storage
            LocalStorage.SaveQuizes(JSRuntime, quizesLocalStorage, listWithDataTime, CategoryName);
        }

        private async Task CheckSelected() =>
            _questionSelectedByUser = new(await JSRuntime.InvokeAsync<string>("CheckRadioButtonSelected"));
    }
}