namespace lab_3
{
    partial class FDocData
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
            this.tbDocumentInfo = new System.Windows.Forms.TextBox();
            this.BtnAddDocumentData = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDocumentInfo
            // 
            this.tbDocumentInfo.Location = new System.Drawing.Point(12, 21);
            this.tbDocumentInfo.Multiline = true;
            this.tbDocumentInfo.Name = "tbDocumentInfo";
            this.tbDocumentInfo.ReadOnly = true;
            this.tbDocumentInfo.Size = new System.Drawing.Size(664, 417);
            this.tbDocumentInfo.TabIndex = 0;
            this.tbDocumentInfo.TextChanged += new System.EventHandler(this.tbDocumentInfo_TextChanged);
            // 
            // BtnAddDocumentData
            // 
            this.BtnAddDocumentData.Location = new System.Drawing.Point(697, 21);
            this.BtnAddDocumentData.Name = "BtnAddDocumentData";
            this.BtnAddDocumentData.Size = new System.Drawing.Size(91, 23);
            this.BtnAddDocumentData.TabIndex = 1;
            this.BtnAddDocumentData.Text = "Додати дані";
            this.BtnAddDocumentData.UseVisualStyleBackColor = true;
            this.BtnAddDocumentData.Click += new System.EventHandler(this.BtnAddDocumentData_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(697, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FDocData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.BtnAddDocumentData);
            this.Controls.Add(this.tbDocumentInfo);
            this.MinimizeBox = false;
            this.Name = "FDocData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №3";
            this.Load += new System.EventHandler(this.FDocData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDocumentInfo;
        private System.Windows.Forms.Button BtnAddDocumentData;
        private System.Windows.Forms.Button btnClose;
    }
}

