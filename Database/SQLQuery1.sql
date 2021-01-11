select IDStudent, Subject.SubjectName, DiligenceScores, MidternScores, EndtermScores, ResultLearning.SemesterScores, Semester from Subject, Scores, ResultLearning

select NameStudent, Address, Email, ResultLearning.Conduct, SemesterScores, Classification from Student, ResultLearning

select Student.NameStudent, Subject.SubjectName, Scores.DiligenceScores, MidternScores, EndtermScores, SubjectMediumScores, ResultLearning.Conduct, Classification from Subject, Student, Scores, ResultLearning where ResultLearning.IDStudent = Student.IDStudent and ResultLearning.IDSubject = Subject.IDSubject and Subject.SubjectName = Scores.SubjectName