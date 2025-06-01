using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8_Constructor_Quiz
{
    internal class Questions
    {
        public string _questionText;
        public string _optionA;
        public string _optionB;
        public string _optionC;
        public string _optionD;
        public char _correctAnswerLetter;
        private static char defaultCorrectAnswerLetter = 'X';

        public Questions()
        {
            _questionText = null;
            _optionA = null;
            _optionB = null;
            _optionC = null;
            _optionD = null;
            _correctAnswerLetter = defaultCorrectAnswerLetter;
        }

        public Questions(string questiontext)
        {
            _questionText = questiontext;
            _optionA = "";
            _optionB = "";
            _optionC = "";
            _optionD = "";
            _correctAnswerLetter = defaultCorrectAnswerLetter;
        }

        public Questions(string questiontext, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter)
        {
            _questionText = questiontext;
            _optionA = optionA;
            _optionB = optionB;
            _optionC = optionC;
            _optionD = optionD;

            if (correctAnswerLetter == 'A' || correctAnswerLetter == 'B' || correctAnswerLetter == 'C' || correctAnswerLetter == 'D') //validating correctAnswerLetter parameter
                _correctAnswerLetter = correctAnswerLetter;
            else
                _correctAnswerLetter = Questions.defaultCorrectAnswerLetter;
        }

        public bool isQuestionCorrectOrNot(Questions questions)
        {
            if(questions == null)
            {
                return false;
            }
            int count = 0;
            if (questions._optionA != null)
            {
                count++;
            }
            if (questions._optionB != null)
            {
                count++;
            }
            if (questions._optionC != null)
            {
                count++;
            }
            if (questions._optionD != null)
            {
                count++;
            } 
            if(count > 2)
            {
                return true;
            } else { return false;  }
        }
    }
}
