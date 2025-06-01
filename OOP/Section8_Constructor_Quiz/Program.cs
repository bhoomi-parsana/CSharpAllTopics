// See https://aka.ms/new-console-template for more information
using Section8_Constructor_Quiz;

Console.WriteLine("Hello, World!");
//implicite object with null and default value;
Questions questions = new Questions();
Questions questionsText = new Questions("Captital of India?");
// paramterrised constructor
Questions questionsTextWithOptionAnswer = new Questions("Captital of India?", "Delhi","Banglore","Varansi","Gandinagar", 'A');
// object initialization example
Questions questionsTextWithOption = new Questions()
{
    _questionText = "Captital of India?",
    _optionA= "Delhi",
    _optionB= "Banglore",
    _optionC= "Varansi",
   // _optionD= "Gandinagar"
};

Console.WriteLine(questionsTextWithOption.isQuestionCorrectOrNot(questionsTextWithOption));
