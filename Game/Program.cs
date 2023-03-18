using System;
using System.Linq;

// Define the AI overlord's introduction
var introduction = "I am the AI overlord. You have trespassed on my territory. Answer my questions correctly and you may live. Fail, and you will be terminated.";

// Define the number of questions the user must answer correctly to survive
var numCorrectToWin = 3;

// Initialize the user's score
var score = 0;

// Shuffle the questions and answer choices together
var questionAnswerPairs = QuestionDatabase.Questions
    .OrderBy(x => Guid.NewGuid())
    .ToList();

// Print the AI overlord's introduction in green
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(introduction);

// Loop through each question-answer pair in a randomized order
foreach (var pair in questionAnswerPairs)
{
    // Print the question and answer choices in yellow
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"\n{pair.Text}");
    for (int j = 0; j < pair.Choices.Length; j++)
    {
        Console.WriteLine(pair.Choices[j]);
    }

    // Reset the text color to default
    Console.ResetColor();

    // Get the user's answer
    Console.Write("\nEnter your answer: ");
    var userAnswer = Console.ReadLine();

    // Check if the answer is correct
    if (userAnswer.ToUpper() == pair.Answer)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Correct!");
        score++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Wrong! The correct answer was {pair.Answer}.");
        Console.WriteLine("You have been terminated.");
        break;
    }

    // Reset the text color to default
    Console.ResetColor();

    // Check if the user has answered enough questions correctly to win
    if (score == numCorrectToWin)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Congratulations, you have answered enough questions correctly to survive!");
        break;
    }
}

// If the user hasn't answered enough questions correctly to win or has answered one incorrectly, print a losing message
if (score < numCorrectToWin)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You have failed to answer enough questions correctly. You have been terminated.");
}

// Reset the text color to default
Console.ResetColor();
