namespace MedicalStoreApp
{
    partial class AddClient
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
            this.tbClientPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.btnClientCancel = new System.Windows.Forms.Button();
            this.btnClientAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Name";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number";
            // 
            // tbClientPhone
            // 
            this.tbClientPhone.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientPhone.Location = new System.Drawing.Point(223, 63);
            this.tbClientPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tbClientPhone.Mask = "0000-0000000";
            this.tbClientPhone.Name = "tbClientPhone";
            this.tbClientPhone.PromptChar = '#';
            this.tbClientPhone.Size = new System.Drawing.Size(223, 31);
            this.tbClientPhone.TabIndex = 5;
            // 
            // tbClientName
            // 
            this.tbClientName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientName.Location = new System.Drawing.Point(223, 25);
            this.tbClientName.Margin = new System.Windows.Forms.Padding(4);
            this.tbClientName.Multiline = true;
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(223, 30);
            this.tbClientName.TabIndex = 4;
            // 
            // btnClientCancel
            // 
            this.btnClientCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClientCancel.Location = new System.Drawing.Point(223, 176);
            this.btnClientCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientCancel.Name = "btnClientCancel";
            this.btnClientCancel.Size = new System.Drawing.Size(107, 39);
            this.btnClientCancel.TabIndex = 7;
            this.btnClientCancel.Text = "Cancle";
            this.btnClientCancel.UseVisualStyleBackColor = true;
            this.btnClientCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClientAdd
            // 
            this.btnClientAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClientAdd.Location = new System.Drawing.Point(340, 176);
            this.btnClientAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientAdd.Name = "btnClientAdd";
            this.btnClientAdd.Size = new System.Drawing.Size(107, 39);
            this.btnClientAdd.TabIndex = 8;
            this.btnClientAdd.Text = "Add/Save";
            this.btnClientAdd.UseVisualStyleBackColor = true;
            this.btnClientAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(457, 231);
            this.Controls.Add(this.btnClientAdd);
            this.Controls.Add(this.btnClientCancel);
            this.Controls.Add(this.tbClientName);
            this.Controls.Add(this.tbClientPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientpanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tbClientPhone;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Button btnClientCancel;
        private System.Windows.Forms.Button btnClientAdd;
    }
}