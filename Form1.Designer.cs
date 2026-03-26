namespace cs_inheritance
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRefill = new Button();
            btnGet = new Button();
            txtOut = new RichTextBox();
            txtInfo = new RichTextBox();
            SuspendLayout();
            // 
            // btnRefill
            // 
            btnRefill.Location = new Point(12, 12);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(397, 45);
            btnRefill.TabIndex = 0;
            btnRefill.Text = "Перезаполнить";
            btnRefill.UseVisualStyleBackColor = true;
            btnRefill.Click += btnRefill_Click;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(259, 121);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(150, 125);
            btnGet.TabIndex = 3;
            btnGet.Text = "Взять";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // txtOut
            // 
            txtOut.Location = new Point(12, 121);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(241, 125);
            txtOut.TabIndex = 4;
            txtOut.Text = "";
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(12, 63);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(397, 52);
            txtInfo.TabIndex = 5;
            txtInfo.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(421, 261);
            Controls.Add(txtInfo);
            Controls.Add(txtOut);
            Controls.Add(btnGet);
            Controls.Add(btnRefill);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefill;
        private Button btnGet;
        private RichTextBox txtOut;
        private RichTextBox txtInfo;
    }
}
