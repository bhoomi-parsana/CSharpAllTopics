/*
 Part 1: MedicalBot class
The MedicalBot class should have a constant string variable named BotName with the value "Bob" that represents the name of the medical bot.

It should have a static method called GetBotName() that returns value of "BotName" constant.

The MedicalBot class should also have a method named PrescribeMedication() that takes a Patient object as an argument. The PrescribeMedication() method should determine the medication to prescribe based on the symptoms of the patient.

void PrescribeMedication(Patient patient)

If the patient's symptoms are a headache, prescribe ibuprofen.

If the patient's symptoms are skin rashes, prescribe diphenhydramine.

If the patient's symptoms are dizziness, check if the patient has a medical history of diabetes. If they do, prescribe metformin. Otherwise, prescribe dimenhydrinate.



The PrescribeMedication() method should invoke another local function called GetDosage() to specify dosage of the specified medicine.



string GetDosage(string medicineName)

The GetDosage() method receives he medicine name prescribed by the PrescribeMedication() method and returns corresponding dosage as follows:



If the medicine name is ibuprofen:

If the patient's age is less than 18, then the dosage is 400 mg. Otherwise, the dosage is 800 mg.



If the medicine name is diphenhydramine:

If the patient's age is less than 18, then the dosage is 50 mg. Otherwise, the dosage is 300 mg.



If the medicine name is dimenhydrinate:

If the patient's age is less than 18, then the dosage is 50 mg. Otherwise, the dosage is 400 mg.



If the medicine name is metformin, then the dosage is 500 mg for all patients.
 */

namespace Session6_MedicatBot
{
   
    internal class MedicalBot
    {
        public const string BotName = "Bob";
        public static string GetBotname()
        {
            return MedicalBot.BotName;
        }

        public void  PrescribeMedication(Patient patient)
        {
            if (patient.GetSymptom() == "Headache")
            {
                patient.SetPrescription("ibuprofen " + GetDosage("ibuprofen"));
            }
            else if (patient.GetSymptom() == "Skin rashes")
            {
                patient.SetPrescription("diphenhydramine " + GetDosage("diphenhydramine"));
            }
            else if (patient.GetSymptom() == "Dizziness")
            {
                if (patient.GetMedicalHistory() == "Diabetes")
                {
                    patient.SetPrescription("metformin " + GetDosage("metformin"));
                } else
                {
                    patient.SetPrescription("dimenhydrinate " + GetDosage("dimenhydrinate"));
                }
            }

            string GetDosage(string medicineName)
            {
                if (medicineName == "ibuprofen")
                {
                    if(patient.GetAge() < 18)
                    {
                        return "400 mg";
                    } else
                    {
                        return "800 mg";
                    }
                } else if (medicineName == "diphenhydramine")
                {
                    if (patient.GetAge() < 18)
                    {
                        return "50 mg";
                    }
                    else
                    {
                        return "300 mg";
                    }
                } else if (medicineName == "metformin")
                {
                    
                        return "50 mg";
                    
                }
                else if (medicineName == "dimenhydrinate")
                {
                    if (patient.GetAge() < 18)
                    {
                        return "50 mg";
                    }
                    else
                    {
                        return "400 mg";
                    }
                }
                return "Unknown";
            }
        }
    }
}
