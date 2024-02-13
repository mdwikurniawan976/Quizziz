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
    public partial class CreateAccountFrm : Form
    {
        QuizinAjaEntities db = new QuizinAjaEntities();
        public CreateAccountFrm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Form1 fm = new Form1();
            fm.Show();
            this.Hide();    
        }

        private bool pw (string password)
        {
            return password.Length > 4;
        }
        private void button1_Click(object sender, EventArgs e)
        {   if((textBox1.Text == string.Empty) || (textBox2.Text == string.Empty) || (dateTimePicker1.Text ==       string.Empty) || (textBox3.Text == string.Empty) || (textBox4.Text == string.Empty))
            {
                MessageBox.Show("Data Tidak Boleh Kosong", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
         else
            {
                if (textBox4.Text != textBox3.Text)
                {
                    MessageBox.Show("Password Tidak Sama", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if((textBox3.Text.Length <4))
                {
                    MessageBox.Show("Password Tidak bisa kurang dari 4 karakter ","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if(db.User.Any(u=> u.Username == textBox1.Text))
                    {
                        MessageBox.Show("Username Sudah Terdaftar coba username yang lain ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    var User = new User
                    {
                       
                        Username = textBox1.Text,
                        FullName = textBox2.Text,
                        DateOfBirth = dateTimePicker1.Value,
                        Password = textBox4.Text
                    };

                    db.User.Add(User);
                    db.SaveChanges();
                    MessageBox.Show("Registrasi Berhasil");
                }
            }
            
          
             
           
            
        }

        private void CreateAccountFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
