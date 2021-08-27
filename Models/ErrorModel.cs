namespace QuizQuestionsFront.Models
{
    public class ErrorModel
    {
        public string Message { get; set; } = string.Empty;
        
        public bool IsError { get; set; } = false;

        public ErrorModel()
        {
            Message = string.Empty;
            IsError = false;
        }

        public ErrorModel(string message, bool isError)
        {
            Message = message;
            IsError = isError;
        }
    }
}