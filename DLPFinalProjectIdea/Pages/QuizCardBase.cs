using DLPFinalProjectIdea.Models;
using Microsoft.AspNetCore.Components;

namespace DLPFinalProjectIdea.Pages
{
    public class QuizCardBase : ComponentBase
    {
        public List<Question> Questions { get; set; } = new List<Question>();
        protected int questionIndex = 0;
        protected int score = 0;

        [Parameter]
        public string QuizId { get; set; } = string.Empty;
        protected override Task OnParametersSetAsync()
        {
            LoadQuestions();

            return base.OnParametersSetAsync();
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


            if (QuizId == "cyber-awareness")
            {
                var q1 = new Question
                {
                    QuestionTitle = "Why is it important to be aware of cyber-security practices?",
                    Options = new List<string>
                    {
                        "Avoiding unintentional mistakes that can cause cyber-attack",
                        "Monitor user activities",
                        "Increases computer speed",
                        "Allows apps to work"
                    },
                    Answer = "Avoiding unintentional mistakes that can cause cyber-attack"
                };

                var q2 = new Question
                {
                    QuestionTitle = "A strong password contains only letters",
                    Options = new List<string>() { "True", "False" },
                    Answer = "False"

                };

                var q3 = new Question
                {
                    QuestionTitle = "What does 2FA (Two Factor Authentication) help with?",
                    Options = new List<string>
                    {
                        "Speeds up the login process",
                        "Disables password",
                        "Encryptes emails",
                        "Makes it harder for hackers to access accounts"
                    },
                    Answer = "Makes it harder for hackers to access accounts"
                };

                var q4 = new Question
                {
                    QuestionTitle = "What is Phishing?",
                    Options = new List<string>
                    {
                        "A tool to increase the internet speed",
                        "A method to store your passwords safely",
                        "Protects the computer from viruses",
                        "A trick used by hackers to steal information"
                    },
                    Answer = "A trick used by hackers to steal information"
                };

                var q5 = new Question
                {
                    QuestionTitle = "What should you do if you receive an email from an unknown sender with an attachment?",
                    Options = new List<string>
                    {
                        "Open the attachment to view what it is",
                        "Send it to a coworker",
                        "Report and delete it",
                        "Click on the links to see the websites"
                    },
                    Answer = "Report and delete it"
                };

                var q6 = new Question
                {
                    QuestionTitle = "Which of the following is the safest way to create and store passwords?",
                    Options = new List<string>
                    {
                        "Using simple password for everything",
                        "Writing them on sticky notes",
                        "Saving them in notepad on the computer",
                        "Using a password manager"
                    },
                    Answer = "Using a password manager"
                };

                var q7 = new Question
                {
                    QuestionTitle = "What is an example of vishing (voice phishing)?",
                    Options = new List<string>
                    {
                        "A fake tech support call asking for payment details",
                        "Fake invoice email",
                        "Website asking you to add payment information",
                        "SMS message sending a link"
                    },
                    Answer = "A fake tech support call asking for payment details"
                };

                var q8 = new Question
                {
                    QuestionTitle = "What is the best way to create a strong password?",
                    Options = new List<string>
                    {
                        "Using your name and birthdate",
                        "password1234 as it will be easy to remember",
                        "Your phone number",
                        "A mix of letters, numbers and symbols with atleast 12 characters"
                    },
                    Answer = "A mix of letters, numbers and symbols with atleast 12 characters"
                };

                Questions.AddRange(new List<Question> { q1, q2, q3, q4, q5, q6, q7, q8 });
            }
            else if (QuizId == "malware")
            {
                var q1 = new Question
                {
                    QuestionTitle = "What is a Trojan horse?",
                    Options = new List<string> { "A worm", "A virus", "A deceptive malware", "Firewall" },
                    Answer = "A deceptive malware"
                };

                var q2 = new Question
                {
                    QuestionTitle = "What is a malware?",
                    Options = new List<string> { "A software that helps your computer", "Anti-Virus", "Harmful software designed to damage or steal data", "Hardware component in the computer" },
                    Answer = "Harmful software designed to damage or steal data"
                };

                var q3 = new Question
                {
                    QuestionTitle = "Which of these is a type of malware?",
                    Options = new List<string> { "SQL Injection", "Phishing", "Ransomware", "Firewall" },
                    Answer = "Ransomware"
                };

                var q4 = new Question
                {
                    QuestionTitle = "What does a virus do to a computer?",
                    Options = new List<string> { "Spreads and damages files or system", "Makes it run faster", "Protects it from hackers", "Allows the computer to access the internet" },
                    Answer = "Spreads and damages files or system"
                };

                var q5 = new Question
                {
                    QuestionTitle = "What does Ransomware do to the computer?",
                    Options = new List<string> { "Helps to update windows", "Program that locks your files and waits until you pay money", "Makes the internet faster", "Fake emails" },
                    Answer = "Program that locks your files and waits until you pay money"
                };

                var q6 = new Question
                {
                    QuestionTitle = "What is spyware?",
                    Options = new List<string> { "Software that fixes your computer", "Video call software", "App that blocks pop-ups", "Software that secretly collets your data" },
                    Answer = "Software that secretly collets your data"
                };

                var q7 = new Question
                {
                    QuestionTitle = "What is DDoS?",
                    Options = new List<string> { "System update", "Method to store data", "An attack that overwhelms the servers, making them have really bad performance", "A way to connect to the cloud" },
                    Answer = "An attack that overwhelms the servers, making them have really bad performance"
                };

                var q8 = new Question
                {
                    QuestionTitle = "Which of these is not a malware type",
                    Options = new List<string> { "Virus", "Firewall", "Worm", "Ransomware" },
                    Answer = "Firewall"
                };

                Questions.AddRange(new List<Question> { q1, q2, q3, q4, q5, q6, q7, q8 });
            }

            else if (QuizId == "internetsafety")
            {
                var q1 = new Question
                {
                    QuestionTitle = "Why is it important to check for https and the secure lock on a website?",
                    Options = new List<string> { "It means website has passwords", "Means the site will be fast", "It means that the site is secure and data is encrypted", "The site will load faster" },
                    Answer = "It means that the site is secure and data is encrypted"
                };

                var q2 = new Question
                {
                    QuestionTitle = "What should you do before clicking on a link in an email or message",
                    Options = new List<string> { "Click and check what it is", "Send it to your coworker", "Check who sent it and if it looks suspicious", "Save it on the computer" },
                    Answer = "Check who sent it and if it looks suspicious"
                };

                var q3 = new Question
                {
                    QuestionTitle = "What is the best way to keep your online accounts secure",
                    Options = new List<string> { "Use strong, unique passwords and enable 2FA", "Use your birthday as a password", "Use the same password everywhere", "Share your password with your friends" },
                    Answer = "Use strong, unique passwords and enable 2FA"
                };

                var q4 = new Question
                {
                    QuestionTitle = "What should you avoid when using public Wi-Fi?",
                    Options = new List<string> { "Browsing through Social Media", "Checking the Weather", "Watch TikTok", "Logging into your bank or work accounts" },
                    Answer = "Logging into your bank or work accounts"
                };

                var q5 = new Question
                {
                    QuestionTitle = "What if you receive unexpected email asking for personal info, what should you do?",
                    Options = new List<string> { "Delete it or Report it as phishing", "Click on the links provided in the email", "Post it on social media", "Tell your coworker to click on the link, to check it" },
                    Answer = "Delete it or Report it as phishing"
                };

                var q6 = new Question
                {
                    QuestionTitle = "Why you should regularly update your apps and software?",
                    Options = new List<string> { "To make them look nicer", "To fix bugs and patch security issues", "To add more functions", "To tell your friends you have newer version" },
                    Answer = "To fix bugs and patch security issues"
                };

                var q7 = new Question
                {
                    QuestionTitle = "Which of these is a safe online behavior?",
                    Options = new List<string> { "Sharing your passwords with coworkers", "Downloading apps from unknown websites", "Logging out of accounts when finished", "Posting your account details on social media" },
                    Answer = "Logging out of accounts when finished"
                };

                var q8 = new Question
                {
                    QuestionTitle = "What information should you not share on public websites?",
                    Options = new List<string> { "Your favourite color", "Your full name & address", "Your opinion about movies", "What food you like" },
                    Answer = "Your full name & address"
                };

                Questions.AddRange(new List<Question> { q1, q2, q3, q4, q5, q6, q7, q8 });
            }

            else if (QuizId == "protectdata")
            {
                var q1 = new Question
                {
                    QuestionTitle = "What is one example of personal or company data that needs protection?",
                    Options = new List<string> { "Your favorite color", "Lunch orders", "Employee ID numbers", "The office playlist" },
                    Answer = "Employee ID numbers"
                };

                var q2 = new Question
                {
                    QuestionTitle = "What is the best way to share sensitive company files?",
                    Options = new List<string> { "Through personal email", "On a public messaging app", "By printing and handing it out", "Using an approved, secure sharing platform" },
                    Answer = "Using an approved, secure sharing platform"
                };

                var q3 = new Question
                {
                    QuestionTitle = "What should you do before stepping away from your desk?",
                    Options = new List<string> { "Lock your computer screen", "Log out of your email only", "Leave your computer unlocked", "Leave a note for others not to use it" },
                    Answer = "Lock your computer screen"
                };

                var q4 = new Question
                {
                    QuestionTitle = "Why should you avoid using public computers for work?",
                    Options = new List<string> { "They’re too slow", "You might get distracted", "There’s no access to your email", "They may be unsafe and store your login details" },
                    Answer = "They may be unsafe and store your login details"
                };

                var q5 = new Question
                {
                    QuestionTitle = "What is the clean desk policy meant to prevent?",
                    Options = new List<string> { "Unauthorized access to sensitive information", "Dust build-up", "Food stains on paperwork", "Running out of desk space" },
                    Answer = "Unauthorized access to sensitive information"
                };

                var q6 = new Question
                {
                    QuestionTitle = "If you find a USB drive at work, what should you do?",
                    Options = new List<string> { "Plug it in to check what's inside", "Report it to IT or security", "Give it to a coworker", "Use it for extra storage" },
                    Answer = "Report it to IT or security"
                };

                var q7 = new Question
                {
                    QuestionTitle = "When should you dispose of printed documents containing sensitive information?",
                    Options = new List<string> { "At the end of each week", "When your trash bin is full", "After shredding or placing in secure disposal", "Whenever you clean your desk" },
                    Answer = "After shredding or placing in secure disposal"
                };

                var q8 = new Question
                {
                    QuestionTitle = "What should you do if you accidentally send company data to the wrong person?",
                    Options = new List<string> { "Do nothing", "Try to delete the message quietly", "Apologize and move on", "Report the incident immediately to your manager or IT" },
                    Answer = "Report the incident immediately to your manager or IT"
                };

                Questions.AddRange(new List<Question> { q1, q2, q3, q4, q5, q6, q7, q8 });
            }

            else if (QuizId == "phishing")
            {
                var q1 = new Question
                {
                    QuestionTitle = "What is phishing?",
                    Options = new List<string> { "Sending spam to advertise products", "Sending fake messages to trick people into giving personal info", "A type of firewall", "A game you play online" },
                    Answer = "Sending fake messages to trick people into giving personal info"
                };

                var q2 = new Question
                {
                    QuestionTitle = "Which of the following is a sign of a phishing email?",
                    Options = new List<string> { "Correct grammar and spelling", "Personalized greeting", "Urgent message asking you to click a link or download a file", "Sent from your official IT department email" },
                    Answer = "Urgent message asking you to click a link or download a file"
                };

                var q3 = new Question
                {
                    QuestionTitle = "What is social engineering?",
                    Options = new List<string> { "Using code to hack a computer", "A way to boost teamwork", "A social media campaign", "Manipulating people to reveal confidential information" },
                    Answer = "Manipulating people to reveal confidential information"
                };

                var q4 = new Question
                {
                    QuestionTitle = "If you receive a suspicious email from your \"boss\" asking for gift cards, what should you do?",
                    Options = new List<string> { "Check the sender's email address and report it", "Buy the gift cards quickly", "Respond and ask which kind they want", "Ignore it and delete it" },
                    Answer = "Check the sender's email address and report it"
                };

                var q5 = new Question
                {
                    QuestionTitle = "What should you do if someone calls claiming to be from IT and asks for your password?",
                    Options = new List<string> { "Give them your password if they sound trustworthy", "Ask them to send an email instead", "Hang up and report the call to your real IT department", "Share only part of your password" },
                    Answer = "Hang up and report the call to your real IT department"
                };

                var q6 = new Question
                {
                    QuestionTitle = "Why do phishing attacks often create a sense of urgency?",
                    Options = new List<string> { "To scare victims into responding without thinking", "To follow IT procedures", "To help employees act quickly", "To make the message more interesting" },
                    Answer = "To scare victims into responding without thinking"
                };

                var q7 = new Question
                {
                    QuestionTitle = "Which of the following is the safest action when you receive a suspicious message with a link?",
                    Options = new List<string> { "Click the link to see where it goes", "Forward it to your friends", "Report it to the IT Departament", "Reply to the sender for clarification" },
                    Answer = "Report it to the IT Departament"
                };

                var q8 = new Question
                {
                    QuestionTitle = "What is the best defense against social engineering?",
                    Options = new List<string> { "Ignoring all emails from coworkers", "Being skeptical and verifying requests before acting", "Being friendly to unknown callers", "Using social media frequently" },
                    Answer = "Being skeptical and verifying requests before acting"
                };

                Questions.AddRange(new List<Question> { q1, q2, q3, q4, q5, q6, q7, q8 });
            }

            else if (QuizId == "safeuse")
            {
                var q1 = new Question
                {
                    QuestionTitle = "What is the most secure way to access your work device?",
                    Options = new List<string> { "Share login credentials with your team", "Use multi-factor authentication (MFA)", "Always stay logged in", "Write your password on a sticky note" },
                    Answer = "Use multi-factor authentication (MFA)"
                };

                var q2 = new Question
                {
                    QuestionTitle = "Which of the following is a good practice for handling sensitive work data?",
                    Options = new List<string> { "Email it to your personal account for convenience", "Save it on a public shared drive", "Encrypt files before sending them", "Leave your screen unlocked when leaving your desk" },
                    Answer = "Encrypt files before sending them"
                };

                var q3 = new Question
                {
                    QuestionTitle = "What should you do if you receive a suspicious email on your work device?",
                    Options = new List<string> { "Open it to see what it says", "Forward it to your friends", "Click all the links to test for viruses", "Report it to IT immediately" },
                    Answer = "Report it to IT immediately"
                };

                var q4 = new Question
                {
                    QuestionTitle = "Which of the following is considered unsafe behavior when using work devices?",
                    Options = new List<string> { "Updating software regularly", "Installing unauthorized apps", "Locking your screen when away", "Using secure passwords" },
                    Answer = "Installing unauthorized apps"
                };

                var q5 = new Question
                {
                    QuestionTitle = "What is the safest way to store passwords for your work accounts?",
                    Options = new List<string> { "On a piece of paper in your drawer", "In a secure password manager", "Memorize only one password and use it for all accounts", "In a plain text file on your desktop" },
                    Answer = "In a secure password manager"
                };

                var q6 = new Question
                {
                    QuestionTitle = "Why is it important to lock your computer when stepping away from your desk?",
                    Options = new List<string> { "To save electricity", "To make it boot faster late", "To protect sensitive information from unauthorized access", "To avoid pop-up ads" },
                    Answer = "To protect sensitive information from unauthorized access"
                };

                var q7 = new Question
                {
                    QuestionTitle = "What should you do before connecting your work device to a public Wi-Fi network?",
                    Options = new List<string> { "Ensure your VPN is active", "Turn off antivirus software", "Disable firewalls", "Download games to pass the time" },
                    Answer = "Ensure your VPN is active"
                };

                var q8 = new Question
                {
                    QuestionTitle = "Which of the following actions can help prevent data loss on work devices?",
                    Options = new List<string> { "Only using the device for entertainment", "Regularly backing up important files", "Avoiding software updates", "Disabling security alerts" },
                    Answer = "Regularly backing up important files"
                };
                Questions.AddRange(new List<Question> { q1, q2, q3, q4, q5, q6, q7, q8 });
            }
            else if (QuizId == "reporting")
            {
                var q1 = new Question
                {
                    QuestionTitle = "What is the first step when you notice a potential security incident?",
                    Options = new List<string> { "Try to fix it yourself", "Ignore it unless it happens again", "Report it immediately to the IT", "Ask your coworker what to do" },
                    Answer = "Report it immediately to the IT"
                };

                var q2 = new Question
                {
                    QuestionTitle = "Which of the following is considered a security incident?",
                    Options = new List<string> { "A system running slowly due to updates", "A coworker forgetting their password", "Unauthorized access to sensitive data", "Receiving a calendar invite" },
                    Answer = "Unauthorized access to sensitive data"
                };

                var q3 = new Question
                {
                    QuestionTitle = "Who should you report a security incident to?",
                    Options = new List<string> { "Your social media followers", "The IT or Security team", "Your friends at lunch", "The office janitor" },
                    Answer = "The IT or Security team"
                };

                var q4 = new Question
                {
                    QuestionTitle = "What is the main reason for reporting a security incident quickly?",
                    Options = new List<string> { "To avoid doing your regular work", "To blame someone else", "To limit damage and start mitigation steps", "To test the response process" },
                    Answer = "To limit damage and start mitigation steps"
                };

                var q5 = new Question
                {
                    QuestionTitle = "What information should you include in a security incident report?",
                    Options = new List<string> { "The exact time, details, and how you noticed the incident", "Only your personal opinion", "Gossip about who might be responsible", "Nothing, just say something happened" },
                    Answer = "The exact time, details, and how you noticed the incident"
                };

                var q6 = new Question
                {
                    QuestionTitle = "What should you do if you’re unsure whether something is a security incident?",
                    Options = new List<string> { "Wait until you're sure", "Don’t report it", "Post about it on a forum", "Report it just in case" },
                    Answer = "Report it just in case"
                };

                var q7 = new Question
                {
                    QuestionTitle = "When is it acceptable to investigate a potential incident on your own?",
                    Options = new List<string> { "When you’re curious", "If you're sure it's minor", "Always", "Only if authorized by security personnel" },
                    Answer = "Only if authorized by security personnel"
                };

                var q8 = new Question
                {
                    QuestionTitle = "Which of the following is NOT a proper channel for reporting a security incident?",
                    Options = new List<string> { "Internal incident reporting system", "Directly contacting the security team", "Using a secure company reporting form", "Posting it in public channel" },
                    Answer = "Posting it in public channel"
                };
                Questions.AddRange(new List<Question> { q1, q2, q3, q4, q5, q6, q7, q8 });
            }
            else if (QuizId == "fileshare")
            {
                var q1 = new Question
                {
                    QuestionTitle = "What is the safest method for sharing confidential files with a colleague?",
                    Options = new List<string> { "Sending via personal email", "Uploading to a public cloud folder", "Using a secure company-approved file sharing platform", "Printing and mailing the document" },
                    Answer = "Using a secure company-approved file sharing platform"
                };

                var q2 = new Question
                {
                    QuestionTitle = "What is one risk of using unauthorized cloud services?",
                    Options = new List<string> { "Data leaks and non-compliance with policies", "Faster download speeds", "Unlimited storage", "Improved collaboration" },
                    Answer = "Data leaks and non-compliance with policies"
                };

                var q3 = new Question
                {
                    QuestionTitle = "What should you always do before uploading sensitive files to the cloud?",
                    Options = new List<string> { "Compress the files", "Rename them with emojis", "Check the weather", "Encrypt or password-protect them" },
                    Answer = "Encrypt or password-protect them"
                };

                var q4 = new Question
                {
                    QuestionTitle = "When sharing a cloud document, which setting is the most secure?",
                    Options = new List<string> { "Anyone with the link can edit", "Only specific people can view or edit", "Public on the web", "Share with your personal email" },
                    Answer = "Only specific people can view or edit"
                };

                var q5 = new Question
                {
                    QuestionTitle = "What is a red flag when receiving a file-sharing link from someone?",
                    Options = new List<string> { "It’s shared through the official platform", "The sender is someone you know", "The link leads to a site asking for your login info", "The file is in PDF forma" },
                    Answer = "The link leads to a site asking for your login info"
                };

                var q6 = new Question
                {
                    QuestionTitle = "Why is it important to regularly review shared cloud documents?",
                    Options = new List<string> { "To remove access for people who no longer need it", "To make sure everyone is still reading them", "To organize them by size", "To count how many times it's been opene" },
                    Answer = "To remove access for people who no longer need it"
                };

                var q7 = new Question
                {
                    QuestionTitle = "What should you do if you accidentally share a sensitive file with the wrong person?",
                    Options = new List<string> { "Delete the file silently", " Ignore it unless they mention it", "Blame the cloud service", "Revoke access and notify your IT/security team immediately" },
                    Answer = "Revoke access and notify your IT/security team immediately"
                };

                var q8 = new Question
                {
                    QuestionTitle = "Which of the following practices enhances cloud file security?",
                    Options = new List<string> { "Saving all passwords in a notes file", "Sharing files via social media", "Using strong access controls and regular auditst", "Keeping files indefinitely, regardless of need" },
                    Answer = "Using strong access controls and regular audits"
                };
                Questions.AddRange(new List<Question> { q1, q2, q3, q4, q5, q6, q7, q8 });
            }
            else if (QuizId == "deleting")
            {
                var q1 = new Question
                {
                    QuestionTitle = "What is the most secure way to delete sensitive files from a computer?",
                    Options = new List<string> { "Use data-wiping software or secure erase tools", "Use the \"Delete\" key on your keyboard", "Move them to the Recycle Bin", "Rename the files" },
                    Answer = "Use data-wiping software or secure erase tools"
                };

                var q2 = new Question
                {
                    QuestionTitle = "What should you do before disposing of an old company phone or laptop?",
                    Options = new List<string> { "Nothing", "Factory reset the device and inform IT", " Throw it away in a trash bin", "Give it to a friend" },
                    Answer = "Factory reset the device and inform IT"
                };

                var q3 = new Question
                {
                    QuestionTitle = "Why is simply deleting files not enough to protect sensitive data?",
                    Options = new List<string> { "Because it takes too long", "Because files can still be recovered from the disk", "Because it makes the device run slower", "Because deleted files automatically go to the cloud" },
                    Answer = "Because files can still be recovered from the disk"
                };

                var q4 = new Question
                {
                    QuestionTitle = "What is a secure method to physically destroy a storage device?",
                    Options = new List<string> { "Crumpling it with your hands", "Soaking it in water", "Shredding or degaussing it", "Hiding it in a drawer" },
                    Answer = "Shredding or degaussing it"
                };

                var q5 = new Question
                {
                    QuestionTitle = "What is the purpose of device disposal policies in an organization?",
                    Options = new List<string> { "To allow reuse of old passwords", "To control employee device usage", "To create more storage space", "To ensure data is securely removed and devices are responsibly discarded" },
                    Answer = "To ensure data is securely removed and devices are responsibly discarded"
                };

                var q6 = new Question
                {
                    QuestionTitle = "Before donating an old device, what should you do?",
                    Options = new List<string> { "Wipe all personal and sensitive data", "Add a new password", "Include your contact info in case it's lost", "Remove the screen protector" },
                    Answer = "Wipe all personal and sensitive data"
                };

                var q7 = new Question
                {
                    QuestionTitle = "Which of the following should be securely deleted before recycling a printer?",
                    Options = new List<string> { "Ink cartridges", "Print history and stored documents", "Paper tray", "Power cable" },
                    Answer = "Print history and stored documents"
                };

                var q8 = new Question
                {
                    QuestionTitle = "What risk is posed by improperly disposing of devices?",
                    Options = new List<string> { "Printer malfunctions", "Increased electricity bills", "Identity theft or data breaches", "Lower internet speed" },
                    Answer = "Identity theft or data breaches"
                };
                Questions.AddRange(new List<Question> { q1, q2, q3, q4, q5, q6, q7, q8 });
            }
            else if (QuizId == "traveling")
            {
                var q1 = new Question
                {
                    QuestionTitle = "What should you always do before traveling with a work device?",
                    Options = new List<string> { "Share passwords with a colleague", "Install games for offline use", "Backup important data and update security software", "Leave it unlocked for easy access" },
                    Answer = "Backup important data and update security software"
                };

                var q2 = new Question
                {
                    QuestionTitle = "Why is using public Wi-Fi risky when traveling?",
                    Options = new List<string> { "It’s too slow for work", "It doesn’t work with Bluetooth", "It uses more battery", "It may expose your device to malware or hackers" },
                    Answer = "It may expose your device to malware or hackers"
                };

                var q3 = new Question
                {
                    QuestionTitle = "What tool should you use to safely access work resources over public networks?",
                    Options = new List<string> { "Public DNS settings", "Virtual Private Network (VPN)", "Incognito browser mode", "Social media login" },
                    Answer = "Virtual Private Network (VPN)"
                };

                var q4 = new Question
                {
                    QuestionTitle = "How can you prevent \"shoulder surfing\" in public places?",
                    Options = new List<string> { "Use a privacy screen filter", "Turn off the screen", "Hold the laptop above your head", "Wear sunglasses" },
                    Answer = "Use a privacy screen filter"
                };

                var q5 = new Question
                {
                    QuestionTitle = "What’s a best practice for storing devices in a hotel room?",
                    Options = new List<string> { "Leave them on the bed", "Place them near the window", "Hide them under the pillow", "Lock them in the room safe or carry them with you" },
                    Answer = "test"
                };

                var q6 = new Question
                {
                    QuestionTitle = "What is the safest way to charge your device while traveling?",
                    Options = new List<string> { "Use a public USB charging station", "Use your own charger plugged into a power outlet", "Use any available cable", "Charge it through a stranger’s laptop" },
                    Answer = "Use your own charger plugged into a power outlet"
                };

                var q7 = new Question
                {
                    QuestionTitle = "What should you do if your device is lost or stolen while traveling?",
                    Options = new List<string> { "Immediately report it to IT/security and remotely wipe it if possible", "Ask social media for help", "Try to replace it from a local store", "Wait until you return to report it" },
                    Answer = "Immediately report it to IT/security and remotely wipe it if possible"
                };

                var q8 = new Question
                {
                    QuestionTitle = "What kind of data should you avoid accessing while on unsecured networks?",
                    Options = new List<string> { "Public websites", "Social media", "Weather updates", "Sensitive work documents or emails" },
                    Answer = "Sensitive work documents or emails"
                };
                Questions.AddRange(new List<Question> { q1, q2, q3, q4, q5, q6, q7, q8 });
            }
        }
    }
}
