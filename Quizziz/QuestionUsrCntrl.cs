using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Quizziz
{
    public partial class QuestionUsrCntrl : UserControl
    {
        public event EventHandler NextClicked;
        public event EventHandler PrevClicked;
        QuizinAjaEntities db = new QuizinAjaEntities();
        int id;
        private List<QuestionUsrCntrl> questionControls = new List<QuestionUsrCntrl>();
        private TimeSpan elapsedTime;
        private string n; 

        public QuestionUsrCntrl(int id, string n)
        {
            this.id = id;
            this.n = n;            
            InitializeComponent();
            elapsedTime = TimeSpan.Zero; // In
        }
        // Di QuestionUsrCntrl
      

        public TimeSpan ElapsedTime
        {
            get { return elapsedTime; }
            set { elapsedTime = value; }
        }

        public string QuestionText
        {
            get { return lblQuestion.Text; }
            set { lblQuestion.Text = value; }
        }

        // Properti untuk opsi jawaban A
        public string OptionA
        {   
            get { return radioButton1.Text; }
            set { radioButton1.Text = value; }
        }

        // Properti untuk opsi jawaban B
        public string OptionB
        {
            get { return radioButton2.Text; }
            set { radioButton2.Text = value; }
        }

        // Properti untuk opsi jawaban C
        public string OptionC
        {
            get { return radioButton3.Text; }
            set { radioButton3.Text = value; }
        }

        // Properti untuk opsi jawaban D
        public string OptionD
        {
            get { return radioButton4.Text; }
            set { radioButton4.Text = value; }
        }
        public void SetPrevButtonVisibility(bool isVisible)
        {
             btnPrev.Visible = isVisible;
        }

        public void SetNextButtonVisibility(bool isVisible)
        {
            btnNext.Visible = isVisible;
        }

        public void SetFinishButtonVisibility(bool isVisible)
        {
            btnFinish.Visible = isVisible;
        }

        // Metode untuk mendapatkan opsi jawaban yang dipilih
        public string GetSelectedOption()
        {
            if (radioButton1.Checked)
                return "A";
            else if (radioButton2.Checked)
                return "B";
            else if (radioButton3.Checked)
                return "C";
            else if (radioButton4.Checked)
                return "D";
            else
                return string.Empty;
        }

        // Metode untuk membersihkan pilihan jawaban
        public void ClearOptions()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
        public void SetSelectedOption(string selectedOption)
        {
            // Implement the logic to set the selected option in your control
            // For example, you might want to check the selected option and set the corresponding radio button
            if (selectedOption == "A")
                radioButton1.Checked = true;
            else if (selectedOption == "B")
                radioButton2.Checked = true;
            else if (selectedOption == "C")
                radioButton3.Checked = true;
            else if (selectedOption == "D")
                radioButton4.Checked = true;
            else
                ClearOptions(); // Add a method to clear the selected options if needed
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            NextClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            PrevClicked?.Invoke(this, EventArgs.Empty);
        }

        private void QuestionUsrCntrl_Load(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
              
                var participant = new Participant
                {
                    ParticipantNickname = n,
                    QuizID = id,
                    ParticipationDate = DateTime.Now,
                    TimeTaken = (int)elapsedTime.TotalSeconds 
                };

               db.Participant.Add(participant);
                db.SaveChanges();           
                int participantID = participant.ID;
                    List<Question> questions = db.Question
                                                .Where(q => q.QuizID == id)
                                                .ToList();
             
                for (int i = 0; i < questions.Count; i++)
                {
                
                    if (i < questionControls.Count)
                    {
                    
                        var answer = new ParticipantAnswer
                        {
                            ParticipantID = participantID,
                            QuestionID = questions[i].ID,

                            Answer = questionControls[i].GetSelectedOption() 
                        };

                       
                        db.ParticipantAnswer.Add(answer);
                        db.SaveChanges();
                    }
                    else
                    {
                      
                    }
                }
           
              Form1 loginForm = new Form1();
                loginForm.Show();

             
                this.FindForm().Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
               
            }
        }





    }
}
