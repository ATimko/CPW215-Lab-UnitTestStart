using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        /// <summary>
        /// InstuctorN = InstructorName
        /// CN = CourseName
        /// NumOfCredits = Number of Credits
        /// </summary>
        private string InstuctorN;
        private string CN;
        private byte NumOfCredits;

        public Course(string courseName)
        {
            InstructorName = "STAFF";
            CourseName = courseName;
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName
        {
            get
            {
                return InstuctorN;
            }
            set
            {
                InstuctorN = value;
            }
        }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName
        {
            get
            {
                return CN;
            }
            set
            {
                if (value != null)
                {
                    CN = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits
        {
            get
            {
                return NumOfCredits;
            }
            set
            {
                if (value < 30 && value > 0)
                {
                    NumOfCredits = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }

        }
    }
}
