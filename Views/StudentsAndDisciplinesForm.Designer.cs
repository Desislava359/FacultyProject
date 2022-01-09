
namespace FacultyProject.Views
{
    partial class StudentsAndDisciplinesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chooseStudent = new System.Windows.Forms.ComboBox();
            this.chooseDiscipline = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disciplines:";
            // 
            // chooseStudent
            // 
            this.chooseStudent.FormattingEnabled = true;
            this.chooseStudent.Location = new System.Drawing.Point(166, 100);
            this.chooseStudent.Name = "chooseStudent";
            this.chooseStudent.Size = new System.Drawing.Size(151, 28);
            this.chooseStudent.TabIndex = 2;
            // 
            // chooseDiscipline
            // 
            this.chooseDiscipline.FormattingEnabled = true;
            this.chooseDiscipline.Location = new System.Drawing.Point(514, 100);
            this.chooseDiscipline.Name = "chooseDiscipline";
            this.chooseDiscipline.Size = new System.Drawing.Size(151, 28);
            this.chooseDiscipline.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StudentsAndDisciplinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 278);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chooseDiscipline);
            this.Controls.Add(this.chooseStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentsAndDisciplinesForm";
            this.Text = "StudentsAndDisciplinesForm";
            this.Load += new System.EventHandler(this.StudentsAndDisciplinesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox chooseStudent;
        private System.Windows.Forms.ComboBox chooseDiscipline;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}