using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quizziz
{
    public partial class ViewQuizReportFrm : Form
    {
        QuizinAjaEntities db = new QuizinAjaEntities();
        int id;
        public ViewQuizReportFrm(int id)
        {
            InitializeComponent();
            this.id = id;   
        }

        private void ViewQuizReportFrm_Load(object sender, EventArgs e)
        {
            var b = db.Quiz.Where(f=> f.UserID == id).ToList();
            bindingSource1.DataSource = b;
               // db.Quiz.Find(id);
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Quiz m)
            {
                bindingSource2.DataSource = m.Participant.ToList();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Participant p)
            {
                if (e.ColumnIndex == timeTakenDataGridViewTextBoxColumn.Index)
                {
                    if (p.TimeTaken is int waktuSebagaiInt)
                    {                 
                        TimeSpan waktuSebagaiTimeSpan = TimeSpan.FromSeconds(waktuSebagaiInt);                       
                        e.Value = $"{(int)waktuSebagaiTimeSpan.TotalHours:D2}:{waktuSebagaiTimeSpan.Minutes:D2}:{waktuSebagaiTimeSpan.Seconds:D2}";
                    }
                    else
                    {                 
                        e.Value = "Format waktu tidak valid";
                    }
                }
                if(e.ColumnIndex == CorrectPercentageColumn.Index)
                {
                   /* if (p.ParticipantAnswer >= 0 && p.Quiz.Question > 0)
                    {
                        // Calculate the correct percentage
                        double correctPercentage = ((double)p.CorrectAnswerCount / p.TotalQuestionsCount) * 100.0;

                        // Display the correct percentage in the desired format
                        e.Value = $"{correctPercentage:F2}%";
                    }
                    else
                    {
                        // Handle the case where ParticipantAnswer or TotalQuestionsCount is invalid
                        e.Value = "Invalid data for percentage calculation";
                    }*/
                }


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
