using Microsoft.JSInterop;
using QuizQuestionsFront.Models;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace QuizQuestionsFront.Services
{
    public class SessionStorageService : ISessionStorageService
    {
        public async Task<List<CategoryModel>> ReadCategoryListAsync(IJSRuntime jsRuntime)
        {
            List<CategoryModel> listReader = new();

            try
            {
                var read = await jsRuntime.InvokeAsync<string>("sessionStorage.getItem", "listCategories");

                if (read != null || !read.Equals(string.Empty))
                {
                    listReader = JsonSerializer.Deserialize<List<CategoryModel>>(read);
                }
            }
            catch (Exception ex) { /*Ignore*/}

            return listReader;
        }

        public void SaveListCategories(IJSRuntime jsRuntime, List<CategoryModel> listCategories)
        {
            jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "listCategories", JsonSerializer.Serialize(listCategories));
        }
    }
}
