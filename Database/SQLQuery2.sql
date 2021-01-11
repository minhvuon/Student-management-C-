select distinct ResultLearning.IDStudent, NameStudent, ResultLearning.IDSubject, SubjectName, Subject.NumberCredits, Semester from ResultLearning, Subject, Student where ResultLearning.IDSubject = Subject.IDSubject and ResultLearning.IDStudent = Student.IDStudent and Student.NameStudent = 'Nguyen Minh Vuon'

insert into ResultLearning(IDStudent) select Student.IDStudent from Student, ResultLearning where ResultLearning.IDStudent != Student.IDStudent
insert into ResultLearning(IDStudent) select Student.IDStudent from Student 
insert into ResultLearning(IDStudent, IDSubject) values( '4051050023', 'QNU3') where IDStudent = ''
update ResultLearning set IDStudent = '4051050024', IDSubject = 'QNU4' where IDSubject != 'QNU4'

delete from ResultLearning
SELECT * FROM ResultLearning WHERE IDStudent = '4051050011'