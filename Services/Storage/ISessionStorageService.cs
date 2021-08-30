using Microsoft.JSInterop;
using QuizQuestionsFront.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizQuestionsFront.Services
{
    public interface ISessionStorageService
    {
        public void SaveListCategories(IJSRuntime jsRuntime, List<CategoryModel> listCategories);

        public Task<List<CategoryModel>> ReadCategoryListAsync(IJSRuntime jsRuntime);
    }
}
