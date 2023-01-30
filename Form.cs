using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        public form()
        {
            InitializeComponent();
            classroom = new Classroom("LAB4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.tbName.Text;
            string birthyear = this.tbBirthYear.Text;
            string grade = this.tbGrade.Text;

            int bYear = Int32.Parse(birthyear);
            double gpa = Double.Parse(grade);
            // create object form Person class
            Person person = new Person(name, bYear, gpa);
            this.classroom.addPerson2Class(person);
            //display person
            this.tbTotal.Text = this.classroom.showAllPersoninClass();
            //display total age of class
            this.tbTotal1.Text = this.classroom.showsumageinClass().ToString();
            // display avg Grade 
            this.tbGrade.Text = this.classroom.avggradeinClass().ToString("#.##");

            // display min max GPA
            this.tbMax.Text = this.classroom.Maxgrade().ToString();
            this.tbMin.Text = this.classroom.Mingrade().ToString();

            // display name min max
            this.tbNameMax.Text = this.classroom.shownamemaxGPA().ToString();
            this.tbNameMin.Text = this.classroom.shownameminGPA().ToString();

            // clear 
            this.tbName.Text = "";
            this.tbBirthYear.Text = "";
            this.tbGrade.Text = "";





