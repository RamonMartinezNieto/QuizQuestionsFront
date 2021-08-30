using Microsoft.AspNetCore.Components;
using QuizQuestionsFront.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace QuizQuestionsFront.Pages
{
    public partial class QuestionsQuiz : ComponentBase
    {
        public List<int> ListSelectedNumberOfQuestions = new List<int>();

        [Inject]
        private IHttpClientFactory ClientFactory { get; set; }

        private int _selectedCategory = 0;
        public int SelectedCategory {
            get => _selectedCategory;
            set {
                    _selectedCategory = value;
                    GetQuantityOfQuestions();
            }
        }

        private bool IsEnableSelectNumberOfQuestions = false;
        public int SelectedNumberOfQuestions { get; set; } = 0;
        public int QuantityOfQuestions { get; set; } = 0;

        public List<CategoryModel> ListCategories { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            if (!ListCategories.Any()) {
                if (ConstVariables.IS_DEBUG_MODE)
                {
                    ListCategories = CategoriesMock();
                }
                else {
                    ListCategories = await LoadCategories();
                }
            }
            await base.OnInitializedAsync();
        }

        public List<CategoryModel> CategoriesMock()
        {
            List<CategoryModel> listCategories = new List<CategoryModel>();

            listCategories.Add(new CategoryModel()
            {
                Id = 5,
                Name = "Java"
            });

            listCategories.Add(new CategoryModel()
            {
                Id = 15,
                Name = "C#"
            });

            return listCategories;
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

        private void MockGenerateValuesNumberOfQuestions() 
        {
            ListSelectedNumberOfQuestions.Add(5);
            ListSelectedNumberOfQuestions.Add(10);
        }

        private async Task<List<CategoryModel>> LoadCategories()
        {
            var client = ClientFactory.CreateClient("QuestionsApi");
            try
            {
                var test = await client.GetFromJsonAsync<List<CategoryModel>>($"/Category/Categories", new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return test;
            }
            catch (Exception ex)
            {
                throw new Exception("exception LoadCategories using RestAPI", ex);
            }
        }

        private async Task<int> GetQuantityOfQuestions()
        {
            if (ConstVariables.IS_DEBUG_MODE) 
            {
                IsEnableSelectNumberOfQuestions = true;
                QuantityOfQuestions = 10;
                MockGenerateValuesNumberOfQuestions();
                StateHasChanged();
                return 10;
            }
            var client = ClientFactory.CreateClient("QuestionsApi");
            try
            {
                var intQuantityOfQuestions = await client.GetFromJsonAsync<int>($"/Question/{SelectedCategory}/MaxQuestionsToRequest");
                QuantityOfQuestions = intQuantityOfQuestions;
                GenerateValuesNumberOfQuestions();
                StateHasChanged();
                return intQuantityOfQuestions;
            }
            catch (Exception ex)
            {
                throw new Exception("exception GetQuantityOfQuestions using RestAPI", ex);
            }
        }

        public string GetRoute() => $"StartQuiz/{SelectedCategory}/{SelectedNumberOfQuestions}";

    }
}
