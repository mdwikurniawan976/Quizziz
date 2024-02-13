namespace Quizziz
{
    partial class AddQuizFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.question1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.optD = new System.Windows.Forms.TextBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.optC = new System.Windows.Forms.TextBox();
            this.optB = new System.Windows.Forms.TextBox();
            this.optA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Quiz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiil in  the detail quiz in below";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quiz Name";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Name", true));
            this.textBox1.Location = new System.Drawing.Point(30, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 22);
            this.textBox1.TabIndex = 3;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Quizziz.Quiz);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Code", true));
            this.textBox2.Location = new System.Drawing.Point(28, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(335, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quiz Code";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Description", true));
            this.textBox3.Location = new System.Drawing.Point(398, 125);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(575, 84);
            this.textBox3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quiz Description";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radioButtonD);
            this.groupBox1.Controls.Add(this.radioButtonC);
            this.groupBox1.Controls.Add(this.radioButtonB);
            this.groupBox1.Controls.Add(this.radioButtonA);
            this.groupBox1.Controls.Add(this.optD);
            this.groupBox1.Controls.Add(this.optC);
            this.groupBox1.Controls.Add(this.optB);
            this.groupBox1.Controls.Add(this.optA);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(21, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 409);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.question1DataGridViewTextBoxColumn,
            this.optionADataGridViewTextBoxColumn,
            this.optionBDataGridViewTextBoxColumn,
            this.optionCDataGridViewTextBoxColumn,
            this.optionDDataGridViewTextBoxColumn,
            this.correctAnswerDataGridViewTextBoxColumn,
            this.DeleteColumn});
            this.dataGridView1.DataSource = this.bindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(19, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(915, 193);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // question1DataGridViewTextBoxColumn
            // 
            this.question1DataGridViewTextBoxColumn.DataPropertyName = "Question1";
            this.question1DataGridViewTextBoxColumn.HeaderText = "Question1";
            this.question1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.question1DataGridViewTextBoxColumn.Name = "question1DataGridViewTextBoxColumn";
            this.question1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // optionADataGridViewTextBoxColumn
            // 
            this.optionADataGridViewTextBoxColumn.DataPropertyName = "OptionA";
            this.optionADataGridViewTextBoxColumn.HeaderText = "OptionA";
            this.optionADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.optionADataGridViewTextBoxColumn.Name = "optionADataGridViewTextBoxColumn";
            this.optionADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // optionBDataGridViewTextBoxColumn
            // 
            this.optionBDataGridViewTextBoxColumn.DataPropertyName = "OptionB";
            this.optionBDataGridViewTextBoxColumn.HeaderText = "OptionB";
            this.optionBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.optionBDataGridViewTextBoxColumn.Name = "optionBDataGridViewTextBoxColumn";
            this.optionBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // optionCDataGridViewTextBoxColumn
            // 
            this.optionCDataGridViewTextBoxColumn.DataPropertyName = "OptionC";
            this.optionCDataGridViewTextBoxColumn.HeaderText = "OptionC";
            this.optionCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.optionCDataGridViewTextBoxColumn.Name = "optionCDataGridViewTextBoxColumn";
            this.optionCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // optionDDataGridViewTextBoxColumn
            // 
            this.optionDDataGridViewTextBoxColumn.DataPropertyName = "OptionD";
            this.optionDDataGridViewTextBoxColumn.HeaderText = "OptionD";
            this.optionDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.optionDDataGridViewTextBoxColumn.Name = "optionDDataGridViewTextBoxColumn";
            this.optionDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correctAnswerDataGridViewTextBoxColumn
            // 
            this.correctAnswerDataGridViewTextBoxColumn.DataPropertyName = "CorrectAnswer";
            this.correctAnswerDataGridViewTextBoxColumn.HeaderText = "CorrectAnswer";
            this.correctAnswerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correctAnswerDataGridViewTextBoxColumn.Name = "correctAnswerDataGridViewTextBoxColumn";
            this.correctAnswerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.MinimumWidth = 6;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataSource = typeof(Quizziz.Question);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Question";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(359, 136);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(17, 16);
            this.radioButtonD.TabIndex = 11;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(359, 109);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(17, 16);
            this.radioButtonC.TabIndex = 10;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(359, 82);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(17, 16);
            this.radioButtonB.TabIndex = 9;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(358, 54);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(17, 16);
            this.radioButtonA.TabIndex = 8;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // optD
            // 
            this.optD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "OptionD", true));
            this.optD.Location = new System.Drawing.Point(386, 135);
            this.optD.Name = "optD";
            this.optD.Size = new System.Drawing.Size(243, 22);
            this.optD.TabIndex = 7;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(Quizziz.Question);
            // 
            // optC
            // 
            this.optC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "OptionC", true));
            this.optC.Location = new System.Drawing.Point(386, 107);
            this.optC.Name = "optC";
            this.optC.Size = new System.Drawing.Size(243, 22);
            this.optC.TabIndex = 6;
            // 
            // optB
            // 
            this.optB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "OptionB", true));
            this.optB.Location = new System.Drawing.Point(386, 79);
            this.optB.Name = "optB";
            this.optB.Size = new System.Drawing.Size(243, 22);
            this.optB.TabIndex = 5;
            // 
            // optA
            // 
            this.optA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "OptionA", true));
            this.optA.Location = new System.Drawing.Point(386, 51);
            this.optA.Name = "optA";
            this.optA.Size = new System.Drawing.Size(243, 22);
            this.optA.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Answer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Question";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "Question1", true));
            this.textBox4.Location = new System.Drawing.Point(19, 51);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(309, 120);
            this.textBox4.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(717, 657);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(849, 657);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 31);
            this.button3.TabIndex = 14;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AddQuizFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 701);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddQuizFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " QuizinAja - Online Quiz Platform";
            this.Load += new System.EventHandler(this.AddQuizFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.TextBox optD;
        private System.Windows.Forms.TextBox optC;
        private System.Windows.Forms.TextBox optB;
        private System.Windows.Forms.TextBox optA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn question1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.BindingSource bindingSource3;
    }
}