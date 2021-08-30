using Microsoft.JSInterop;
using QuizQuestionsFront.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace QuizQuestionsFront.Services.Storage
{
    public class LocalStorage : ILocalStorage
    {
        public async Task SaveQuizes(
            IJSRuntime jsRuntime,
            Dictionary<int, List<QuestionAnswer>> listQuizesSaved, 
            List<QuestionAnswer> newQuizToSave, 
            string categoryName)
        {

            if (listQuizesSaved.Any())
                listQuizesSaved.Add(listQuizesSaved.Count, newQuizToSave);
            else
                listQuizesSaved.Add(0, newQuizToSave);

            await jsRuntime.InvokeVoidAsync("localStorage.setItem", $"SavedQuiz:{categoryName}", JsonSerializer.Serialize(listQuizesSaved));
        }

        public async Task<Dictionary<int, List<QuestionAnswer>>> ReadQuizes(IJSRuntime jsRuntime, string categoryName)
        {
            Dictionary<int, List<QuestionAnswer>> listOfOldQuizs = new();
            string read = await jsRuntime.InvokeAsync<string>("localStorage.getItem", $"SavedQuiz:{categoryName}");
            try
            {
                if (read != null || !read.Equals(string.Empty))
                    listOfOldQuizs = JsonSerializer.Deserialize<Dictionary<int, List<QuestionAnswer>>>(read);
            }
            catch { /*nothing to do*/ }

            return listOfOldQuizs;
        }
    }
}
