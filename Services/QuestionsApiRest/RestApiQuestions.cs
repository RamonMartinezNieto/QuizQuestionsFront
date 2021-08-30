using QuizQuestionsFront.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace QuizQuestionsFront.Services.QuestionsApiRest
{
    public class RestApiQuestions : IRestApiQuestions
    {

        public async Task<List<CategoryModel>> LoadCategories(IHttpClientFactory ClientFactory)
        {
            var client = ClientFactory.CreateClient("QuestionsApi");
            try
            {
                List<CategoryModel> listCategories = await client.GetFromJsonAsync<List<CategoryModel>>($"/Category/Categories", new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return listCategories;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception requesting to the API the categories", ex);
            }
        }

        public async Task<int> GetQuantityOfQuestions(IHttpClientFactory ClientFactory, int categoryToRequest) 
        {
            var client = ClientFactory.CreateClient("QuestionsApi");
            return await client.GetFromJsonAsync<int>($"/Question/{categoryToRequest}/MaxQuestionsToRequest");
        }

        public async Task<List<QuestionModel>> GetQuestions(IHttpClientFactory ClientFactory, int category, int numberOfQuestions)
        {
            var client = ClientFactory.CreateClient("QuestionsApi");
            try
            {
                return await client.GetFromJsonAsync<List<QuestionModel>>($"/Question/{category}/RandomQuestions/{numberOfQuestions}", new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
            catch (Exception ex)
            {
                throw new Exception("exception GettingQuestions using RestAPI", ex);
            }
        }
    }
}
