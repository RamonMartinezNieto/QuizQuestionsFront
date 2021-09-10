using Microsoft.JSInterop;
using QuizQuestionsFront.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizQuestionsFront.Services.Storage
{
    public interface ILocalStorage
    {
        public Task SaveQuizes(
            IJSRuntime jsRuntime,
            Dictionary<int, List<QuestionAnswer>> listQuizesSaved,
            List<QuestionAnswer> newQuizToSave,
            string categoryName);

        public Task<Dictionary<int, List<QuestionAnswer>>> ReadQuizOfCategory(IJSRuntime jsRuntime, string categoryName);

        public Task<List<string>> GetCategoriesQuizesSaved(IJSRuntime jsRuntime);

    }
}