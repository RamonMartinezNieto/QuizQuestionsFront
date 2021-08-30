using QuizQuestionsFront.Models;
using System.Collections.Generic;

namespace QuizQuestionsFront.MockDataManualTesting
{
    public static class MockData
    {

        public static List<int> MockGenerateValuesNumberOfQuestions() => 
            new List<int>() 
            {
                5,
                10,
                15,
                20
            };


        public static List<CategoryModel> CategoriesMock() => 
            new List<CategoryModel>()
            {
                new CategoryModel()
                {
                    Id = 5,
                    Name = "Java"
                },
                new CategoryModel()
                {
                    Id = 15,
                    Name = "CSharp"
                },
                new CategoryModel()
                {
                    Id = 25,
                    Name = "Ruby"
                } 
            };


        public static List<QuestionModel> GetQuestionsMock() => new()
            {
                new QuestionModel()
                {
                    Id = 5,
                    CorrectAnswer = "CorrectAnswerd 5",
                    IdCategory = 5,
                    Question = "Question 5",
                    WrongAnswers = new string[] {
                    "5 wrong 1",
                    "5 wrong 2",
                    "5 wrong 3",
                }
                },
                new QuestionModel()
                {
                    Id = 15,
                    CorrectAnswer = "CorrectAnswerd 15",
                    IdCategory = 5,
                    Question = "Question 15",
                    WrongAnswers = new string[] {
                    "15 wrong 1",
                    "15 wrong 2",
                    "15 wrong 3",
                }
                },
                new QuestionModel()
                {
                    Id = 25,
                    CorrectAnswer = "CorrectAnswerd 25",
                    IdCategory = 5,
                    Question = "Question 25",
                    WrongAnswers = new string[] {
                    "25 wrong 1",
                    "25 wrong 2",
                    "25 wrong 3",
                }
                },
                new QuestionModel()
                {
                    Id = 35,
                    CorrectAnswer = "CorrectAnswerd 35",
                    IdCategory = 5,
                    Question = "Question 35",
                    WrongAnswers = new string[] {
                    "35 wrong 1",
                    "35 wrong 2",
                    "35 wrong 3",
                }
                },
                new QuestionModel()
                {
                    Id = 45,
                    CorrectAnswer = "CorrectAnswerd 45",
                    IdCategory = 5,
                    Question = "Question 45",
                    WrongAnswers = new string[] {
                    "45 wrong 1",
                    "45 wrong 2",
                    "45 wrong 3",
                }
                }
            };


    }
}
