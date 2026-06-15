using System;
using System.Collections.Generic;

const int PASS_MARK = 50;

// List to store student names
List<string> studentNames = new List<string>();

// List of lists to store grades for each student
// Each student has their own list of grades
List<List<int>> allGrades = new List<List<int>>();

Console.WriteLine("Welcome to the Student Grade Manager");

// Main program loop
while (true)
{
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Add Grade");
    Console.WriteLine("3. Display Results");
    Console.WriteLine("4. Exit");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            AddStudent();
            break;

        case "2":
            AddGrade();
            break;

        case "3":
            DisplayResults();
            break;

        case "4":
            return;

        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}

// Add a new student
 void AddStudent()
{
    string StudentName = Console.ReadLine();

    studentNames.Add(StudentName);

    // Create an empty grades list for the new student
    allGrades.Add(new List<int>());
}

// Add a grade for a specific student
 void AddGrade()
{
    Console.WriteLine("Enter Student Name: ");
    string StudentName = Console.ReadLine();
    int index = studentNames.IndexOf(StudentName);
    if (index == -1)
    {
        Console.WriteLine("Student not found");
        return;
    }

    Console.WriteLine("Enter Grade: ");
    int Grade = int.Parse(Console.ReadLine());

    // Find student index and add grade to their list
    allGrades[studentNames.IndexOf(StudentName)].Add(Grade);
}

// Calculate average of grades
 double CalculateAverage(List<int> grades)
{
    double avg = 0;

    for (int i = 0; i < grades.Count; i++)
    {
        avg += grades[i];
    }

    return avg / grades.Count;
}

// Convert average to letter grade
 string GetLetterGrade(double avg)
{
    if (avg >= 90) return "A";
    else if (avg >= 80) return "B";
    else if (avg >= 70) return "C";
    else if (avg >= 60) return "D";
    else return "F";
}

// Display all students results
 void DisplayResults()
{
    for (int i = 0; i < studentNames.Count; i++)
    {
        Console.WriteLine("Student Name: " + studentNames[i]);

        // Print all grades
        Console.WriteLine("Grades: " + string.Join(", ", allGrades[i]));

        // Calculate and print average
        Console.WriteLine("Average: " + CalculateAverage(allGrades[i]));

        // Print letter grade
        Console.WriteLine("Letter Grade: " + GetLetterGrade(CalculateAverage(allGrades[i])));

        // Check pass or fail
        Console.WriteLine("Pass/Fail: " +
            (CalculateAverage(allGrades[i]) >= PASS_MARK ? "Pass" : "Fail"));
    }
}