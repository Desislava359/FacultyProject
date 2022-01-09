
namespace FacultyProject
{
    partial class InformationForm
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
            this.showButton = new System.Windows.Forms.Button();
            this.choosenDisciplinesButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.creditHoursButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.teacherButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataInformation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "List with teachers and students:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choosen disciplines:";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(242, 5);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(94, 29);
            this.showButton.TabIndex = 5;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // choosenDisciplinesButton
            // 
            this.choosenDisciplinesButton.Location = new System.Drawing.Point(175, 55);
            this.choosenDisciplinesButton.Name = "choosenDisciplinesButton";
            this.choosenDisciplinesButton.Size = new System.Drawing.Size(94, 29);
            this.choosenDisciplinesButton.TabIndex = 6;
            this.choosenDisciplinesButton.Text = "Show";
            this.choosenDisciplinesButton.UseVisualStyleBackColor = true;
            this.choosenDisciplinesButton.Click += new System.EventHandler(this.choosenDisciplinesButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Credit hours:";
            // 
            // creditHoursButton
            // 
            this.creditHoursButton.Location = new System.Drawing.Point(110, 95);
            this.creditHoursButton.Name = "creditHoursButton";
            this.creditHoursButton.Size = new System.Drawing.Size(94, 29);
            this.creditHoursButton.TabIndex = 8;
            this.creditHoursButton.Text = "Show";
            this.creditHoursButton.UseVisualStyleBackColor = true;
            this.creditHoursButton.Click += new System.EventHandler(this.creditHoursButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "List with teachers, disciplines and students:";
            // 
            // teacherButton
            // 
            this.teacherButton.Location = new System.Drawing.Point(307, 141);
            this.teacherButton.Name = "teacherButton";
            this.teacherButton.Size = new System.Drawing.Size(94, 29);
            this.teacherButton.TabIndex = 10;
            this.teacherButton.Text = "Show";
            this.teacherButton.UseVisualStyleBackColor = true;
            this.teacherButton.Click += new System.EventHandler(this.teacherButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Top three disciplines:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataInformation
            // 
            this.dataInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInformation.Location = new System.Drawing.Point(60, 255);
            this.dataInformation.Name = "dataInformation";
            this.dataInformation.RowHeadersWidth = 51;
            this.dataInformation.RowTemplate.Height = 29;
            this.dataInformation.Size = new System.Drawing.Size(604, 284);
            this.dataInformation.TabIndex = 13;
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.dataInformation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.teacherButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.creditHoursButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.choosenDisciplinesButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InformationForm";
            this.Text = "InformationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button choosenDisciplinesButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button creditHoursButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button teacherButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataInformation;
    }
}