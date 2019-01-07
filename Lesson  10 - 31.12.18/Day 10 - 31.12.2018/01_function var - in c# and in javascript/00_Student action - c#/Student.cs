using System;


namespace test
{
    // this type defines a function that gets one string parameter and returns void
    delegate void SubjectReaction(string subject);


    class Student
    {
        public string StudentName { get; set; }
        public string Subject { get; set; }
        public SubjectReaction SubjectReactionFunc { get; set; }

        public Student(string studentName, string subject, SubjectReaction subjectReactionFunc)
        {
            StudentName = studentName;
            Subject = subject;
            SubjectReactionFunc = subjectReactionFunc;
        }
    }
}
