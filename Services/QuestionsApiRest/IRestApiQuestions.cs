using QuizQuestionsFront.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuizQuestionsFront.Services.QuestionsApiRest
{
    public interface IRestApiQuestions
    {
        public Task<List<CategoryModel>> LoadCategories(IHttpClientFactory ClientFactory);

        public Task<int> GetQuantityOfQuestions(IHttpClientFactory ClientFactory, int categoryToRequest);

        public Task<List<QuestionModel>> GetQuestions(IHttpClientFactory ClientFactory, int category, int numberOfQuestions);
    }
}
