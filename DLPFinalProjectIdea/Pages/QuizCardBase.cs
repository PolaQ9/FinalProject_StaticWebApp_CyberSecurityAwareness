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
                QuestionTitle = "Why is it important to be aware of cyber-security practices?",
                Options = new List<string>() { "Avoiding unintentional mistakes which could result in unauthorised access or cyber-attack", "Monitor user activities", "Increases computer speed", "Allows applications on the computer to work" },
                Answer = "To not make unintentional mistake which could result in unauthorised access or cyber-attack"
            };
            Question q2 = new Question
            {
                QuestionTitle = "A strong password contains only letters",
                Options = new List<string>() { "True", "False" },
                Answer = "False"
            };
            Question q3 = new Question
            {
                QuestionTitle = "What does 2FA (Two Factor Authentication) help with?",
                Options = new List<string>() { "Speeds up the login process", "Disables password", "Encryptes emails", "Makes it harder for hackers to access accounts" },
                Answer = "Makes it harder for hackers to access accounts"
            };
            Question q4 = new Question
            {
                QuestionTitle = "What is Phishing?",
                Options = new List<string>() { "A tool to increase the internet speed", "A method to store your passwords safely", "Protects the computer from viruses", "A trick used by hackers to steal information" },
                Answer = "A trick used by hackers to steal information"
            };
            Question q5 = new Question
            {
                QuestionTitle = "What should you do if you receive an email from an unknown sender with an attachment?",
                Options = new List<string>() { "Open the attachment to view what it is", "Send it to a coworker", "Report and delete it", "Click on the links to see the websites" },
                Answer = "Report and delete it"
            };
            Question q6 = new Question
            {
                QuestionTitle = "Which of the following is the safest way to create and store passwords?",
                Options = new List<string>() { "Using simple password for everything", "Writing them on sticky notes", "Saving them in notepad on the computer", "Using a password manager" },
                Answer = "Using a password manager"
            };
            Question q7 = new Question
            {
                QuestionTitle = "What is an example of vishing (voice phishing)?",
                Options = new List<string>() { "A fake tech support call asking for payment details", "Fake invoice email", "Website asking you to add payment information", "SMS message sending a link" },
                Answer = "A fake tech support call asking for payment details"
            };
            Question q8 = new Question
            {
                QuestionTitle = "What is the best way to create a strong password?",
                Options = new List<string>() { "Using your name and birthdate", "password1234 as it will be easy to remember", "Your phone number", "A mix of letters, numbers and symbols with atleast 12 characters" },
                Answer = "numbers and symbols with atleast 12 characters"
            };

            Questions.AddRange(new List<Question> { q1, q2, q3, q4, q5, q6, q7, q8 });
        }
    }
}
