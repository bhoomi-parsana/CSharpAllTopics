// See https://aka.ms/new-console-template for more information
// Create a medical bot application that can prescribe medication based on the patient's symptoms and age.
/* Assignment: Create a medical bot application
The application can prescribe medication based on the patient's symptoms and age.
Your task is to create a C# console application that simulates a medical bot named Bob. Bob should be able to prescribe medication based on the symptoms of a patient passed as an argument.

You should create two classes - MedicalBot and Patient - to implement this functionality.
*/
using Session6_MedicatBot;

Patient patient = new Patient();
MedicalBot medicalBot = new MedicalBot();
Console.WriteLine($"Hi, I'm {MedicalBot.GetBotname()}. I'm here to help you in your medication.");
Console.WriteLine("Enter your (patient) details:");
Console.WriteLine("Enter Patient Name:");
while (!patient.SetName(Console.ReadLine(), out string errorMessage))
{
    Console.WriteLine(errorMessage);
    Console.Write("Enter Patient Name:");
}
Console.WriteLine("Enter Patient Age:");
while(!patient.SetAge(Convert.ToInt32(Console.ReadLine()), out string errorMessage))
{
    Console.WriteLine(errorMessage);
    Console.WriteLine("Enter Patient Age:");
}
Console.WriteLine("Enter Patient Gender:");
while (!patient.SetGender(Console.ReadLine(), out string errorMessage))
{
    Console.WriteLine(errorMessage);
    Console.WriteLine("Enter Patient Gender:");
}
Console.WriteLine("Enter Medical History:");
patient.SetMedicalHistory(Console.ReadLine());


Console.WriteLine($"Welcome {patient.GetName()} {patient.GetAge()}");
Console.WriteLine("Which of the following symptoms do you have:");
Console.WriteLine("S1. Headache");
Console.WriteLine("S2. Skin rashes");
Console.WriteLine("S3. Dizziness");
Console.WriteLine("Enter the symptom code from above list (S1, S2 or S3)");
while (!patient.SetSymptomCode(Console.ReadLine(), out string errorMessage))
{
    Console.WriteLine(errorMessage);
    Console.WriteLine("Enter the symptom code from above list (S1, S2 or S3)");
}

medicalBot.PrescribeMedication(patient);
Console.WriteLine("Your prescription based on your age, symptoms and medical history:");
Console.WriteLine(patient.getPrescription());
Console.WriteLine("Thank you for coming.");
Console.ReadKey();


