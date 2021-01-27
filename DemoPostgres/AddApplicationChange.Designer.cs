
namespace DemoPostgres
{
    partial class AddApplicationChange
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
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTypeDocument = new System.Windows.Forms.Label();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.labelApplicant = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxTypeDocument = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.comboBoxApplicant = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(12, 10);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(98, 13);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Номер документа";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 60);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(90, 13);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Дата документа";
            // 
            // labelTypeDocument
            // 
            this.labelTypeDocument.AutoSize = true;
            this.labelTypeDocument.Location = new System.Drawing.Point(12, 110);
            this.labelTypeDocument.Name = "labelTypeDocument";
            this.labelTypeDocument.Size = new System.Drawing.Size(83, 13);
            this.labelTypeDocument.TabIndex = 2;
            this.labelTypeDocument.Text = "Тип документа";
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Location = new System.Drawing.Point(12, 160);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(60, 13);
            this.labelEmployee.TabIndex = 3;
            this.labelEmployee.Text = "Сотрудник";
            // 
            // labelApplicant
            // 
            this.labelApplicant.AutoSize = true;
            this.labelApplicant.Location = new System.Drawing.Point(12, 210);
            this.labelApplicant.Name = "labelApplicant";
            this.labelApplicant.Size = new System.Drawing.Size(61, 13);
            this.labelApplicant.TabIndex = 4;
            this.labelApplicant.Text = "Заявитель";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(12, 426);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(90, 23);
            this.buttonConfirm.TabIndex = 5;
            this.buttonConfirm.Text = "Подтвердить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(397, 426);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 20);
            this.textBox1.TabIndex = 8;
            // 
            // comboBoxTypeDocument
            // 
            this.comboBoxTypeDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeDocument.FormattingEnabled = true;
            this.comboBoxTypeDocument.Location = new System.Drawing.Point(15, 127);
            this.comboBoxTypeDocument.Name = "comboBoxTypeDocument";
            this.comboBoxTypeDocument.Size = new System.Drawing.Size(457, 21);
            this.comboBoxTypeDocument.TabIndex = 9;
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(15, 177);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(457, 21);
            this.comboBoxEmployee.TabIndex = 10;
            // 
            // comboBoxApplicant
            // 
            this.comboBoxApplicant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxApplicant.FormattingEnabled = true;
            this.comboBoxApplicant.Location = new System.Drawing.Point(15, 227);
            this.comboBoxApplicant.Name = "comboBoxApplicant";
            this.comboBoxApplicant.Size = new System.Drawing.Size(457, 21);
            this.comboBoxApplicant.TabIndex = 11;
            // 
            // AddApplicationChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.comboBoxApplicant);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.comboBoxTypeDocument);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelApplicant);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.labelTypeDocument);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNumber);
            this.Name = "AddApplicationChange";
            this.Text = "AddApplicationChange";
            this.Load += new System.EventHandler(this.AddApplicationChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTypeDocument;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Label labelApplicant;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxTypeDocument;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.ComboBox comboBoxApplicant;
    }
}