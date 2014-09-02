namespace SharpLocker
{
    partial class SetupForm
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
            this.labelIntro = new System.Windows.Forms.Label();
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.buttonNext1 = new System.Windows.Forms.Button();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.buttonView1 = new System.Windows.Forms.Button();
            this.buttonNext2 = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIntro
            // 
            this.labelIntro.AutoSize = true;
            this.labelIntro.Location = new System.Drawing.Point(13, 13);
            this.labelIntro.Name = "labelIntro";
            this.labelIntro.Size = new System.Drawing.Size(49, 13);
            this.labelIntro.TabIndex = 0;
            this.labelIntro.Text = "IntroText";
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Location = new System.Drawing.Point(16, 58);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(248, 20);
            this.textBoxInput1.TabIndex = 1;
            this.textBoxInput1.TextChanged += new System.EventHandler(this.textBoxInput1_TextChanged);
            // 
            // buttonNext1
            // 
            this.buttonNext1.Location = new System.Drawing.Point(16, 85);
            this.buttonNext1.Name = "buttonNext1";
            this.buttonNext1.Size = new System.Drawing.Size(75, 23);
            this.buttonNext1.TabIndex = 2;
            this.buttonNext1.Text = "Next";
            this.buttonNext1.UseVisualStyleBackColor = true;
            this.buttonNext1.Click += new System.EventHandler(this.buttonNext1_Click);
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.Enabled = false;
            this.textBoxInput2.Location = new System.Drawing.Point(16, 131);
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(248, 20);
            this.textBoxInput2.TabIndex = 3;
            // 
            // buttonView1
            // 
            this.buttonView1.Location = new System.Drawing.Point(270, 56);
            this.buttonView1.Name = "buttonView1";
            this.buttonView1.Size = new System.Drawing.Size(38, 23);
            this.buttonView1.TabIndex = 4;
            this.buttonView1.Text = "View";
            this.buttonView1.UseVisualStyleBackColor = true;
            this.buttonView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonView1_MouseDown);
            this.buttonView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonView1_MouseUp);
            // 
            // buttonNext2
            // 
            this.buttonNext2.Location = new System.Drawing.Point(16, 157);
            this.buttonNext2.Name = "buttonNext2";
            this.buttonNext2.Size = new System.Drawing.Size(75, 23);
            this.buttonNext2.TabIndex = 5;
            this.buttonNext2.Text = "Confirm!";
            this.buttonNext2.UseVisualStyleBackColor = true;
            this.buttonNext2.Click += new System.EventHandler(this.buttonNext2_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(97, 157);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Confirm:";
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 203);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonNext2);
            this.Controls.Add(this.buttonView1);
            this.Controls.Add(this.textBoxInput2);
            this.Controls.Add(this.buttonNext1);
            this.Controls.Add(this.textBoxInput1);
            this.Controls.Add(this.labelIntro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIntro;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.Button buttonNext1;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.Button buttonView1;
        private System.Windows.Forms.Button buttonNext2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label1;
    }
}

