namespace SharpLocker
{
    partial class ChangePassword
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
            this.textBoxConfirmCurrentPass = new System.Windows.Forms.TextBox();
            this.buttonConfirmCurrentPass = new System.Windows.Forms.Button();
            this.textBoxNewPass1 = new System.Windows.Forms.TextBox();
            this.textBoxNewPass2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Changing Master Password";
            // 
            // textBoxConfirmCurrentPass
            // 
            this.textBoxConfirmCurrentPass.Location = new System.Drawing.Point(12, 71);
            this.textBoxConfirmCurrentPass.Name = "textBoxConfirmCurrentPass";
            this.textBoxConfirmCurrentPass.Size = new System.Drawing.Size(260, 20);
            this.textBoxConfirmCurrentPass.TabIndex = 1;
            // 
            // buttonConfirmCurrentPass
            // 
            this.buttonConfirmCurrentPass.Location = new System.Drawing.Point(99, 97);
            this.buttonConfirmCurrentPass.Name = "buttonConfirmCurrentPass";
            this.buttonConfirmCurrentPass.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmCurrentPass.TabIndex = 2;
            this.buttonConfirmCurrentPass.Text = "Confirm";
            this.buttonConfirmCurrentPass.UseVisualStyleBackColor = true;
            this.buttonConfirmCurrentPass.Click += new System.EventHandler(this.buttonConfirmCurrentPass_Click);
            // 
            // textBoxNewPass1
            // 
            this.textBoxNewPass1.Enabled = false;
            this.textBoxNewPass1.Location = new System.Drawing.Point(12, 158);
            this.textBoxNewPass1.Name = "textBoxNewPass1";
            this.textBoxNewPass1.Size = new System.Drawing.Size(260, 20);
            this.textBoxNewPass1.TabIndex = 3;
            // 
            // textBoxNewPass2
            // 
            this.textBoxNewPass2.Enabled = false;
            this.textBoxNewPass2.Location = new System.Drawing.Point(12, 202);
            this.textBoxNewPass2.Name = "textBoxNewPass2";
            this.textBoxNewPass2.Size = new System.Drawing.Size(260, 20);
            this.textBoxNewPass2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To change, confirm your current one first.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter your new desired password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm:";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(99, 228);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 8;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(180, 228);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(75, 23);
            this.buttonView.TabIndex = 9;
            this.buttonView.Text = "View Text";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonView_MouseDown);
            this.buttonView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonView_MouseUp);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(18, 228);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNewPass2);
            this.Controls.Add(this.textBoxNewPass1);
            this.Controls.Add(this.buttonConfirmCurrentPass);
            this.Controls.Add(this.textBoxConfirmCurrentPass);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConfirmCurrentPass;
        private System.Windows.Forms.Button buttonConfirmCurrentPass;
        private System.Windows.Forms.TextBox textBoxNewPass1;
        private System.Windows.Forms.TextBox textBoxNewPass2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonCancel;
    }
}