/*
Week 2 Lab 4
4. Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage. 
(May use a struct / class to represent the student)
Test Data :
Input the Roll Number of the student :784
Input the Name of the Student :James
Input the marks of Physics, Chemistry and Computer Application : 70 80 90
Expected Output :
Roll No : 784
Name of Student : James
Marks in Physics : 70
Marks in Chemistry : 80
Marks in Computer Application : 90
Total Marks = 240
Percentage = 80.00
Division = First

*/
Student ourStudent = new Student(); // new object
Console.Write("Input student roll number: ");
ourStudent.RollNumber = int.Parse(Console.ReadLine());
Console.Write("Input student name: ");
ourStudent.StudentName = Console.ReadLine();
Console.Write("Input the marks of Physics, Chemistry and Computer Application: "); // need to split string on " " character
ourStudent.SetGrades(Console.ReadLine()); //takes string and splits 


//output
Console.WriteLine($"Roll No: {ourStudent.RollNumber}");
Console.WriteLine($"Name of student: {ourStudent.StudentName}");
Console.WriteLine($"Marks in Physics: {ourStudent.PhysicsGrade}");
Console.WriteLine($"Marks in Chemistry: {ourStudent.ChemGrade}");
Console.WriteLine($"Marks in Computer Applications: {ourStudent.ComputerGrade}");
Console.WriteLine($"TotalMarks = {ourStudent.ChemGrade + ourStudent.ComputerGrade + ourStudent.PhysicsGrade}");
Console.WriteLine($"Percentage = {ourStudent.TotalGrade()}");
public class Student()
{
    public string StudentName { get; set; }
    public int RollNumber { get ; set; }
    public double PhysicsGrade { get; set; }
    public double ComputerGrade { get; set; }
    public double ChemGrade { get; set; }

    public double TotalGrade()
    {
        return ( PhysicsGrade + ComputerGrade + ChemGrade )/ 3;
    }

    public void SetGrades(string input) //input "70 80 90" numbers split by " ", takes input and sets it to the individual grades 
    {
        string[] grades = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        PhysicsGrade = double.Parse(grades[0]);
        ChemGrade = double.Parse(grades[1]);
        ComputerGrade = double.Parse(grades[2]);
        
    }

}


