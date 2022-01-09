
namespace FacultyProject.Views
{
    partial class DisciplineForm
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
            this.disciplineNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.disciplineName = new System.Windows.Forms.TextBox();
            this.chooseTeacher = new System.Windows.Forms.ComboBox();
            this.creditHours = new System.Windows.Forms.TextBox();
            this.addNewDiscipline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // disciplineNameLabel
            // 
            this.disciplineNameLabel.AutoSize = true;
            this.disciplineNameLabel.Location = new System.Drawing.Point(236, 116);
            this.disciplineNameLabel.Name = "disciplineNameLabel";
            this.disciplineNameLabel.Size = new System.Drawing.Size(49, 20);
            this.disciplineNameLabel.TabIndex = 15;
            this.disciplineNameLabel.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Teacher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Credit hours";
            // 
            // disciplineName
            // 
            this.disciplineName.Location = new System.Drawing.Point(320, 109);
            this.disciplineName.Name = "disciplineName";
            this.disciplineName.Size = new System.Drawing.Size(125, 27);
            this.disciplineName.TabIndex = 18;
            // 
            // chooseTeacher
            // 
            this.chooseTeacher.FormattingEnabled = true;
            this.chooseTeacher.Location = new System.Drawing.Point(320, 152);
            this.chooseTeacher.Name = "chooseTeacher";
            this.chooseTeacher.Size = new System.Drawing.Size(177, 28);
            this.chooseTeacher.TabIndex = 20;
            this.chooseTeacher.SelectedIndexChanged += new System.EventHandler(this.chooseTeacher_SelectedIndexChanged);
            // 
            // creditHours
            // 
            this.creditHours.Location = new System.Drawing.Point(320, 198);
            this.creditHours.Name = "creditHours";
            this.creditHours.Size = new System.Drawing.Size(125, 27);
            this.creditHours.TabIndex = 21;
            // 
            // addNewDiscipline
            // 
            this.addNewDiscipline.Location = new System.Drawing.Point(320, 246);
            this.addNewDiscipline.Name = "addNewDiscipline";
            this.addNewDiscipline.Size = new System.Drawing.Size(125, 35);
            this.addNewDiscipline.TabIndex = 22;
            this.addNewDiscipline.Text = "Add discipline";
            this.addNewDiscipline.UseVisualStyleBackColor = true;
            this.addNewDiscipline.Click += new System.EventHandler(this.addNewDiscipline_Click);
            // 
            // DisciplineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addNewDiscipline);
            this.Controls.Add(this.creditHours);
            this.Controls.Add(this.chooseTeacher);
            this.Controls.Add(this.disciplineName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.disciplineNameLabel);
            this.Name = "DisciplineForm";
            this.Text = "DisciplineForm";
            this.Load += new System.EventHandler(this.DisciplineForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label disciplineNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox disciplineName;
        private System.Windows.Forms.ComboBox chooseTeacher;
        private System.Windows.Forms.TextBox creditHours;
        private System.Windows.Forms.Button addNewDiscipline;
    }
}