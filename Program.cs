using System;

/*
C# program that presents a quiz the right way: using arrays and loops, it will check the format of user input and repeat the question if the format is incorrect. 
After the quiz is complete, it will check the user’s responses against the correct answers and present a score. 
*/

namespace True_or_False_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            string[] questions = new string[] {"Earth is flat",
                                         "Winter in Australia happens from June to August",
                                         "C# is object oriented language"};
            bool[] answers = { false, true, true };
            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning! Number of questions doesn't equal to number of answers.");
            }

            int askingIndex = 0;
            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;
                Console.WriteLine(question);
                Console.WriteLine("True or false?");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);

                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.Write(scoringIndex + 1 + ".");
                Console.WriteLine($"Input: {response} | Answer: {answer}");

                if (response == answer)
                {
                    score += 1;
                }

                scoringIndex++;
            }
            Console.WriteLine($"You got {score} out of 3 correct!");
        }
    }
}
