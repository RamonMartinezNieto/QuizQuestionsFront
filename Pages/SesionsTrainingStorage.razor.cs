using Blazorise;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using QuizQuestionsFront.Models;
using QuizQuestionsFront.Services.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizQuestionsFront.Pages
{
    public partial class SesionsTrainingStorage : ComponentBase
    {

        [Parameter]
        public string Category { get; set; }

        [Inject]
        private IJSRuntime JsRuntime { get; set; }

        [Inject]
        private ILocalStorage LocalStorage { get; set; }
        private string SelectedItem { get; set; }
        public int CountIndex { get; set; }

        Dictionary<int, List<QuestionAnswerLocalStorage>> ListOfQuizes { get; set; }

        protected async override Task OnParametersSetAsync()
        {
            ListOfQuizes = new();
            ListOfQuizes = await LoadCategoriesSaved();
        }

        private async Task<Dictionary<int, List<QuestionAnswerLocalStorage>>> LoadCategoriesSaved() 
        {
            return await LocalStorage.ReadQuizOfCategory(JsRuntime, Category);
        }

        public Color GetColor(int isOdd)
        {
            if (isOdd % 2 == 0) return Color.Primary;
            else return Color.Secondary;
        }
    }
}
