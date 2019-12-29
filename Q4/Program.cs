using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class student : IComparable<student>
    {
        public string name{ get; set; }
        public string DOB { get; set; }
        public int sem{ get; set; }
        public double GPA { get; set; }
        public student(string Name, String DOB, int sem, double GPA)
        {
            this.name = Name;
            this.DOB = DOB;
            this.GPA = GPA;
            this.sem = sem;
        }

        public int CompareTo( student other)
        {
            return other.GPA.CompareTo(this.GPA);
        }
    }
