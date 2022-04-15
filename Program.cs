using System;
using System.Collections.Generic;

namespace PersonalityQuizAdventure
{
    class Program
    {
        static void Main(string[] args)
        {

            Question Question_D = new Question();


            Question_D.question = "You should check out 'Samurai Champloo'!";

            Question_D.isEnd = true;

            Question Question_E = new Question();


            Question_E.question = "You should check out 'Grand Blue Dreaming'!";

            Question_E.isEnd = true;


            Question Question_B = new Question();

            Question_B.result.Add(Question_D);
            Question_B.result.Add(Question_E);

            Question_B.question = "Do you prefer action or slice of life anime?";

            Question_B.answers.Add("Action");
            Question_B.answers.Add("Slice of Life");
            Question_B.isEnd = false;


            Question Question_F = new Question();


            Question_F.question = "You should check out 'Record of Ragnarok'!";

            Question_F.isEnd = true;


            Question Question_G = new Question();


            Question_G.question = "You should check out 'ZOMBIE 100'!";

            Question_G.isEnd = true;


            Question Question_C = new Question();

            Question_C.result.Add(Question_F);
            Question_C.result.Add(Question_G);

            Question_C.question = "Do you prefer action or slice of life manga?";

            Question_C.answers.Add("Action");
            Question_C.answers.Add("Slice of Life");
            Question_C.isEnd = false;

            Question Question_A = new Question();

            Question_A.result.Add(Question_B);
            Question_A.result.Add(Question_C);

            Question_A.question = "Do you prefer anime or manga?";

            Question_A.answers.Add("Anime");
            Question_A.answers.Add("Manga");
            Question_A.isEnd = false;



            Question Current = Question_A;

            while(Current.isEnd == false)
            {
                int ix = AskQuestion(Current);
                Current = Current.result[ix];
            
            }
            Console.WriteLine(Current.question);
            
        }


        /// <summary>
        /// Given a question for the user to answer, 
        /// displays a question then loops through each answer to display it.
        /// Receive the users response then return the users response.
        /// </summary>
        /// <param name="question">The question to display to the user</param>
        /// <returns>The users response</returns>
        public static int AskQuestion(Question question)
        {


            if (question == null)
            {
                throw new Exception("You cannot pass in a null value.");
            }

            if (question.answers.Count == 0)
            {
                throw new Exception("You cannot pass in a list with 0 elements.");
            }



            Console.WriteLine(question.question);
            int optionNumbers = 1;


            foreach (string answer in question.answers)
            {
                Console.WriteLine($"{optionNumbers}. {answer}");
                optionNumbers = optionNumbers + 1;
            }
            return GetValidAnswer(question.answers);
        }


        /// <summary>
        /// Validates that there is at least 1 possible answer with an 
        /// exception thrown if the list is empty. Display a message asking
        /// the user to select an option otherwise. Store the users response
        /// and validate that the choice is a possible answer. If so returns
        /// the users choice. Otherwise displays an error message.
        /// </summary>
        /// <param name="answers">Answers a list of answers</param>
        /// <returns>The users choice</returns>
        static int GetValidAnswer(List<string> answer)
        {

            int userChoice;

            do
            {
                Console.Write("Select an answer: ");
                string input = Console.ReadLine();
                bool isANumber = int.TryParse(input, out userChoice);

                if (isANumber == false)
                {
                    Console.Error.WriteLine("You did not enter a number.");
                }
                else if (userChoice <= 0 || userChoice > answer.Count)
                {
                    Console.WriteLine("Not a valid choice.");
                }
            }
            while (userChoice <= 0 || userChoice > answer.Count);

            return userChoice - 1;

        }



    }
    class Question
    {

        public string question;
        public List<string> answers = new List<string>();
        public List<Question> result = new List<Question>();
        public bool isEnd;
        public string outcome;
    }
}
