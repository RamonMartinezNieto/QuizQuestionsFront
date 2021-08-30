using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using QuizQuestionsFront.MockDataManualTesting;
using QuizQuestionsFront.Models;
using QuizQuestionsFront.Services;
using QuizQuestionsFront.Services.QuestionsApiRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuizQuestionsFront.Pages
{
    public partial class QuestionsQuiz : ComponentBase
    {
        [Inject]
        private IHttpClientFactory ClientFactory { get; set; }

        [Inject]
        public IJSRuntime jSRuntime { get; set; }

        [Inject]
        private ISessionStorageService SessionStorage { get; set; }

        [Inject]
        private IRestApiQuestions RestApiQuestions { get; set; }

        private bool IsEnableSelectNumberOfQuestions = false;

        public int SelectedNumberOfQuestions { get; set; } = 0;

        public int QuantityOfQuestions { get; set; } = 0;

        public List<CategoryModel> ListCategories { get; set; } = new();

        public List<int> ListSelectedNumberOfQuestions = new();
        private string SelectedCategoryName { get; set; } = string.Empty;

        private int _selectedCategory = 0;
        public int SelectedCategory {
            get => _selectedCategory;
            set {
                _selectedCategory = value;
                SelectedCategoryName = ListCategories.First(a => a.Id == SelectedCategory).Name;
                GetQuantityOfQuestions();
            }
        }

        public string GetRoute() => $"StartQuiz/{SelectedCategoryName}/{SelectedCategory}/{SelectedNumberOfQuestions}";

        protected override async Task OnInitializedAsync()
        {
            if (!ListCategories.Any()) {
                if (ConstVariables.IS_DEBUG_MODE)
                {
                    ListCategories = MockData.CategoriesMock();
                }
                else {
                    ListCategories = await SessionStorage.ReadCategoryListAsync(jSRuntime);

                    if(!ListCategories.Any())
                    {
                        try { 
                            ListCategories = await RestApiQuestions.LoadCategories(ClientFactory);
                            SessionStorage.SaveListCategories(jSRuntime, ListCategories);
                        }catch(Exception ex) { /*TODO Show message ALERT*/ }
                    }
                    
                }
            }
            StateHasChanged();
            await base.OnInitializedAsync();
        }

        private async void GetQuantityOfQuestions()
        {
            if (ConstVariables.IS_DEBUG_MODE) 
            {
                IsEnableSelectNumberOfQuestions = true;
                QuantityOfQuestions = 10;
                ListSelectedNumberOfQuestions = MockData.MockGenerateValuesNumberOfQuestions();
                StateHasChanged();

            } else { 
                try
                {
                    QuantityOfQuestions = await RestApiQuestions.GetQuantityOfQuestions(ClientFactory, SelectedCategory);
                    GenerateValuesNumberOfQuestions();
                    IsEnableSelectNumberOfQuestions = true;
                    StateHasChanged();
                }
                catch (Exception ex)
                {
                    throw new Exception("exception GetQuantityOfQuestions using RestAPI", ex);
                }
            }
        }

        private void GenerateValuesNumberOfQuestions()
        {
            ListSelectedNumberOfQuestions.Clear();
            int count = 0;
            while (QuantityOfQuestions > 0)
            {
                if (QuantityOfQuestions >= 5)
                {
                    count += 5;
                    ListSelectedNumberOfQuestions.Add(count);
                    QuantityOfQuestions -= 5;
                }
                else
                {
                    count += QuantityOfQuestions;
                    ListSelectedNumberOfQuestions.Add(count);
                    QuantityOfQuestions -= QuantityOfQuestions;
                }
            }
        }
    }
}