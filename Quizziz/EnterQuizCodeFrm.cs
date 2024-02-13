using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizziz
{
    public partial class EnterQuizCodeFrm : Form
    {
       QuizinAjaEntities db = new QuizinAjaEntities();  
        public EnterQuizCodeFrm()
        {
            InitializeComponent();
        }
        void OpenForm<T>(T form) where T : Form
        {
            form.Show();
            form.FormClosed += formClosed;
            Hide();
        }
        void formClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if((textBox1.Text == string.Empty) || (textBox2.Text == string.Empty))
            {
                MessageBox.Show("Data Tidak Boleh Kosong");
            }
            else
            {
                string kode = textBox1.Text;

                var quiz = db.Quiz.FirstOrDefault(f=> f.Code == kode);   

                if(quiz != null)
                {
                    string nama = textBox2.Text;
                    OpenForm(new Quizfrm(nama, quiz.ID));
                 
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kode Quiz Tidak Valid");
                }
                

            }
        }

        private void EnterQuizCodeFrm_Load(object sender, EventArgs e)
        {
            textBox1.Text = "HIST101";
            textBox2.Text = "Ali";
        }
    }
}
