﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter student's name: ");
        string studentName = Console.ReadLine();

        Console.Write("Enter exam marks: ");
        if (int.TryParse(Console.ReadLine(), out int examMarks))
        {
            if (examMarks < 0 || examMarks > 100)
            {
                Console.WriteLine("Error: Marks should be between 0 and 100.");
            }
            else
            {
                char grade = DetermineGrade(examMarks);

                Console.WriteLine($"{studentName}'s grade is: {grade}");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid input for exam marks. Please enter a valid number.");
        }
    }

    static char DetermineGrade(int marks)
    {
        if (marks >= 75 && marks <= 100)
        {
            return 'A';
        }
        else if (marks >= 60 && marks <= 74)
        {
            return 'B';
        }
        else if (marks >= 50 && marks <= 59)
        {
            return 'C';
        }
        else if (marks >= 40 && marks <= 49)
        {
            return 'D';
        }
        else
        {
            return 'F'; // Failed
        }
    }
}