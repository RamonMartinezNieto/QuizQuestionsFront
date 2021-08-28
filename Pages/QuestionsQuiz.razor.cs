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
        public static readonly int[] TimesQuiz = { 5, 10, 15, 20, 25, 30 };

        [Inject]
        private IHttpClientFactory ClientFactory { get; set; }

        public int SelectedCategory { get; set; }
        public int SelectedNumberOfQuestions { get; set; }

        public List<CategoryModel> ListCategories { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            if (!ListCategories.Any()) {
                //ListCategories = await LoadCategories();
                ListCategories = CategoriesMock();
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
                Id = 10,
                Name = "C#"
            });

            return listCategories;
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
        

        public string GetRoute() => $"StartQuiz/{SelectedCategory}/{SelectedNumberOfQuestions}";

    }
}
