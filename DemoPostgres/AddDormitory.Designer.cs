namespace DemoPostgres
{
    partial class AddDormitory
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
            this.labelAdressDormitory = new System.Windows.Forms.Label();
            this.textBoxAdressDormitory = new System.Windows.Forms.TextBox();
            this.labelCountRoomDormitory = new System.Windows.Forms.Label();
            this.textBoxCountRoomDormitory = new System.Windows.Forms.TextBox();
            this.labelConditionDormitory = new System.Windows.Forms.Label();
            this.textBoxConditionDormitory = new System.Windows.Forms.TextBox();
            this.labelTypeDormitory = new System.Windows.Forms.Label();
            this.comboBoxTypeDormitory = new System.Windows.Forms.ComboBox();
            this.labelPayDormitory = new System.Windows.Forms.Label();
            this.textBoxPay = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAdressDormitory
            // 
            this.labelAdressDormitory.AutoSize = true;
            this.labelAdressDormitory.Location = new System.Drawing.Point(9, 9);
            this.labelAdressDormitory.Name = "labelAdressDormitory";
            this.labelAdressDormitory.Size = new System.Drawing.Size(99, 13);
            this.labelAdressDormitory.TabIndex = 0;
            this.labelAdressDormitory.Text = "Адрес общежития";
            // 
            // textBoxAdressDormitory
            // 
            this.textBoxAdressDormitory.Location = new System.Drawing.Point(12, 25);
            this.textBoxAdressDormitory.MaxLength = 175;
            this.textBoxAdressDormitory.Name = "textBoxAdressDormitory";
            this.textBoxAdressDormitory.Size = new System.Drawing.Size(460, 20);
            this.textBoxAdressDormitory.TabIndex = 1;
            // 
            // labelCountRoomDormitory
            // 
            this.labelCountRoomDormitory.AutoSize = true;
            this.labelCountRoomDormitory.Location = new System.Drawing.Point(9, 49);
            this.labelCountRoomDormitory.Name = "labelCountRoomDormitory";
            this.labelCountRoomDormitory.Size = new System.Drawing.Size(106, 13);
            this.labelCountRoomDormitory.TabIndex = 2;
            this.labelCountRoomDormitory.Text = "Количество комнат";
            // 
            // textBoxCountRoomDormitory
            // 
            this.textBoxCountRoomDormitory.Location = new System.Drawing.Point(12, 65);
            this.textBoxCountRoomDormitory.Name = "textBoxCountRoomDormitory";
            this.textBoxCountRoomDormitory.Size = new System.Drawing.Size(460, 20);
            this.textBoxCountRoomDormitory.TabIndex = 3;
            // 
            // labelConditionDormitory
            // 
            this.labelConditionDormitory.AutoSize = true;
            this.labelConditionDormitory.Location = new System.Drawing.Point(9, 88);
            this.labelConditionDormitory.Name = "labelConditionDormitory";
            this.labelConditionDormitory.Size = new System.Drawing.Size(51, 13);
            this.labelConditionDormitory.TabIndex = 4;
            this.labelConditionDormitory.Text = "Условия";
            // 
            // textBoxConditionDormitory
            // 
            this.textBoxConditionDormitory.Location = new System.Drawing.Point(12, 105);
            this.textBoxConditionDormitory.MaxLength = 300;
            this.textBoxConditionDormitory.Name = "textBoxConditionDormitory";
            this.textBoxConditionDormitory.Size = new System.Drawing.Size(460, 20);
            this.textBoxConditionDormitory.TabIndex = 5;
            // 
            // labelTypeDormitory
            // 
            this.labelTypeDormitory.AutoSize = true;
            this.labelTypeDormitory.Location = new System.Drawing.Point(12, 132);
            this.labelTypeDormitory.Name = "labelTypeDormitory";
            this.labelTypeDormitory.Size = new System.Drawing.Size(87, 13);
            this.labelTypeDormitory.TabIndex = 6;
            this.labelTypeDormitory.Text = "Тип общежития";
            // 
            // comboBoxTypeDormitory
            // 
            this.comboBoxTypeDormitory.DisplayMember = "0";
            this.comboBoxTypeDormitory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeDormitory.FormattingEnabled = true;
            this.comboBoxTypeDormitory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxTypeDormitory.Location = new System.Drawing.Point(12, 149);
            this.comboBoxTypeDormitory.Name = "comboBoxTypeDormitory";
            this.comboBoxTypeDormitory.Size = new System.Drawing.Size(460, 21);
            this.comboBoxTypeDormitory.TabIndex = 7;
            // 
            // labelPayDormitory
            // 
            this.labelPayDormitory.AutoSize = true;
            this.labelPayDormitory.Location = new System.Drawing.Point(12, 177);
            this.labelPayDormitory.Name = "labelPayDormitory";
            this.labelPayDormitory.Size = new System.Drawing.Size(102, 13);
            this.labelPayDormitory.TabIndex = 8;
            this.labelPayDormitory.Text = "Стоимость комнат";
            // 
            // textBoxPay
            // 
            this.textBoxPay.Location = new System.Drawing.Point(12, 194);
            this.textBoxPay.MaxLength = 10;
            this.textBoxPay.Name = "textBoxPay";
            this.textBoxPay.Size = new System.Drawing.Size(460, 20);
            this.textBoxPay.TabIndex = 9;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(15, 426);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 10;
            this.buttonApply.Text = "Потвердить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(96, 426);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddDormitory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.textBoxPay);
            this.Controls.Add(this.labelPayDormitory);
            this.Controls.Add(this.comboBoxTypeDormitory);
            this.Controls.Add(this.labelTypeDormitory);
            this.Controls.Add(this.textBoxConditionDormitory);
            this.Controls.Add(this.labelConditionDormitory);
            this.Controls.Add(this.textBoxCountRoomDormitory);
            this.Controls.Add(this.labelCountRoomDormitory);
            this.Controls.Add(this.textBoxAdressDormitory);
            this.Controls.Add(this.labelAdressDormitory);
            this.Name = "AddDormitory";
            this.Text = "AddDormitory";
            this.Load += new System.EventHandler(this.AddDormitory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdressDormitory;
        private System.Windows.Forms.TextBox textBoxAdressDormitory;
        private System.Windows.Forms.Label labelCountRoomDormitory;
        private System.Windows.Forms.TextBox textBoxCountRoomDormitory;
        private System.Windows.Forms.Label labelConditionDormitory;
        private System.Windows.Forms.TextBox textBoxConditionDormitory;
        private System.Windows.Forms.Label labelTypeDormitory;
        private System.Windows.Forms.ComboBox comboBoxTypeDormitory;
        private System.Windows.Forms.Label labelPayDormitory;
        private System.Windows.Forms.TextBox textBoxPay;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
    }
}