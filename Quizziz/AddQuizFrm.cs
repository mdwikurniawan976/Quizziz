using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quizziz
{
    public partial class AddQuizFrm : Form
    {
        QuizinAjaEntities db = new QuizinAjaEntities();
        int id;
        public AddQuizFrm(int id)
        {
            
            InitializeComponent();
            this.id = id;   
        }

        private void AddQuizFrm_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text) ||
            string.IsNullOrWhiteSpace(optA.Text) ||
            string.IsNullOrWhiteSpace(optB.Text) ||
            string.IsNullOrWhiteSpace(optC.Text) ||
            string.IsNullOrWhiteSpace(optD.Text) ||
            (!radioButtonA.Checked && !radioButtonB.Checked &&
             !radioButtonC.Checked && !radioButtonD.Checked))
            {
                MessageBox.Show("Please fill in all question details and select the correct answer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

       
            var newQuestion = new Question
            {
                Question1 = textBox4.Text,
                OptionA = optA.Text,
                OptionB = optB.Text,
                OptionC = optC.Text,
                OptionD = optD.Text,
                CorrectAnswer = GetSelectedAnswer()
            };

           
            bindingSource3.Add(newQuestion);

          
            ClearQuestionFields();
        }
  




        private void ClearQuestionFields()
        {
            textBox4.Clear();
            optA.Clear();
            optB.Clear();
            optC.Clear();
            optD.Clear();
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;
        }

      
        private string GetSelectedAnswer()
        {
            if (radioButtonA.Checked) return "A";
            if (radioButtonB.Checked) return "B";
            if (radioButtonC.Checked) return "C";
            if (radioButtonD.Checked) return "D";
            return null; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DeleteColumn.Index)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newQuiz = new Quiz
            {
                UserID = id,
                Name = textBox1.Text,
                Code = textBox2.Text,
                Description = textBox3.Text,
                CreatedAt = DateTime.Now
            };

            db.Quiz.Add(newQuiz);
            db.SaveChanges();


            foreach (var question in bindingSource3.OfType<Question>())
            {
               
                question.QuizID = newQuiz.ID;

             
                db.Question.Add(question);
            }

          
            db.SaveChanges();
            MessageBox.Show("Quiz Berhasil Disimpan");
            ResetFormFields();
       
          
        }

        private void ResetFormFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

           
            ClearQuestionFields();

         
        }

       
    }
}
