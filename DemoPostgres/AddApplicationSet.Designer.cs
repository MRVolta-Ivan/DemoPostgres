
namespace DemoPostgres
{
    partial class AddApplicationSet
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
            this.labelNumberPhone = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.maskedTextBoxNumberPhone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumberApplication = new System.Windows.Forms.TextBox();
            this.labelNumberApplication = new System.Windows.Forms.Label();
            this.labelDateApplication = new System.Windows.Forms.Label();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dateTimePickerDateApplication = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(15, 40);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 13);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "ФИО";
            // 
            // labelNumberPhone
            // 
            this.labelNumberPhone.AutoSize = true;
            this.labelNumberPhone.Location = new System.Drawing.Point(15, 100);
            this.labelNumberPhone.Name = "labelNumberPhone";
            this.labelNumberPhone.Size = new System.Drawing.Size(93, 13);
            this.labelNumberPhone.TabIndex = 1;
            this.labelNumberPhone.Text = "Номер телефона";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(15, 160);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(38, 13);
            this.labelAdress.TabIndex = 2;
            this.labelAdress.Text = "Адрес";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(15, 55);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(250, 20);
            this.textBoxFIO.TabIndex = 3;
            // 
            // maskedTextBoxNumberPhone
            // 
            this.maskedTextBoxNumberPhone.Location = new System.Drawing.Point(15, 115);
            this.maskedTextBoxNumberPhone.Mask = "(999) 000-0000";
            this.maskedTextBoxNumberPhone.Name = "maskedTextBoxNumberPhone";
            this.maskedTextBoxNumberPhone.Size = new System.Drawing.Size(93, 20);
            this.maskedTextBoxNumberPhone.TabIndex = 4;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(15, 175);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(250, 20);
            this.textBoxAdress.TabIndex = 5;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(7, 426);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(101, 23);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.Text = "Подтвердить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Информация о заявителе";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Информация о заявлении";
            // 
            // textBoxNumberApplication
            // 
            this.textBoxNumberApplication.Location = new System.Drawing.Point(353, 55);
            this.textBoxNumberApplication.Name = "textBoxNumberApplication";
            this.textBoxNumberApplication.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumberApplication.TabIndex = 9;
            // 
            // labelNumberApplication
            // 
            this.labelNumberApplication.AutoSize = true;
            this.labelNumberApplication.Location = new System.Drawing.Point(353, 39);
            this.labelNumberApplication.Name = "labelNumberApplication";
            this.labelNumberApplication.Size = new System.Drawing.Size(98, 13);
            this.labelNumberApplication.TabIndex = 10;
            this.labelNumberApplication.Text = "Номер завяления";
            // 
            // labelDateApplication
            // 
            this.labelDateApplication.AutoSize = true;
            this.labelDateApplication.Location = new System.Drawing.Point(356, 100);
            this.labelDateApplication.Name = "labelDateApplication";
            this.labelDateApplication.Size = new System.Drawing.Size(90, 13);
            this.labelDateApplication.TabIndex = 11;
            this.labelDateApplication.Text = "Дата заявления";
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Location = new System.Drawing.Point(359, 159);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(60, 13);
            this.labelEmployee.TabIndex = 13;
            this.labelEmployee.Text = "Сотрудник";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(353, 174);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(200, 21);
            this.comboBoxEmployee.TabIndex = 14;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(497, 426);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dateTimePickerDateApplication
            // 
            this.dateTimePickerDateApplication.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateApplication.Location = new System.Drawing.Point(353, 116);
            this.dateTimePickerDateApplication.Name = "dateTimePickerDateApplication";
            this.dateTimePickerDateApplication.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateApplication.TabIndex = 16;
            // 
            // AddApplicationSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.dateTimePickerDateApplication);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.labelDateApplication);
            this.Controls.Add(this.labelNumberApplication);
            this.Controls.Add(this.textBoxNumberApplication);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.maskedTextBoxNumberPhone);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelNumberPhone);
            this.Controls.Add(this.labelFIO);
            this.Name = "AddApplicationSet";
            this.Text = "AddApplicationSet";
            this.Load += new System.EventHandler(this.AddApplicationSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelNumberPhone;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumberPhone;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumberApplication;
        private System.Windows.Forms.Label labelNumberApplication;
        private System.Windows.Forms.Label labelDateApplication;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateApplication;
    }
}