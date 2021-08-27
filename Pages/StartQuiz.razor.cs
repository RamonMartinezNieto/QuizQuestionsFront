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

        private Dictionary<int, int> AnswersList { get; set; } = new Dictionary<int, int>();//idQuestion, value answer
        
        private QuestionAnswer _questionAnswer { get; set; } = new QuestionAnswer();

        public bool IsLastQuestion { get; private set; } = false;

        public bool EndQuizReport { get; private set; } = false;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                //ListQuestions = await GetQuestions();

                ListQuestions = GetQuestionsMock();


                if (ListQuestions.Any())
                {
                    CurrentQuestion = ListQuestions.First();
                    ShuffleAnswers = GetUnSortedQuestions(CurrentQuestion.CorrectAnswer, CurrentQuestion.WrongAnswers);
                    _questionAnswer.QuestionId = CurrentQuestion.Id;
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
            List<QuestionModel> questionModels= new List<QuestionModel>();
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

        public Dictionary<string, int> GetUnSortedQuestions(string correctAnswer, params string[] answers) 
        {

            Dictionary<string, int> listOfAnswers = new Dictionary<string, int>();
            listOfAnswers.Add(correctAnswer, 1);
            answers.ToList().ForEach(x => listOfAnswers.Add(x, 0));

            Random rand = new Random();
            listOfAnswers = listOfAnswers.OrderBy(x => rand.Next()).ToDictionary(item => item.Key, item => item.Value);

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
            SaveAnsweredQuestion(_questionAnswer);
            CurrentQuestionNumber++;
            DisableButton();
            ClearAllRadioButtons();

            if (ListQuestions.Count > (CurrentQuestionNumber))
            {
                CurrentQuestion = ListQuestions[CurrentQuestionNumber];
                ShuffleAnswers = GetUnSortedQuestions(CurrentQuestion.CorrectAnswer, CurrentQuestion.WrongAnswers);
                _questionAnswer.QuestionId = CurrentQuestion.Id;
                 
                if (ListQuestions.Count == (CurrentQuestionNumber + 1)) IsLastQuestion = true;
            }
        }

        private void SaveAnsweredQuestion(QuestionAnswer answeredQuestion) 
        {
            try
            {
                AnswersList.Add(answeredQuestion.QuestionId, answeredQuestion.ValueAnswer);
            }
            catch (Exception ex) {
                throw ex; 
            }
        }

        private async Task ClearAllRadioButtons()
        {
            await JSRuntime.InvokeVoidAsync("ClearAllRadioButtons");
        }

        private void EnableButton() => IsButtonEnable = true;

        private void DisableButton() => IsButtonEnable = false;

        private void FinishQuiz()
        {
            SaveAnsweredQuestion(_questionAnswer);
            EndQuizReport = true;
        }
    }
}