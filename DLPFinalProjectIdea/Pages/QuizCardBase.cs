using DLPFinalProjectIdea.Models;
using Microsoft.AspNetCore.Components;

namespace DLPFinalProjectIdea.Pages
{
    public class QuizCardBase : ComponentBase
    {
        public List<Question> Questions { get; set; } = new List<Question>();
        protected int questionIndex = 0;
        protected int score = 0;

        protected override Task OnInitializedAsync()
        {
            LoadQuestions();

            return base.OnInitializedAsync();
        }

        protected void OptionSelected(string option)
        {
            if (option == Questions[questionIndex].Answer)
            {
                score++;
            }
            questionIndex++;
        }


        private void LoadQuestions()
        {
            Question q1 = new Question
            {
                QuestionTitle = "What is Phishing?",
                Options = new List<string>() { "1", "x", "Tricking the user into clicking onto a malicious link", "4" },
                Answer = "Tricking the user into clicking onto a malicious link"
            };
            Question q2 = new Question
            {
                QuestionTitle = "This is a quiz template",
                Options = new List<string>() { "8", "x", "hgfhf", "4" },
                Answer = "x"
            };

            Questions.AddRange(new List<Question> { q1, q2 });
        }
    }
}
