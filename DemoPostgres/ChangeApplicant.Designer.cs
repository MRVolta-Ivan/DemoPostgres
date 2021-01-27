namespace DemoPostgres
{
    partial class ChangeApplicant
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
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(13, 13);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 13);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "ФИО";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(13, 30);
            this.textBoxFIO.MaxLength = 50;
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(459, 20);
            this.textBoxFIO.TabIndex = 1;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(13, 58);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(93, 13);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "Номер телефона";
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(13, 74);
            this.maskedTextBoxNumber.Mask = "(999) 000-0000";
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(459, 20);
            this.maskedTextBoxNumber.TabIndex = 3;
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(13, 97);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(38, 13);
            this.labelAdress.TabIndex = 4;
            this.labelAdress.Text = "Адрес";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(13, 114);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(459, 20);
            this.textBoxAdress.TabIndex = 5;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(13, 426);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 6;
            this.buttonApply.Text = "Потвердить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(94, 426);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ChangeApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.maskedTextBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelFIO);
            this.Name = "ChangeApplicant";
            this.Text = "ChangeApplicant";
            this.Load += new System.EventHandler(this.ChangeApplicant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
    }
}