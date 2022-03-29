using System;
using System.Collections.Generic;
using System.Text;

namespace _29032022task2
{
    internal class Student
    {
        public Student(string fullName,int age,)
        {
            GroupNo = _groupno;
            FullName = fullName;
            Age = age;
        }
        private int _groupno;
        public string FullName { get; set; }
        public int GroupNo { get => this._groupno;
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupno = value;
                }
            }
        public int Age{ get; set; }
        public bool CheckGroupNo(string text)
        {
            if (string.IsNullOrWhiteSpace(text) && char.IsUpper(text[0])))
            {
                for (int i= 1; i <text.Length; i++)
                {
                    char.IsDigit(text[i]);
                }
                return true;
            }
            return false;
        }
        
    }
}
