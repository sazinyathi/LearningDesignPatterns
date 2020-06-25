using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.OOP.Encapsulation
{
    /*
     Encapsulations is wrap together the data and methods that operates
     on data with one unit or class
         */
    public class Student
    {
        // We do not want to change a student Id 
        private string _studentNumber;
        public Student(string studentNumber)
        {
            this._studentNumber = studentNumber;
        }
        public string StudentNumber 
        { 
            get { return this._studentNumber; }
            set { 
             if(string.IsNullOrEmpty(value))
                new Exception("Student name cannot be nulll");
                this._studentNumber = value;
            }
        }
        public void SetStudent(string studenNumber)
        {
            if (string.IsNullOrEmpty(studenNumber))
                new Exception("Student name cannot be nulll");
            this._studentNumber = studenNumber;
        }

        public string GetStudent()
        {
            return _studentNumber;
        }
    }
}
