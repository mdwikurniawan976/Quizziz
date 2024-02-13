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
    public partial class Form1 : Form
    {
        QuizinAjaEntities db = new QuizinAjaEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == String.Empty)
            {
                MessageBox.Show("Username Tidak Boleh Kosong");
                return;
            }
            if(textBox2.Text == String.Empty) 
            {
                MessageBox.Show("Password Tidak Boleh Kosong");
                return;
            }
            else
            {
                var user = db.User.Where(f=> f.Username == textBox1.Text && f.Password == textBox2.Text).FirstOrDefault();
                if(user != null)
                {
                    UserMainFrm m = new UserMainFrm(user.ID);
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username Atau Password Salah")
                    ; return;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountFrm ac = new CreateAccountFrm();   
            ac.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "mahdi";
            textBox2.Text = "1234";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnterQuizCodeFrm a = new EnterQuizCodeFrm();    
            a.ShowDialog();
            this.Hide();
        }
    }
}
