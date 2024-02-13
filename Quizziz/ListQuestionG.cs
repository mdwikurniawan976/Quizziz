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
    public partial class ListQuestionG : UserControl
    {
        public event EventHandler<int> QuestionSelected;

        private int questionNumber;
        private bool isAnswered = false; // Tambahkan variabel untuk menyimpan status jawaban

        public ListQuestionG(Question question, int questionNumber)
        {
            InitializeComponent();
            this.questionNumber = questionNumber;
            button1.Text = questionNumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuestionSelected?.Invoke(this, questionNumber);
        }

        private void ListQuestionG_Load(object sender, EventArgs e)
        {

        }

        public void SetAnswered(bool isAnswered)
        {
            this.isAnswered = isAnswered;
            if (isAnswered)
                button1.BackColor = Color.Green; // Change to the desired color
            else
                button1.BackColor = SystemColors.Control; // Change to the default color
        }

        public bool IsAnswered()
        {
            return isAnswered;
        }
    }


}
