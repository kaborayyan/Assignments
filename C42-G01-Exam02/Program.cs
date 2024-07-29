namespace C42_G01_Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating the Subject
            Console.WriteLine("What is the subject Id?");
            int SubjectId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the subject name?");
            string SubjectName = Console.ReadLine();

            // Asking for the type of exam
            Console.WriteLine("Please enter the type of the exam, (1) for Final and (2) for Practical");
            int TypeOfExam = Convert.ToInt32(Console.ReadLine());
            if (TypeOfExam == 2)
            {
                Console.WriteLine("For Practical Exams, you will enter MCQ questions only.");
                Console.WriteLine("How long will be the exam?");
                int Duration = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many questions will you enter?");

                int ArrayLength = Convert.ToInt32(Console.ReadLine());
                MCQ[] QuestionList = new MCQ[ArrayLength];
                for (int i = 0; i < ArrayLength; i++)
                {
                    Console.WriteLine($"Enter the header of question No {i + 1}");
                    string Header = Console.ReadLine();
                    Console.WriteLine($"Enter the body of question No {i + 1}");
                    string Body = Console.ReadLine();

                    Console.WriteLine("Please enter 4 choices and press enter after each choice");
                    Answer[] Choices = new Answer[4];
                    for (int j = 0; j < 4; j++)
                    {
                        string choice = Console.ReadLine();
                        Choices[j] = new Answer(j + 1, choice);
                    }
                    Console.WriteLine("Please enter the number for correct answer.");
                    int CorrectAnswer = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("How many marks for this question?");
                    int Marks = Convert.ToInt32(Console.ReadLine());

                    // Add the data to the question list
                    QuestionList[i] = new MCQ(Header, Body, Marks, Choices, CorrectAnswer - 1);
                }
                PracticalExam practicalExam = new PracticalExam(Duration, ArrayLength, QuestionList);
                Subject subject = new Subject(SubjectId, SubjectName, practicalExam);
                subject.Exam.ShowExam();
            }

            if (TypeOfExam == 1)
            {
                Console.WriteLine("For Final Exams, you will enter both MCQ and TOF questions.");
                Console.WriteLine("How long will be the exam?");
                int Duration = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How many questions will you enter?");
                int ArrayLength = Convert.ToInt32(Console.ReadLine());
                Question[] QuestionList = new Question[ArrayLength];
                for (int i = 0; i < ArrayLength; i++)
                {
                    Console.Write("Enter 1 for MCQ or 2 for TOF: ");
                    int QType = Convert.ToInt32(Console.ReadLine());
                    
                    // Fixed input for both types
                    Console.WriteLine($"How many marks for question No {i + 1}?");
                    int Marks = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Enter the header of question No {i + 1}");
                    string Header = Console.ReadLine();
                    Console.WriteLine($"Enter the body of question No {i + 1}");
                    string Body = Console.ReadLine();

                    // Different input
                    if (QType == 1)
                    {
                        Console.WriteLine("Please enter 4 choices and press enter after each choice");
                        Answer[] Choices = new Answer[4];
                        for (int j = 0; j < 4; j++)
                        {
                            string choice = Console.ReadLine();
                            Choices[j] = new Answer(j + 1, choice);
                        }
                        Console.WriteLine("Please enter the number for correct answer.");
                        int CorrectAnswer = Convert.ToInt32(Console.ReadLine());


                        // Add the data to the question list
                        QuestionList[i] = new MCQ(Header, Body, Marks, Choices, CorrectAnswer - 1);
                    }
                    if (QType == 2)
                    {
                        Console.WriteLine("Please enter if the question is true or false");
                        bool CorrectAnswer = Convert.ToBoolean(Console.ReadLine());
                        // Add the data to the question list
                        QuestionList[i] = new TrueOrFalse(Header, Body, Marks, CorrectAnswer);
                    }
                }
                FinalExam finalExam = new FinalExam(Duration, ArrayLength, QuestionList);
                Subject subject = new Subject(SubjectId, SubjectName, finalExam);
                subject.Exam.ShowExam();
            }

            #region Testing Classes
            //// Creating TOF Questions
            //TrueOrFalse TOFQuestion01 = new TrueOrFalse("True or False", "This exam is confusing.", 10, true);
            //TrueOrFalse TOFQuestion02 = new TrueOrFalse("True or False", "C# is a beautiful programming language.", 10, true);


            //// Creating choices for MCQ Questions            
            //Answer[] Choices01 = new Answer[4]
            //    {
            //    new Answer(1,"C# 12"),
            //    new Answer(2,"C# 08"),
            //    new Answer(3,"C# 11"),
            //    new Answer(4,"C# 13")
            //};

            //Answer[] Choices02 = new Answer[4]
            //    {
            //    new Answer(1,".NET 4.8"),
            //    new Answer(2,".NET 5.0"),
            //    new Answer(3,".NET 8.0"),
            //    new Answer(4,".NET 6.0")
            //};

            //// Creating MCQ Questions
            //MCQ MCQ01 = new MCQ("Regarding C#", "The most recent update to C# is:", 10, Choices01, 0);
            //MCQ MCQ02 = new MCQ("Regarding .NET", "The most recent update to .NET is:", 10, Choices02, 2);

            //// Questions for the final exam
            //Question[] QuestionsList = {TOFQuestion01, TOFQuestion02, MCQ01, MCQ02};

            //// Creating the Final Exam
            //FinalExam finalExam = new FinalExam(60, 4, QuestionsList);            

            //// Creating Subject
            //Subject CSharp = new Subject(42, "Backend with C#", finalExam);
            //CSharp.Exam.ShowExam(); 
            #endregion

        }
    }
}
