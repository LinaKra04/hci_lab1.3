
namespace hci_lab1._3
{
    partial class Form2
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mssgEnetr = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.cancel_ = new System.Windows.Forms.Button();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.opt3 = new System.Windows.Forms.RadioButton();
            this.opt4 = new System.Windows.Forms.RadioButton();
            this.selectAnOption = new System.Windows.Forms.GroupBox();
            this.selectAnOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // mssgEnetr
            // 
            this.mssgEnetr.AutoSize = true;
            this.mssgEnetr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mssgEnetr.Location = new System.Drawing.Point(302, 85);
            this.mssgEnetr.Name = "mssgEnetr";
            this.mssgEnetr.Size = new System.Drawing.Size(138, 28);
            this.mssgEnetr.TabIndex = 0;
            this.mssgEnetr.Text = "Message enter";
            this.mssgEnetr.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(511, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 27);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ok.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ok.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ok.Location = new System.Drawing.Point(614, 244);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(145, 53);
            this.ok.TabIndex = 3;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel_
            // 
            this.cancel_.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.cancel_.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel_.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancel_.Location = new System.Drawing.Point(614, 371);
            this.cancel_.Name = "cancel_";
            this.cancel_.Size = new System.Drawing.Size(145, 53);
            this.cancel_.TabIndex = 4;
            this.cancel_.Text = "Cancel";
            this.cancel_.UseVisualStyleBackColor = false;
            this.cancel_.Click += new System.EventHandler(this.cancel__Click);
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opt1.Location = new System.Drawing.Point(28, 50);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(111, 32);
            this.opt1.TabIndex = 5;
            this.opt1.TabStop = true;
            this.opt1.Text = "Option 1";
            this.opt1.UseVisualStyleBackColor = true;
            this.opt1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opt2.Location = new System.Drawing.Point(28, 107);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(111, 32);
            this.opt2.TabIndex = 6;
            this.opt2.TabStop = true;
            this.opt2.Text = "Option 2";
            this.opt2.UseVisualStyleBackColor = true;
            // 
            // opt3
            // 
            this.opt3.AutoSize = true;
            this.opt3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opt3.Location = new System.Drawing.Point(28, 165);
            this.opt3.Name = "opt3";
            this.opt3.Size = new System.Drawing.Size(111, 32);
            this.opt3.TabIndex = 7;
            this.opt3.TabStop = true;
            this.opt3.Text = "Option 3";
            this.opt3.UseVisualStyleBackColor = true;
            // 
            // opt4
            // 
            this.opt4.AutoSize = true;
            this.opt4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opt4.Location = new System.Drawing.Point(28, 225);
            this.opt4.Name = "opt4";
            this.opt4.Size = new System.Drawing.Size(111, 32);
            this.opt4.TabIndex = 8;
            this.opt4.TabStop = true;
            this.opt4.Text = "Option 4";
            this.opt4.UseVisualStyleBackColor = true;
            // 
            // selectAnOption
            // 
            this.selectAnOption.Controls.Add(this.opt4);
            this.selectAnOption.Controls.Add(this.opt3);
            this.selectAnOption.Controls.Add(this.opt2);
            this.selectAnOption.Controls.Add(this.opt1);
            this.selectAnOption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectAnOption.Location = new System.Drawing.Point(251, 183);
            this.selectAnOption.Name = "selectAnOption";
            this.selectAnOption.Size = new System.Drawing.Size(262, 281);
            this.selectAnOption.TabIndex = 9;
            this.selectAnOption.TabStop = false;
            this.selectAnOption.Text = "Select an option";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1082, 643);
            this.Controls.Add(this.selectAnOption);
            this.Controls.Add(this.cancel_);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.mssgEnetr);
            this.Name = "Form2";
            this.Text = "Form2";
            this.selectAnOption.ResumeLayout(false);
            this.selectAnOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label mssgEnetr;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel_;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.RadioButton opt3;
        private System.Windows.Forms.RadioButton opt4;
        private System.Windows.Forms.GroupBox selectAnOption;
        public System.Windows.Forms.TextBox textBox2;
    }
}