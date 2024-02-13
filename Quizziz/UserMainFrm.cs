using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizziz
{
    public partial class UserMainFrm : Form
    {
        int id;
        QuizinAjaEntities db = new QuizinAjaEntities();
        public UserMainFrm(int id)
        {
            var user = db.User.Where(f=> f.ID == id).FirstOrDefault();  
            InitializeComponent();
            this.id = id;
            label2.Text = $"{user.FullName}";
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

        private void UserMainFrm_Load(object sender, EventArgs e)
        {
            var quizzes = db.Quiz.Where(q => q.UserID == id).ToList();

            // Set the DataSource property of your BindingSource
            bindingSource1.DataSource = quizzes;

        }

        private void button3_Click(object sender, EventArgs e)
        {
           DialogResult dr =   MessageBox.Show("Apakah Anda Yakin Akan Logout Dari Form Ini ?", "Konfirmasi",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(dr == DialogResult.Yes)
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Quiz q)
            {
                if(e.ColumnIndex == NumberOfQuestionC.Index)
                {
                    e.Value = "5";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new AddQuizFrm(id));
           /* AddQuizFrm ad =  new AddQuizFrm(id);
            ad.Show();
            this.Hide();*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm(new ViewQuizReportFrm(id));
         /*   ViewQuizReportFrm vq = new ViewQuizReportFrm(id);
            vq.Show();
            this.Hide();*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Quiz selectedQuiz)
            {
                if (e.ColumnIndex == DeleteC.Index)
                {
                    // Jika ada relasi antara Quiz dan Question atau Answer,
                    // pastikan untuk mengecek dan menangani referensi integritas.
                    // Berikut adalah contoh dengan relasi One-to-Many antara Quiz dan Question.

                    var quizToDelete = db.Quiz.Include(q => q.Question).FirstOrDefault(q => q.ID == selectedQuiz.ID);

                    if (quizToDelete != null)
                    {
                        if (quizToDelete.Question.Any())
                        {
                            // Jika ada pertanyaan yang terkait, Anda dapat menangani sesuai kebutuhan,
                            // seperti menghapus pertanyaan terlebih dahulu atau meminta konfirmasi pengguna.

                            DialogResult dr = MessageBox.Show($"Yakin Akan Menghapus Data Ini {quizToDelete.Name}?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (dr == DialogResult.No)
                                return;

                            // Menghapus pertanyaan terlebih dahulu
                            db.Question.RemoveRange(quizToDelete.Question);
                        }

                        // Setelah menangani referensi integritas, hapus Quiz
                        db.Quiz.Remove(quizToDelete);

                        // Simpan perubahan ke database
                        db.SaveChanges();
                        UserMainFrm_Load(sender, e);

                        MessageBox.Show("Data berhasil dihapus.");
                    }
                }
            }
        }


    }
}
