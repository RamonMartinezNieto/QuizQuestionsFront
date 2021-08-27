using Microsoft.AspNetCore.Components;
using QuizQuestionsFront.Models;
using System.Collections.Generic;

namespace QuizQuestionsFront.Pages
{
    public partial class QuestionsQuiz : ComponentBase
    {
        public static readonly int[] TimesQuiz = { 5, 10, 15, 20, 25, 30 };

        public int SelectedCategory { get; set; }
        public int SelectedNumberOfQuestions { get; set; }

        //TODO get categories from API 
        public List<CategoryModel> LoadCategories()
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

        public string GetRoute() => $"StartQuiz/{SelectedCategory}/{SelectedNumberOfQuestions}";

    }
}
