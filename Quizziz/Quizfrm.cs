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
    public partial class Quizfrm : Form
    {
        QuizinAjaEntities db = new QuizinAjaEntities();
        private Dictionary<int, string> selectedAnswers = new Dictionary<int, string>();

        private List<QuestionUsrCntrl> questionControls;
        private TimeSpan elapsedTime;

        private int tickCount = 0;
        int id;
        Quiz qz;
        private int currentQuestionIndex = 0;
        
        public string Kode { get; set; }
        public Quizfrm(string nama,int id)
        {
            InitializeComponent();
            this.id = id;   
            label1.Text = nama;
            timer1.Start();
        }

        void resflwpn1()
        {
            flowLayoutPanel1.Controls.Clear();

            // Gantilah ini dengan data dari tabel pertanyaan Anda
            List<Question> questions = db.Question
                                            .Where(q => q.QuizID == id)
                                            .ToList();

            for (int i = 0; i < questions.Count; i++)
            {
                // Buat instance dari user control ListQuestionG
                ListQuestionG questionButton = new ListQuestionG(questions[i], i + 1);

                // Tambahkan user control ke flowLayoutPanel1
                flowLayoutPanel1.Controls.Add(questionButton);
            }
        }



        void resflwpn2()
        {
            flowLayoutPanel2.Controls.Clear();

            // Misalkan questionList adalah daftar pertanyaan dari database
            List<Question> questionList = db.Question
                                                .Where(q => q.QuizID == id)
                                                .ToList();

            foreach (var question in questionList)
            {
                string n = label1.Text;
                QuestionUsrCntrl questionUserControl = new QuestionUsrCntrl(id, n);

                questionUserControl.ElapsedTime = elapsedTime;
                // Setel properti pertanyaan dan opsi jawaban di user control
                questionUserControl.QuestionText = question.Question1;
                questionUserControl.OptionA = question.OptionA;
                questionUserControl.OptionB = question.OptionB;
                questionUserControl.OptionC = question.OptionC;
                questionUserControl.OptionD = question.OptionD;

                // Set the visibility based on the current question index
                questionUserControl.Visible = (questionList.IndexOf(question) == currentQuestionIndex);

                questionUserControl.SetPrevButtonVisibility(currentQuestionIndex > 0);
                questionUserControl.NextClicked += QuestionUserControl_NextClicked;
                questionUserControl.PrevClicked += QuestionUserControl_PrevClicked;

                // Set visibility based on whether the question is answered or not
                if (flowLayoutPanel1.Controls[questionList.IndexOf(question)] is ListQuestionG listQuestion)
                {
                    questionUserControl.SetNextButtonVisibility(listQuestion.IsAnswered() || string.IsNullOrEmpty(questionUserControl.GetSelectedOption()));
                }
                else
                {
                    // Default to showing the Next button
                    questionUserControl.SetNextButtonVisibility(true);
                }

                // Set the selected option based on the stored answers
                if (selectedAnswers.ContainsKey(currentQuestionIndex))
                {
                    questionUserControl.SetSelectedOption(selectedAnswers[currentQuestionIndex]);
                }

                questionUserControl.SetFinishButtonVisibility(currentQuestionIndex == questionList.Count - 1);

                // Tambahkan user control ke flowLayoutPanel2
                flowLayoutPanel2.Controls.Add(questionUserControl);
            }
        }



                private void QuestionUserControl_NextClicked(object sender, EventArgs e)
                {
                    if (currentQuestionIndex < flowLayoutPanel2.Controls.Count - 1)
                    {
                        if (flowLayoutPanel2.Controls[currentQuestionIndex] is QuestionUsrCntrl currentQuestionControl)
                        {
                            if (!string.IsNullOrEmpty(currentQuestionControl.GetSelectedOption()))
                            {
                                selectedAnswers[currentQuestionIndex] = currentQuestionControl.GetSelectedOption();

                                // Update ListQuestionG in flowLayoutPanel1 to change its color to green
                                if (flowLayoutPanel1.Controls[currentQuestionIndex] is ListQuestionG listQuestion)
                                {
                                    listQuestion.SetAnswered(true);
                                }
                            }
                        }

                        currentQuestionIndex++;
                        resflwpn2();
                    }
                }





        private void QuestionUserControl_PrevClicked(object sender, EventArgs e)
        {
            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;

                if (flowLayoutPanel2.Controls[currentQuestionIndex] is QuestionUsrCntrl previousQuestionControl)
                {
                    previousQuestionControl.SetSelectedOption(selectedAnswers.ContainsKey(currentQuestionIndex)
                        ? selectedAnswers[currentQuestionIndex]
                        : string.Empty);
                }

                resflwpn2();
            }
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Quizfrm_Load(object sender, EventArgs e)
        {
            questionControls = new List<QuestionUsrCntrl>();
            resflwpn1();
            resflwpn2();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));
        //    tickCount++;
            label2.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }
    }
}
