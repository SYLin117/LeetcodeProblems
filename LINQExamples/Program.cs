using System.Security.Cryptography;
using LINQExamples;

var highScores = Student.students
    .Where(s => s.ExamScores[0] > 70)
    .Select(s => new { Name = s.FirstName, Score = s.ExamScores[0] });

int exam = 0; // first exam
int score = 60;
var highScores2 =
    from student in Student.students
    where student.ExamScores[exam] > score
    select new
    {
        Name = student.FirstName,
        Score = student.ExamScores[exam]
    };