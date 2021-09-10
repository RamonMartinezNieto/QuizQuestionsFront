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

        private bool _shouldRender = false;

        protected override async void OnParametersSet()
        {
            ListCategoriesQuizesSaved = new();
            await LoadCategoriesSaved();

            _shouldRender = true;
            StateHasChanged();
            base.OnParametersSet();
        }
        protected override bool ShouldRender() => _shouldRender;

        private async Task LoadCategoriesSaved()
        {
            var _listCat = await LocalStorage.GetCategoriesQuizesSaved(JsRuntime);
            foreach (string cat in _listCat)
            {
                var _answersCat = await LocalStorage.ReadQuizOfCategory(JsRuntime, cat);
                ListCategoriesQuizesSaved.Add((cat, _answersCat.Count));
            }
        }

        private string NavMenuCssClass => collapseNavMenu ? "collapse.show" : "collapse.show";

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }
    }
}
