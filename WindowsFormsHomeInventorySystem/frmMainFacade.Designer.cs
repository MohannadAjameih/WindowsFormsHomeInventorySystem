namespace WindowsFormsHomeInventorySystem
{
    partial class frmMainFacade
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelshow1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOrderQ = new System.Windows.Forms.Button();
            this.btnexti = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.btnitems = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnOrderQ);
            this.panel1.Controls.Add(this.btnexti);
            this.panel1.Controls.Add(this.btnorder);
            this.panel1.Controls.Add(this.btnitems);
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1328, 126);
            this.panel1.TabIndex = 0;
            // 
            // panelshow1
            // 
            this.panelshow1.BackColor = System.Drawing.Color.Silver;
            this.panelshow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelshow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelshow1.Location = new System.Drawing.Point(0, 126);
            this.panelshow1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panelshow1.Name = "panelshow1";
            this.panelshow1.Size = new System.Drawing.Size(1328, 495);
            this.panelshow1.TabIndex = 1;
            this.panelshow1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsHomeInventorySystem.Properties.Resources.avatar_people_person_profile_user_woman_icon_123356;
            this.pictureBox1.Location = new System.Drawing.Point(1201, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 95);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnOrderQ
            // 
            this.btnOrderQ.FlatAppearance.BorderSize = 0;
            this.btnOrderQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOrderQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderQ.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrderQ.Image = global::WindowsFormsHomeInventorySystem.Properties.Resources.gui_shipped_icon_157034__1_;
            this.btnOrderQ.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrderQ.Location = new System.Drawing.Point(389, 5);
            this.btnOrderQ.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnOrderQ.Name = "btnOrderQ";
            this.btnOrderQ.Size = new System.Drawing.Size(165, 107);
            this.btnOrderQ.TabIndex = 4;
            this.btnOrderQ.Text = "Order Quantity ";
            this.btnOrderQ.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrderQ.UseVisualStyleBackColor = true;
            this.btnOrderQ.Click += new System.EventHandler(this.btnOrderQ_Click);
            // 
            // btnexti
            // 
            this.btnexti.FlatAppearance.BorderSize = 0;
            this.btnexti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnexti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexti.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnexti.Image = global::WindowsFormsHomeInventorySystem.Properties.Resources.Actions_dialog_close_icon48;
            this.btnexti.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexti.Location = new System.Drawing.Point(567, 17);
            this.btnexti.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnexti.Name = "btnexti";
            this.btnexti.Size = new System.Drawing.Size(112, 96);
            this.btnexti.TabIndex = 3;
            this.btnexti.Text = "Exit";
            this.btnexti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexti.UseVisualStyleBackColor = true;
            this.btnexti.Click += new System.EventHandler(this.btnexti_Click);
            // 
            // btnorder
            // 
            this.btnorder.FlatAppearance.BorderSize = 0;
            this.btnorder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnorder.Image = global::WindowsFormsHomeInventorySystem.Properties.Resources.Checklist_icon_48;
            this.btnorder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnorder.Location = new System.Drawing.Point(267, 14);
            this.btnorder.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(112, 98);
            this.btnorder.TabIndex = 2;
            this.btnorder.Text = "Order";
            this.btnorder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btnitems
            // 
            this.btnitems.FlatAppearance.BorderSize = 0;
            this.btnitems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnitems.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnitems.Image = global::WindowsFormsHomeInventorySystem.Properties.Resources.add_item_icon84;
            this.btnitems.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnitems.Location = new System.Drawing.Point(149, 14);
            this.btnitems.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnitems.Name = "btnitems";
            this.btnitems.Size = new System.Drawing.Size(112, 98);
            this.btnitems.TabIndex = 1;
            this.btnitems.Text = "Items";
            this.btnitems.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnitems.UseVisualStyleBackColor = true;
            this.btnitems.Click += new System.EventHandler(this.btnitems_Click);
            // 
            // btnhome
            // 
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnhome.Image = global::WindowsFormsHomeInventorySystem.Properties.Resources.House_icon_48;
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnhome.Location = new System.Drawing.Point(27, 14);
            this.btnhome.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(112, 96);
            this.btnhome.TabIndex = 0;
            this.btnhome.Text = "Home";
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1160, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName:**********";
            // 
            // frmMainFacade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 621);
            this.Controls.Add(this.panelshow1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "frmMainFacade";
            this.Text = "MainFacade";
            this.Load += new System.EventHandler(this.frmMainFacade_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnitems;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Panel panelshow1;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnexti;
        private System.Windows.Forms.Button btnOrderQ;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

