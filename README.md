🎓 Student Grade Manager (C# Console App)

A simple console-based student management system built using C#.
This project helps manage students, store their grades, and calculate performance results.

🚀 Features
➕ Add new students
📊 Add grades for each student
📈 Calculate average grade
🏆 Convert average to letter grade (A–F)
✅ Determine Pass / Fail status
🖥️ Display full student report
🧠 How It Works

The system uses:

List<string> → to store student names
List<List<int>> → to store grades for each student
Index matching → each student has their own grades list
⚙️ Program Flow
Program starts and shows menu
User selects an option:
Add Student
Add Grade
Display Results
Exit
Data is stored in memory
Results are calculated dynamically
📌 Menu Options
1. Add Student
2. Add Grade
3. Display Results
4. Exit
🧾 Example Output
Student Name: Ahmed
Grades: 80, 90, 75
Average: 81.67
Letter Grade: B
Pass/Fail: Pass
🧮 Core Logic
📊 Average Calculation
Sum all grades
Divide by number of grades
🏆 Letter Grades
Average	Grade
90+	A
80–89	B
70–79	C
60–69	D
< 60	F
🔑 Key Concepts Used
Variables & Data Types
Lists (List<T>)
Nested Lists
Loops (for, while)
Conditional Statements (if / else)
Switch Case
Methods (Functions)
String Handling
Index Matching Logic
🧱 Project Structure
StudentGradeManager
│
├── Program.cs
│   ├── AddStudent()
│   ├── AddGrade()
│   ├── CalculateAverage()
│   ├── GetLetterGrade()
│   └── DisplayResults()
⚠️ Notes
Data is stored in memory only (no database yet)
Each student is linked to their grades by index
Student name must match exactly when adding grades
🚀 Future Improvements

This project can be upgraded to:

🗄️ Database (SQL Server / MySQL)
🌐 Web App (ASP.NET Core)
🔐 Login System (Authentication)
📡 REST API
🎨 Frontend UI (React / Blazor)
☁️ Cloud Deployment
🛠️ Tech Stack
C#
.NET Console Application
📦 How to Run
git clone https://github.com/HamdySameh55/Student-Grade-Manager.git
cd Student-Grade-Manager
dotnet run
🎯 Learning Outcome

This project teaches how to think like a Software Engineer:

Break problem → Design logic → Build step-by-step → Improve system

