using System;

namespace ClassEnum
{
    public static class Program
    {
        public static void Main()
        {

            Console.ReadLine();
        }

        public static string GetCourseSubjectName(CourseSubject subject)
        {
            //return the enum subject as a string. IOW, if you pass in CourseSubject.Math, the method should return "Math".

            switch (subject)
            {
                case CourseSubject.Art:
                    return "Art";

                case CourseSubject.Algebra:
                    return "Algebra";

                case CourseSubject.Calculus:
                    return "Calculus";

                case CourseSubject.Typing:
                    return "Typing";

                case CourseSubject.Geography:
                    return "Geography";

                case CourseSubject.WorldHistory:
                    return "World History";

                case CourseSubject.Biology:
                    return "Biology";

                case CourseSubject.Chemistry:
                    return "Chemistry";

                case CourseSubject.Psychology:
                    return "Psychology";

                case CourseSubject.English:
                    return "English";

                default:
                    return null;
            }

        }
    }
    public enum CourseSubject
    {
        Art,
        Algebra,
        Calculus,
        Typing,
        Geography,
        WorldHistory,
        Biology,
        Chemistry,
        Psychology,
        English
    }
    //Create an enum named CourseSubject. 
    //It should contain at least 8 subjects, two of which must be Geography and WorldHistory
}