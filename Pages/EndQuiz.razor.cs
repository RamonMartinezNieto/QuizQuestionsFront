using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using QuizQuestionsFront.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;
using System;
using System.Linq;

namespace QuizQuestionsFront.Pages
{

    public enum AnswersType { CorrectAnswers, WrongAnswers }

    public partial class EndQuiz : ComponentBase
    {
        [Parameter]
        public List<QuestionAnswer> AnswersList { get; set; }

        [CascadingParameter]
        public int Category { get; set; }

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        private List<QuestionAnswer> WrongAnswersList { get; set; } = new List<QuestionAnswer>();
        
        private List<QuestionAnswer> CorrectAnswerList { get; set; } = new List<QuestionAnswer>();

        private List<QuestionAnswer> CurrentList { get; set; } = new List<QuestionAnswer>();

        protected override Task OnParametersSetAsync()
        {
            WrongAnswersList = GetAnswers(AnswersType.WrongAnswers);
            CorrectAnswerList = GetAnswers(AnswersType.CorrectAnswers);

            CurrentList = new List<QuestionAnswer>(AnswersList);

            //save in sesion storage

            SaveAnswerList();

            return base.OnParametersSetAsync();
        }

        public async Task SaveAnswerList()
        {
            Dictionary<int, List<QuestionAnswer>> listOfOldQuestions = new();
            string read = await ReadLocalStorage();

            try { 
                if (read != null || !read.Equals(string.Empty))
                    listOfOldQuestions = JsonSerializer.Deserialize<Dictionary<int, List<QuestionAnswer>>>(read);
            } catch { /*nothing to do*/ }

            if (listOfOldQuestions.Any())
                listOfOldQuestions.Add(listOfOldQuestions.Count, AnswersList);
            else 
                listOfOldQuestions.Add(0, AnswersList);

            await JSRuntime.InvokeVoidAsync("localStorage.setItem", $"{Category}:SavedQuiz", JsonSerializer.Serialize(listOfOldQuestions));
        }

        public async Task<string> ReadLocalStorage()
        {
            return await JSRuntime.InvokeAsync<string>("localStorage.getItem", $"{Category}:SavedQuiz");
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
