using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http.Json;
using System.Linq;
using System;
using QuizQuestionsFront.Models;
using Microsoft.JSInterop;
using System.Timers;

namespace QuizQuestionsFront.Pages
{
    public partial class StartQuiz : ComponentBase
    {
        private bool _shouldRender = false;

        [Parameter]
        public int Category { get; set; }

        [Parameter]
        public int NumberOfQuestions { get; set; }

        [Inject]
        private IHttpClientFactory ClientFactory { get; set; }

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        private bool IsButtonEnable { get; set; } = false;

        private List<QuestionModel> ListQuestions { get; set; } = new List<QuestionModel>();

        private Dictionary<string, int> ShuffleAnswers { get; set; } = new Dictionary<string, int>();

        private QuestionModel CurrentQuestion { get; set; } = new QuestionModel();

        private int CurrentQuestionNumber { get; set; } = 0;

        private ErrorModel Error { get; set; } = new ErrorModel();

        private List<QuestionAnswer> AnswersList { get; set; } = new List<QuestionAnswer>();//idQuestion, value answer

        private QuestionAnswer _questionAnswer { get; set; } = new QuestionAnswer();

        public bool IsLastQuestion { get; private set; } = false;

        public bool EndQuizReport { get; private set; } = false;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                //TODO CAMBIAR DE NUEVO PARA USAR LA API
                //ListQuestions = await GetQuestions();
                ListQuestions = GetQuestionsMock();

                if (ListQuestions.Any())
                {
                    CurrentQuestion = ListQuestions.First();
                    ShuffleAnswers = GetUnSortedQuestions(CurrentQuestion.CorrectAnswer, CurrentQuestion.WrongAnswers);
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

        private List<QuestionModel> GetQuestionsMock()
        {
            List<QuestionModel> questionModels = new List<QuestionModel>();
            questionModels.Add(new QuestionModel()
            {
                Id = 5,
                CorrectAnswer = "CorrectAnswerd 5",
                IdCategory = 5,
                Question = "Question 5",
                WrongAnswers = new string[] {
                    "5 wrong 1",
                    "5 wrong 2",
                    "5 wrong 3",
                }
            }); questionModels.Add(new QuestionModel()
            {
                Id = 15,
                CorrectAnswer = "CorrectAnswerd 15",
                IdCategory = 5,
                Question = "Question 15",
                WrongAnswers = new string[] {
                    "15 wrong 1",
                    "15 wrong 2",
                    "15 wrong 3",
                }
            });
            questionModels.Add(new QuestionModel()
            {
                Id = 25,
                CorrectAnswer = "CorrectAnswerd 25",
                IdCategory = 5,
                Question = "Question 25",
                WrongAnswers = new string[] {
                    "25 wrong 1",
                    "25 wrong 2",
                    "25 wrong 3",
                }
            });
            questionModels.Add(new QuestionModel()
            {
                Id = 35,
                CorrectAnswer = "CorrectAnswerd 35",
                IdCategory = 5,
                Question = "Question 35",
                WrongAnswers = new string[] {
                    "35 wrong 1",
                    "35 wrong 2",
                    "35 wrong 3",
                }
            });
            questionModels.Add(new QuestionModel()
            {
                Id = 45,
                CorrectAnswer = "CorrectAnswerd 45",
                IdCategory = 5,
                Question = "Question 45",
                WrongAnswers = new string[] {
                    "45 wrong 1",
                    "45 wrong 2",
                    "45 wrong 3",
                }
            });

            return questionModels;
        }

        private int counter = 0;
        public Dictionary<string, int> GetUnSortedQuestions(string correctAnswer, params string[] answers)
        {
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
            counter = 0;
            return listOfAnswers;
        }

        protected override bool ShouldRender() => _shouldRender;

        private async Task<List<QuestionModel>> GetQuestions()
        {
            var client = ClientFactory.CreateClient("QuestionsApi");
            try
            {
                return await client.GetFromJsonAsync<List<QuestionModel>>($"/Question/{Category}/RandomQuestions/{NumberOfQuestions}", new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void NextQuestion()
        {
            //TODO Reinicio de cosas 
            SaveAnsweredQuestion(_questionAnswer);
            
            _questionSelectedByUser = "0";
            _questionAnswer.SelectedByUser = 0;
            CurrentQuestionNumber++;
            DisableButton();
            ClearAllRadioButtons();


            if (ListQuestions.Count > (CurrentQuestionNumber))
            {
                CurrentQuestion = ListQuestions[CurrentQuestionNumber];
                ShuffleAnswers = GetUnSortedQuestions(CurrentQuestion.CorrectAnswer, CurrentQuestion.WrongAnswers);
                _questionAnswer.QuestionId = CurrentQuestion.Id;
                _questionAnswer.QuestionName = CurrentQuestion.Question;

                if (ListQuestions.Count == (CurrentQuestionNumber + 1)) IsLastQuestion = true;
            }
        }

        private void SaveAnsweredQuestion(QuestionAnswer answeredQuestion)
        {
            try
            {
                AnswersList.Add(new QuestionAnswer()
                {
                    QuestionId = answeredQuestion.QuestionId,
                    QuestionName = answeredQuestion.QuestionName,
                    ShuffleAnswersList = ShuffleAnswers,
                    SelectedByUser = Convert.ToInt32(_questionSelectedByUser),
                    CorrecValueAnswer = _questionAnswer.CorrecValueAnswer

                });
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        private async Task ClearAllRadioButtons()
        {
            await JSRuntime.InvokeVoidAsync("ClearAllRadioButtons");
        }


        private async void EnableButton() {
            await CheckSelected();
            IsButtonEnable = true;
        }

        private void DisableButton() => IsButtonEnable = false;

        private void FinishQuiz()
        {
            SaveAnsweredQuestion(_questionAnswer);
            EndQuizReport = true;
        }

        //Obtengo el valor del seleccionado, pero la cosa es que no se como indicar si es el correcto
        private string _questionSelectedByUser;
        private async Task CheckSelected()
        {
            _questionSelectedByUser = new(await JSRuntime.InvokeAsync<string>("CheckRadioButtonSelected"));
        }
    }
}