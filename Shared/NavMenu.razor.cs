using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using QuizQuestionsFront.Models;
using QuizQuestionsFront.Services.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizQuestionsFront.Shared
{
    public partial class NavMenu : ComponentBase
    {

        [Inject]
        private IJSRuntime JsRuntime { get; set; }

        [Inject]
        private ILocalStorage LocalStorage { get; set; }

        private bool collapseNavMenu = false;

        private List<(string category, int quices)> ListCategoriesQuizesSaved { get; set; }
        private string selectedItem = "first";
        private bool visible = false;

        protected async override Task OnParametersSetAsync()
        {
            ListCategoriesQuizesSaved = await LoadCategoriesSaved();
        }

        public void ChangeVisible() => visible = !visible;

        private async Task<List<(string category, int quices)>> LoadCategoriesSaved()
        {
            List<(string category, int quices)> tempListCatQuiz = new(); 

            var _listCat = await LocalStorage.GetCategoriesQuizesSaved(JsRuntime);
            foreach (string cat in _listCat)
            {
                var _answersCat = await LocalStorage.ReadQuizOfCategory(JsRuntime, cat);
                tempListCatQuiz.Add((cat, _answersCat.Count));
            }
            return tempListCatQuiz;
        }

        private string NavMenuCssClass => collapseNavMenu ? "collapse.show" : "collapse.show";

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }

        public string GetRoute(string category) => $@"SessionsTraining\{category}";

    }
}
