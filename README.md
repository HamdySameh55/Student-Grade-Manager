# 🎓 Student Grade Manager

A simple console-based student management system built using **C#**.
This project helps manage students, store their grades, and calculate performance results.

---

## 🚀 Features

* ➕ Add new students
* 📊 Add grades for each student
* 📈 Calculate average grade
* 🏆 Convert average to letter grade (A–F)
* ✅ Determine Pass / Fail status
* 🖥️ Display full student report

---

## 🧠 How It Works

The system uses:

* `List<string>` to store student names.
* `List<List<int>>` to store grades for each student.
* Index matching so each student has their own grade list.

---

## ⚙️ Program Flow

1. Start the program.
2. Display the menu.
3. User selects one of the following options:

   * Add Student
   * Add Grade
   * Display Results
   * Exit
4. Store data in memory.
5. Calculate and display results.

---

## 📌 Menu Options

```text
1. Add Student
2. Add Grade
3. Display Results
4. Exit
```

---

## 🧾 Example Output

```text
Student Name: Ahmed
Grades: 80, 90, 75
Average: 81.67
Letter Grade: B
Pass/Fail: Pass
```

---

## 🧮 Letter Grades

| Average  | Grade |
| -------- | ----- |
| 90+      | A     |
| 80 - 89  | B     |
| 70 - 79  | C     |
| 60 - 69  | D     |
| Below 60 | F     |

---

## 🔑 Concepts Used

* Variables & Data Types
* Lists (`List<T>`)
* Nested Lists
* Loops (`for`, `while`)
* Conditional Statements (`if / else`)
* Switch Statements
* Methods (Functions)
* String Handling
* Index Matching Logic

---

## 📂 Project Structure

```text
StudentGradeManager
│
├── Program.cs
│   ├── AddStudent()
│   ├── AddGrade()
│   ├── CalculateAverage()
│   ├── GetLetterGrade()
│   └── DisplayResults()
```

---

## ⚠️ Notes

* Data is stored in memory only.
* No database is used yet.
* Student names must match exactly when adding grades.

---

## 🚀 Future Improvements

* SQL Server / MySQL Integration
* ASP.NET Core Web Application
* REST API
* Authentication & Authorization
* React or Blazor Frontend
* Cloud Deployment

---

## 🛠️ Tech Stack

* C#
* .NET Console Application

---

## 📦 How to Run

```bash
git clone https://github.com/HamdySameh55/Student-Grade-Manager.git

cd Student-Grade-Manager

dotnet run
```

---

## 🎯 Learning Outcome

This project teaches how to think like a Software Engineer:

> Break problems into smaller pieces → Design the logic → Build step by step → Improve over time.

---

## ⭐ Author

**Hamdy Sameh**

Computer Science Student | AI Major
