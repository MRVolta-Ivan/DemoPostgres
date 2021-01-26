namespace DemoPostgres
{
    partial class AddOrder
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
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelTypeDocument = new System.Windows.Forms.Label();
            this.comboBoxTypeDocument = new System.Windows.Forms.ComboBox();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.labelDormitory = new System.Windows.Forms.Label();
            this.comboBoxDormitory = new System.Windows.Forms.ComboBox();
            this.labelRoom = new System.Windows.Forms.Label();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.labelApplicant = new System.Windows.Forms.Label();
            this.comboBoxApplicant = new System.Windows.Forms.ComboBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(16, 14);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(98, 13);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Номер документа";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(16, 30);
            this.textBoxNumber.MaxLength = 30;
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(456, 20);
            this.textBoxNumber.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(16, 57);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(90, 13);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Дата документа";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(16, 73);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 3;
            // 
            // labelTypeDocument
            // 
            this.labelTypeDocument.AutoSize = true;
            this.labelTypeDocument.Location = new System.Drawing.Point(16, 101);
            this.labelTypeDocument.Name = "labelTypeDocument";
            this.labelTypeDocument.Size = new System.Drawing.Size(83, 13);
            this.labelTypeDocument.TabIndex = 4;
            this.labelTypeDocument.Text = "Тип документа";
            // 
            // comboBoxTypeDocument
            // 
            this.comboBoxTypeDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeDocument.FormattingEnabled = true;
            this.comboBoxTypeDocument.Location = new System.Drawing.Point(16, 117);
            this.comboBoxTypeDocument.Name = "comboBoxTypeDocument";
            this.comboBoxTypeDocument.Size = new System.Drawing.Size(456, 21);
            this.comboBoxTypeDocument.TabIndex = 5;
            this.comboBoxTypeDocument.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeDocument_SelectedIndexChanged);
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Location = new System.Drawing.Point(16, 141);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(60, 13);
            this.labelEmployee.TabIndex = 6;
            this.labelEmployee.Text = "Сотрудник";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(16, 158);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(456, 21);
            this.comboBoxEmployee.TabIndex = 7;
            // 
            // labelDormitory
            // 
            this.labelDormitory.AutoSize = true;
            this.labelDormitory.Location = new System.Drawing.Point(16, 186);
            this.labelDormitory.Name = "labelDormitory";
            this.labelDormitory.Size = new System.Drawing.Size(67, 13);
            this.labelDormitory.TabIndex = 8;
            this.labelDormitory.Text = "Общежитие";
            // 
            // comboBoxDormitory
            // 
            this.comboBoxDormitory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDormitory.Enabled = false;
            this.comboBoxDormitory.FormattingEnabled = true;
            this.comboBoxDormitory.Location = new System.Drawing.Point(16, 202);
            this.comboBoxDormitory.Name = "comboBoxDormitory";
            this.comboBoxDormitory.Size = new System.Drawing.Size(456, 21);
            this.comboBoxDormitory.TabIndex = 9;
            this.comboBoxDormitory.SelectedIndexChanged += new System.EventHandler(this.comboBoxDormitory_SelectedIndexChanged);
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(16, 226);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(51, 13);
            this.labelRoom.TabIndex = 10;
            this.labelRoom.Text = "Комната";
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoom.Enabled = false;
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(16, 243);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(456, 21);
            this.comboBoxRoom.TabIndex = 11;
            // 
            // labelApplicant
            // 
            this.labelApplicant.AutoSize = true;
            this.labelApplicant.Location = new System.Drawing.Point(16, 267);
            this.labelApplicant.Name = "labelApplicant";
            this.labelApplicant.Size = new System.Drawing.Size(61, 13);
            this.labelApplicant.TabIndex = 12;
            this.labelApplicant.Text = "Заявитель";
            // 
            // comboBoxApplicant
            // 
            this.comboBoxApplicant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxApplicant.Enabled = false;
            this.comboBoxApplicant.FormattingEnabled = true;
            this.comboBoxApplicant.Location = new System.Drawing.Point(16, 284);
            this.comboBoxApplicant.Name = "comboBoxApplicant";
            this.comboBoxApplicant.Size = new System.Drawing.Size(456, 21);
            this.comboBoxApplicant.TabIndex = 13;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(16, 426);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 14;
            this.buttonApply.Text = "Потвердить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(97, 426);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.comboBoxApplicant);
            this.Controls.Add(this.labelApplicant);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.comboBoxDormitory);
            this.Controls.Add(this.labelDormitory);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.comboBoxTypeDocument);
            this.Controls.Add(this.labelTypeDocument);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelTypeDocument;
        private System.Windows.Forms.ComboBox comboBoxTypeDocument;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label labelDormitory;
        private System.Windows.Forms.ComboBox comboBoxDormitory;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label labelApplicant;
        private System.Windows.Forms.ComboBox comboBoxApplicant;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
    }
}