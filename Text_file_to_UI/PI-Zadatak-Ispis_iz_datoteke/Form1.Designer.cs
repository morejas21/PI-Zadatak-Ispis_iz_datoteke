namespace PI_Zadatak_Ispis_iz_datoteke
{
    partial class Form1
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
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelYearOfBirth = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelFaculty = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxYearOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxFaculty = new System.Windows.Forms.TextBox();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(30, 28);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(154, 46);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "Choose File...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(37, 118);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(52, 13);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "Full name";
            this.labelFullName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelYearOfBirth
            // 
            this.labelYearOfBirth.AutoSize = true;
            this.labelYearOfBirth.Location = new System.Drawing.Point(37, 184);
            this.labelYearOfBirth.Name = "labelYearOfBirth";
            this.labelYearOfBirth.Size = new System.Drawing.Size(64, 13);
            this.labelYearOfBirth.TabIndex = 2;
            this.labelYearOfBirth.Text = "Year of birth";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(37, 248);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 3;
            this.labelCity.Text = "City";
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.Location = new System.Drawing.Point(37, 309);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.Size = new System.Drawing.Size(41, 13);
            this.labelFaculty.TabIndex = 4;
            this.labelFaculty.Text = "Faculty";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(37, 372);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(29, 13);
            this.labelRole.TabIndex = 5;
            this.labelRole.Text = "Role";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(147, 115);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(177, 20);
            this.textBoxFullName.TabIndex = 6;
            // 
            // textBoxYearOfBirth
            // 
            this.textBoxYearOfBirth.Location = new System.Drawing.Point(147, 177);
            this.textBoxYearOfBirth.Name = "textBoxYearOfBirth";
            this.textBoxYearOfBirth.Size = new System.Drawing.Size(177, 20);
            this.textBoxYearOfBirth.TabIndex = 7;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(147, 241);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(177, 20);
            this.textBoxCity.TabIndex = 8;
            // 
            // textBoxFaculty
            // 
            this.textBoxFaculty.Location = new System.Drawing.Point(147, 306);
            this.textBoxFaculty.Name = "textBoxFaculty";
            this.textBoxFaculty.Size = new System.Drawing.Size(177, 20);
            this.textBoxFaculty.TabIndex = 9;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(147, 372);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(177, 20);
            this.textBoxRole.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(410, 481);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.textBoxFaculty);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxYearOfBirth);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelFaculty);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelYearOfBirth);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.btnChooseFile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelYearOfBirth;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelFaculty;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxYearOfBirth;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxFaculty;
        private System.Windows.Forms.TextBox textBoxRole;
    }
}

