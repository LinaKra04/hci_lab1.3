
namespace hci_lab1._3
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
            this.yes = new System.Windows.Forms.Button();
            this.abort = new System.Windows.Forms.Button();
            this.fileOpen = new System.Windows.Forms.Button();
            this.customDialog = new System.Windows.Forms.Button();
            this.whichOption = new System.Windows.Forms.Button();
            this.exit_ = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dialogResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yes
            // 
            this.yes.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.yes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.yes.Location = new System.Drawing.Point(216, 37);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(214, 49);
            this.yes.TabIndex = 0;
            this.yes.Text = "Yes, No, Cancel";
            this.yes.UseVisualStyleBackColor = false;
            this.yes.Click += new System.EventHandler(this.button1_Click);
            // 
            // abort
            // 
            this.abort.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.abort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.abort.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.abort.Location = new System.Drawing.Point(644, 37);
            this.abort.Name = "abort";
            this.abort.Size = new System.Drawing.Size(214, 49);
            this.abort.TabIndex = 1;
            this.abort.Text = "Abort, Retry, Ignore";
            this.abort.UseVisualStyleBackColor = false;
            this.abort.Click += new System.EventHandler(this.abort_Click);
            // 
            // fileOpen
            // 
            this.fileOpen.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.fileOpen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileOpen.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fileOpen.Location = new System.Drawing.Point(429, 159);
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.Size = new System.Drawing.Size(214, 49);
            this.fileOpen.TabIndex = 2;
            this.fileOpen.Text = "File Open";
            this.fileOpen.UseVisualStyleBackColor = false;
            this.fileOpen.Click += new System.EventHandler(this.button3_Click);
            // 
            // customDialog
            // 
            this.customDialog.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.customDialog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customDialog.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.customDialog.Location = new System.Drawing.Point(216, 258);
            this.customDialog.Name = "customDialog";
            this.customDialog.Size = new System.Drawing.Size(214, 49);
            this.customDialog.TabIndex = 3;
            this.customDialog.Text = "Custom Dialog";
            this.customDialog.UseVisualStyleBackColor = false;
            this.customDialog.Click += new System.EventHandler(this.customDialog_Click);
            // 
            // whichOption
            // 
            this.whichOption.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.whichOption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whichOption.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.whichOption.Location = new System.Drawing.Point(644, 258);
            this.whichOption.Name = "whichOption";
            this.whichOption.Size = new System.Drawing.Size(214, 49);
            this.whichOption.TabIndex = 4;
            this.whichOption.Text = "Which Option";
            this.whichOption.UseVisualStyleBackColor = false;
            this.whichOption.Click += new System.EventHandler(this.whichOption_Click);
            // 
            // exit_
            // 
            this.exit_.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.exit_.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exit_.Location = new System.Drawing.Point(429, 503);
            this.exit_.Name = "exit_";
            this.exit_.Size = new System.Drawing.Size(214, 49);
            this.exit_.TabIndex = 5;
            this.exit_.Text = "Exit";
            this.exit_.UseVisualStyleBackColor = false;
            this.exit_.Click += new System.EventHandler(this.exit__Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Honeydew;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(485, 395);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 34);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dialogResult
            // 
            this.dialogResult.AutoSize = true;
            this.dialogResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dialogResult.Location = new System.Drawing.Point(322, 395);
            this.dialogResult.Name = "dialogResult";
            this.dialogResult.Size = new System.Drawing.Size(127, 28);
            this.dialogResult.TabIndex = 7;
            this.dialogResult.Text = "Dialog Result";
            this.dialogResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1089, 637);
            this.Controls.Add(this.dialogResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exit_);
            this.Controls.Add(this.whichOption);
            this.Controls.Add(this.customDialog);
            this.Controls.Add(this.fileOpen);
            this.Controls.Add(this.abort);
            this.Controls.Add(this.yes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Button abort;
        private System.Windows.Forms.Button fileOpen;
        private System.Windows.Forms.Button customDialog;
        private System.Windows.Forms.Button whichOption;
        private System.Windows.Forms.Button exit_;
        private System.Windows.Forms.Label dialogResult;
        public System.Windows.Forms.TextBox textBox1;
    }
}

