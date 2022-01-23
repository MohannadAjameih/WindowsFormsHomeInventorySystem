namespace WindowsFormsHomeInventorySystem
{
    partial class frmUserProfile
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
            this.labUserProfile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labUserProfile
            // 
            this.labUserProfile.AutoSize = true;
            this.labUserProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserProfile.Location = new System.Drawing.Point(387, 351);
            this.labUserProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUserProfile.Name = "labUserProfile";
            this.labUserProfile.Size = new System.Drawing.Size(579, 39);
            this.labUserProfile.TabIndex = 0;
            this.labUserProfile.Text = "Welcome To Home Inventory System";
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::WindowsFormsHomeInventorySystem.Properties.Resources._538_photo_31611;
            this.ClientSize = new System.Drawing.Size(1112, 640);
            this.Controls.Add(this.labUserProfile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUserProfile";
            this.Text = "frmUserProfile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUserProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUserProfile;
    }
}