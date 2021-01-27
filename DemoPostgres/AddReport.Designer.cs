namespace DemoPostgres
{
    partial class AddReport
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
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelFire = new System.Windows.Forms.Label();
            this.textBoxFire = new System.Windows.Forms.TextBox();
            this.labelSystem = new System.Windows.Forms.Label();
            this.textBoxSystem = new System.Windows.Forms.TextBox();
            this.labelGeneral = new System.Windows.Forms.Label();
            this.textBoxGeneral = new System.Windows.Forms.TextBox();
            this.labelInspector = new System.Windows.Forms.Label();
            this.comboBoxInspector = new System.Windows.Forms.ComboBox();
            this.labelDormitory = new System.Windows.Forms.Label();
            this.comboBoxDormitory = new System.Windows.Forms.ComboBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер отчёта";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(13, 30);
            this.textBoxNumber.MaxLength = 30;
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(459, 20);
            this.textBoxNumber.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(13, 58);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(69, 13);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Дата отчёта";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(13, 74);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 3;
            // 
            // labelFire
            // 
            this.labelFire.AutoSize = true;
            this.labelFire.Location = new System.Drawing.Point(13, 97);
            this.labelFire.Name = "labelFire";
            this.labelFire.Size = new System.Drawing.Size(157, 13);
            this.labelFire.TabIndex = 4;
            this.labelFire.Text = "Оценка пожаробезопасности";
            // 
            // textBoxFire
            // 
            this.textBoxFire.Location = new System.Drawing.Point(13, 114);
            this.textBoxFire.MaxLength = 200;
            this.textBoxFire.Name = "textBoxFire";
            this.textBoxFire.Size = new System.Drawing.Size(459, 20);
            this.textBoxFire.TabIndex = 5;
            // 
            // labelSystem
            // 
            this.labelSystem.AutoSize = true;
            this.labelSystem.Location = new System.Drawing.Point(13, 142);
            this.labelSystem.Name = "labelSystem";
            this.labelSystem.Size = new System.Drawing.Size(141, 13);
            this.labelSystem.TabIndex = 6;
            this.labelSystem.Text = "Оценка состояния систем";
            // 
            // textBoxSystem
            // 
            this.textBoxSystem.Location = new System.Drawing.Point(13, 158);
            this.textBoxSystem.MaxLength = 200;
            this.textBoxSystem.Name = "textBoxSystem";
            this.textBoxSystem.Size = new System.Drawing.Size(459, 20);
            this.textBoxSystem.TabIndex = 7;
            // 
            // labelGeneral
            // 
            this.labelGeneral.AutoSize = true;
            this.labelGeneral.Location = new System.Drawing.Point(13, 186);
            this.labelGeneral.Name = "labelGeneral";
            this.labelGeneral.Size = new System.Drawing.Size(130, 13);
            this.labelGeneral.TabIndex = 8;
            this.labelGeneral.Text = "Оценка состояния дома";
            // 
            // textBoxGeneral
            // 
            this.textBoxGeneral.Location = new System.Drawing.Point(13, 202);
            this.textBoxGeneral.MaxLength = 200;
            this.textBoxGeneral.Name = "textBoxGeneral";
            this.textBoxGeneral.Size = new System.Drawing.Size(459, 20);
            this.textBoxGeneral.TabIndex = 9;
            // 
            // labelInspector
            // 
            this.labelInspector.AutoSize = true;
            this.labelInspector.Location = new System.Drawing.Point(13, 225);
            this.labelInspector.Name = "labelInspector";
            this.labelInspector.Size = new System.Drawing.Size(62, 13);
            this.labelInspector.TabIndex = 10;
            this.labelInspector.Text = "Инспектор";
            // 
            // comboBoxInspector
            // 
            this.comboBoxInspector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInspector.FormattingEnabled = true;
            this.comboBoxInspector.Location = new System.Drawing.Point(13, 242);
            this.comboBoxInspector.Name = "comboBoxInspector";
            this.comboBoxInspector.Size = new System.Drawing.Size(459, 21);
            this.comboBoxInspector.TabIndex = 11;
            // 
            // labelDormitory
            // 
            this.labelDormitory.AutoSize = true;
            this.labelDormitory.Location = new System.Drawing.Point(16, 270);
            this.labelDormitory.Name = "labelDormitory";
            this.labelDormitory.Size = new System.Drawing.Size(67, 13);
            this.labelDormitory.TabIndex = 12;
            this.labelDormitory.Text = "Общежитие";
            // 
            // comboBoxDormitory
            // 
            this.comboBoxDormitory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDormitory.FormattingEnabled = true;
            this.comboBoxDormitory.Location = new System.Drawing.Point(13, 287);
            this.comboBoxDormitory.Name = "comboBoxDormitory";
            this.comboBoxDormitory.Size = new System.Drawing.Size(459, 21);
            this.comboBoxDormitory.TabIndex = 13;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(13, 426);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 14;
            this.buttonApply.Text = "Потвердить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(95, 426);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.comboBoxDormitory);
            this.Controls.Add(this.labelDormitory);
            this.Controls.Add(this.comboBoxInspector);
            this.Controls.Add(this.labelInspector);
            this.Controls.Add(this.textBoxGeneral);
            this.Controls.Add(this.labelGeneral);
            this.Controls.Add(this.textBoxSystem);
            this.Controls.Add(this.labelSystem);
            this.Controls.Add(this.textBoxFire);
            this.Controls.Add(this.labelFire);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label1);
            this.Name = "AddReport";
            this.Text = "AddReport";
            this.Load += new System.EventHandler(this.AddReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelFire;
        private System.Windows.Forms.TextBox textBoxFire;
        private System.Windows.Forms.Label labelSystem;
        private System.Windows.Forms.TextBox textBoxSystem;
        private System.Windows.Forms.Label labelGeneral;
        private System.Windows.Forms.TextBox textBoxGeneral;
        private System.Windows.Forms.Label labelInspector;
        private System.Windows.Forms.ComboBox comboBoxInspector;
        private System.Windows.Forms.Label labelDormitory;
        private System.Windows.Forms.ComboBox comboBoxDormitory;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
    }
}