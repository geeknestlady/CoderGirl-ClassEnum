using ClassEnum;
using Xunit;
using System;

namespace Test
{
    public class ProgramTest
    {
        [Fact]
        public void Test_CourseSubject_Contains_WorldHistory()
        {
            string[] enumNames = Enum.GetNames(typeof(CourseSubject));

            Assert.Contains(enumNames, name => name == "WorldHistory");
        }

        [Fact]
        public void Test_CourseSubject_Contains_Geography()
        {
            string[] enumNames = Enum.GetNames(typeof(CourseSCourseSubject));

            Assert.Contains(enumNames, name => name == "Geography");
        }

        [Fact]
        public void Test_CourseSubject_Contains_AtLeastEightSubjects()
        {
            string[] enumNames = Enum.GetNames(typeof(CourseSubject));

            Assert.True(enumNames.Length > 7);
        }
    }
}
