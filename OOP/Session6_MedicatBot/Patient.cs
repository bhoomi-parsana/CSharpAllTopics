using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Session6_MedicatBot
{
    internal class Patient
    {
        private string _name;
        private int _age;
        private string _gender;
        private string _medicalHistory;
        private string _symptomCode;
        private string _prescription;

        public string GetName()
        {
            return _name;   
        }

        public bool SetName(string name, out string errorMessage)
        {
            bool isValid = true;
            // check the name is null or empty
            if (name == null || name.Length == 0)
            {
                isValid = false;
                errorMessage = "Please enter valid name";
                return isValid;
            }
            _name = name;
            errorMessage = "";
            return isValid;
        }

        public int GetAge()
        {
            return _age;
        }
        public bool SetAge(int age, out string errorMessage)
        {
            bool isValid = true;
            if (age < 0)
            {
                isValid = false;
                errorMessage = "Age Can't be in negative";
                return isValid;
            } else if(age >100)
            {
                isValid = false;
                errorMessage = "Patient age can't be greater than 100";
                return isValid;
            }
            _age = age;
            errorMessage = "";
            return isValid;
        }

        public string GetGender()
        {
            return _gender;
        }

        public bool SetGender(string gender, out string errorMessage)
        {
            bool isValid = true;
            if (gender != "Male" && gender != "Female" && gender != "Other" && gender != "male" && gender != "female" && gender != "other")
            {
                isValid = false;
                errorMessage = "Patient gender should be either Male, Female or Other";
                return isValid;
            }
            _gender = gender;
            errorMessage = "";
            return isValid;
        }

        public string GetMedicalHistory()
        {
            return _medicalHistory;
        }

        public void SetMedicalHistory(string medicalHistory)
        {
            _medicalHistory = medicalHistory;
        }
        public string GetSymptom()
        {
            string symptom ="None";
            switch (_symptomCode)
            {
                case "s1":
                    symptom = "Headache";
                    break;
                case "s2":
                    symptom = "Skin rashes";
                    break;
                case "s3":
                    symptom = "Dizziness";
                    break;
                default:
                    symptom = "UnKnown";
                    break;
            }
            return symptom;
        }

        // use symptomCode to determine the symptom based on sympton code.
        public bool SetSymptomCode(string symptomCode, out string errorMessage)
        {
            bool isValid = true;
            // Check if the symptom code is valid
            if (symptomCode != "S1" && symptomCode != "S2" && symptomCode != "S3" && symptomCode != "s1" && symptomCode != "s2" && symptomCode != "s3")
            {
                isValid = false;
                errorMessage = "Symptom Code should either be S1, S2, or S3.";
                return isValid;
            }
            _symptomCode= symptomCode;
            errorMessage = "";
            return isValid;
        }

        public string getPrescription()
        {
            return _prescription;
        }

        public void SetPrescription(string prescription)
        {
            _prescription = prescription;
        }
    }
}
