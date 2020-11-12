namespace Starcraft2Workaround
{
    partial class MainForm
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
            this.GamePathLable = new System.Windows.Forms.Label();
            this.GamePath = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.x64RadioButton = new System.Windows.Forms.RadioButton();
            this.x32RadioButton = new System.Windows.Forms.RadioButton();
            this.CloseAfterStartup = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // GamePathLable
            // 
            this.GamePathLable.AutoSize = true;
            this.GamePathLable.Location = new System.Drawing.Point(12, 9);
            this.GamePathLable.Name = "GamePathLable";
            this.GamePathLable.Size = new System.Drawing.Size(193, 13);
            this.GamePathLable.TabIndex = 0;
            this.GamePathLable.Text = "Game path (containing StarCraft II.exe):";
            // 
            // GamePath
            // 
            this.GamePath.Location = new System.Drawing.Point(15, 26);
            this.GamePath.Name = "GamePath";
            this.GamePath.Size = new System.Drawing.Size(378, 20);
            this.GamePath.TabIndex = 1;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(15, 76);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(378, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // x64RadioButton
            // 
            this.x64RadioButton.AutoSize = true;
            this.x64RadioButton.Checked = true;
            this.x64RadioButton.Location = new System.Drawing.Point(15, 53);
            this.x64RadioButton.Name = "x64RadioButton";
            this.x64RadioButton.Size = new System.Drawing.Size(51, 17);
            this.x64RadioButton.TabIndex = 3;
            this.x64RadioButton.TabStop = true;
            this.x64RadioButton.Text = "64 bit";
            this.x64RadioButton.UseVisualStyleBackColor = true;
            // 
            // x32RadioButton
            // 
            this.x32RadioButton.AutoSize = true;
            this.x32RadioButton.Location = new System.Drawing.Point(73, 53);
            this.x32RadioButton.Name = "x32RadioButton";
            this.x32RadioButton.Size = new System.Drawing.Size(51, 17);
            this.x32RadioButton.TabIndex = 4;
            this.x32RadioButton.Text = "32 bit";
            this.x32RadioButton.UseVisualStyleBackColor = true;
            // 
            // CloseAfterStartup
            // 
            this.CloseAfterStartup.AutoSize = true;
            this.CloseAfterStartup.Checked = true;
            this.CloseAfterStartup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CloseAfterStartup.Location = new System.Drawing.Point(224, 53);
            this.CloseAfterStartup.Name = "CloseAfterStartup";
            this.CloseAfterStartup.Size = new System.Drawing.Size(169, 17);
            this.CloseAfterStartup.TabIndex = 5;
            this.CloseAfterStartup.Text = "Close this window after startup";
            this.CloseAfterStartup.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 112);
            this.Controls.Add(this.CloseAfterStartup);
            this.Controls.Add(this.x32RadioButton);
            this.Controls.Add(this.x64RadioButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.GamePath);
            this.Controls.Add(this.GamePathLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Starcraft II Start Workaround";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GamePathLable;
        private System.Windows.Forms.TextBox GamePath;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.RadioButton x64RadioButton;
        private System.Windows.Forms.RadioButton x32RadioButton;
        private System.Windows.Forms.CheckBox CloseAfterStartup;
    }
}

