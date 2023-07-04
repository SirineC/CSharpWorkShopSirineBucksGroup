using Day6Homework;
using System;

Student Sirine = new Student();
Sirine.NameOfStudent = "Sirine";
Sirine.StudyHoursPerWeek = 30;
Sirine.StudyWeeksCompleted = 10;

Graduate Graduated = new Graduate();

Graduated.CalculateGraduateEstimate(Sirine.StudyHoursPerWeek, Sirine.StudyWeeksCompleted, Sirine.NameOfStudent);
Graduated.DisplayGraduateEstimate();
