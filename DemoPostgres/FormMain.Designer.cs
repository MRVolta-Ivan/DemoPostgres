﻿namespace DemoPostgres
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.SystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllApplicantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TenantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DormitoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllDormitoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckDormitoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FreeDormitoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PermissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDormitoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuGridData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьКомнатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.contextMenuGridData.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemToolStripMenuItem,
            this.ApplicantToolStripMenuItem,
            this.DormitoryToolStripMenuItem,
            this.DocsToolStripMenuItem,
            this.AddToolStripMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(984, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // SystemToolStripMenuItem
            // 
            this.SystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem";
            this.SystemToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.SystemToolStripMenuItem.Text = "Система";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ApplicantToolStripMenuItem
            // 
            this.ApplicantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllApplicantToolStripMenuItem,
            this.TenantToolStripMenuItem,
            this.PaymentToolStripMenuItem});
            this.ApplicantToolStripMenuItem.Name = "ApplicantToolStripMenuItem";
            this.ApplicantToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ApplicantToolStripMenuItem.Text = "Заявители";
            // 
            // AllApplicantToolStripMenuItem
            // 
            this.AllApplicantToolStripMenuItem.Name = "AllApplicantToolStripMenuItem";
            this.AllApplicantToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.AllApplicantToolStripMenuItem.Text = "Все";
            this.AllApplicantToolStripMenuItem.Click += new System.EventHandler(this.AllApplicantToolStripMenuItem_Click);
            // 
            // TenantToolStripMenuItem
            // 
            this.TenantToolStripMenuItem.Name = "TenantToolStripMenuItem";
            this.TenantToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.TenantToolStripMenuItem.Text = "Жильцы";
            this.TenantToolStripMenuItem.Click += new System.EventHandler(this.TenantToolStripMenuItem_Click);
            // 
            // PaymentToolStripMenuItem
            // 
            this.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem";
            this.PaymentToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.PaymentToolStripMenuItem.Text = "Ожидает оплаты";
            this.PaymentToolStripMenuItem.Click += new System.EventHandler(this.PaymentToolStripMenuItem_Click);
            // 
            // DormitoryToolStripMenuItem
            // 
            this.DormitoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllDormitoryToolStripMenuItem,
            this.CheckDormitoryToolStripMenuItem1,
            this.FreeDormitoryToolStripMenuItem});
            this.DormitoryToolStripMenuItem.Name = "DormitoryToolStripMenuItem";
            this.DormitoryToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.DormitoryToolStripMenuItem.Text = "Общежития";
            // 
            // AllDormitoryToolStripMenuItem
            // 
            this.AllDormitoryToolStripMenuItem.Name = "AllDormitoryToolStripMenuItem";
            this.AllDormitoryToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.AllDormitoryToolStripMenuItem.Text = "Все";
            this.AllDormitoryToolStripMenuItem.Click += new System.EventHandler(this.AllDormitoryToolStripMenuItem_Click);
            // 
            // CheckDormitoryToolStripMenuItem1
            // 
            this.CheckDormitoryToolStripMenuItem1.Name = "CheckDormitoryToolStripMenuItem1";
            this.CheckDormitoryToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.CheckDormitoryToolStripMenuItem1.Text = "Ожидает проверки";
            this.CheckDormitoryToolStripMenuItem1.Click += new System.EventHandler(this.CheckDormitoryToolStripMenuItem1_Click);
            // 
            // FreeDormitoryToolStripMenuItem
            // 
            this.FreeDormitoryToolStripMenuItem.Name = "FreeDormitoryToolStripMenuItem";
            this.FreeDormitoryToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.FreeDormitoryToolStripMenuItem.Text = "Свободные общежития";
            this.FreeDormitoryToolStripMenuItem.Click += new System.EventHandler(this.FreeDormitoryToolStripMenuItem_Click);
            // 
            // DocsToolStripMenuItem
            // 
            this.DocsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApplicationToolStripMenuItem,
            this.PermissionToolStripMenuItem,
            this.OrderToolStripMenuItem,
            this.ReceiptToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.DocsToolStripMenuItem.Name = "DocsToolStripMenuItem";
            this.DocsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.DocsToolStripMenuItem.Text = "Документы";
            // 
            // ApplicationToolStripMenuItem
            // 
            this.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem";
            this.ApplicationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ApplicationToolStripMenuItem.Text = "Заявления";
            this.ApplicationToolStripMenuItem.Click += new System.EventHandler(this.ApplicationToolStripMenuItem_Click);
            // 
            // PermissionToolStripMenuItem
            // 
            this.PermissionToolStripMenuItem.Name = "PermissionToolStripMenuItem";
            this.PermissionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PermissionToolStripMenuItem.Text = "Разрешения";
            this.PermissionToolStripMenuItem.Click += new System.EventHandler(this.PermissionToolStripMenuItem_Click);
            // 
            // OrderToolStripMenuItem
            // 
            this.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem";
            this.OrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OrderToolStripMenuItem.Text = "Приказы";
            this.OrderToolStripMenuItem.Click += new System.EventHandler(this.OrderToolStripMenuItem_Click);
            // 
            // ReceiptToolStripMenuItem
            // 
            this.ReceiptToolStripMenuItem.Name = "ReceiptToolStripMenuItem";
            this.ReceiptToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ReceiptToolStripMenuItem.Text = "Квитанции";
            this.ReceiptToolStripMenuItem.Click += new System.EventHandler(this.ReceiptToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportToolStripMenuItem.Text = "Отчёты о проверке";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // AddToolStripMenuItem1
            // 
            this.AddToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddApplicationToolStripMenuItem,
            this.AddDormitoryToolStripMenuItem,
            this.AddOrderToolStripMenuItem,
            this.AddReceiptToolStripMenuItem,
            this.AddReportToolStripMenuItem});
            this.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1";
            this.AddToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.AddToolStripMenuItem1.Text = "Добавить";
            // 
            // AddApplicationToolStripMenuItem
            // 
            this.AddApplicationToolStripMenuItem.Name = "AddApplicationToolStripMenuItem";
            this.AddApplicationToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.AddApplicationToolStripMenuItem.Text = "Добавить заявление";
            this.AddApplicationToolStripMenuItem.Click += new System.EventHandler(this.AddApplicationToolStripMenuItem_Click);
            // 
            // AddDormitoryToolStripMenuItem
            // 
            this.AddDormitoryToolStripMenuItem.Name = "AddDormitoryToolStripMenuItem";
            this.AddDormitoryToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.AddDormitoryToolStripMenuItem.Text = "Добавить общежитие";
            this.AddDormitoryToolStripMenuItem.Click += new System.EventHandler(this.AddDormitoryToolStripMenuItem_Click);
            // 
            // AddOrderToolStripMenuItem
            // 
            this.AddOrderToolStripMenuItem.Name = "AddOrderToolStripMenuItem";
            this.AddOrderToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.AddOrderToolStripMenuItem.Text = "Добавить приказ";
            // 
            // AddReceiptToolStripMenuItem
            // 
            this.AddReceiptToolStripMenuItem.Name = "AddReceiptToolStripMenuItem";
            this.AddReceiptToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.AddReceiptToolStripMenuItem.Text = "Добавить квитанцию";
            // 
            // AddReportToolStripMenuItem
            // 
            this.AddReportToolStripMenuItem.Name = "AddReportToolStripMenuItem";
            this.AddReportToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.AddReportToolStripMenuItem.Text = "Добавить отчёт о проверке";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 24);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(984, 537);
            this.dataGrid.TabIndex = 1;
            // 
            // contextMenuGridData
            // 
            this.contextMenuGridData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.показатьКомнатыToolStripMenuItem});
            this.contextMenuGridData.Name = "contextMenuGridData";
            this.contextMenuGridData.Size = new System.Drawing.Size(177, 70);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // показатьКомнатыToolStripMenuItem
            // 
            this.показатьКомнатыToolStripMenuItem.Name = "показатьКомнатыToolStripMenuItem";
            this.показатьКомнатыToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.показатьКомнатыToolStripMenuItem.Text = "Показать комнаты";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.contextMenuGridData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem SystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ApplicantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllApplicantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TenantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DormitoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllDormitoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckDormitoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FreeDormitoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DocsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PermissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReceiptToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuGridData;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьКомнатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AddApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddDormitoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddReportToolStripMenuItem;
    }
}