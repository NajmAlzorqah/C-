namespace first_form_for_the_course.PL
{
    partial class FRM_MAIN
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
            this.Aside = new System.Windows.Forms.Panel();
            this.HOME = new System.Windows.Forms.Panel();
            this.P_MAIN = new System.Windows.Forms.Panel();
            this.TOOL_BAR = new System.Windows.Forms.Panel();
            this.Main_Lable = new System.Windows.Forms.Label();
            this.TOOL_BAR.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(165)))), ((int)(((byte)(137)))));
            this.Aside.Dock = System.Windows.Forms.DockStyle.Left;
            this.Aside.Location = new System.Drawing.Point(0, 0);
            this.Aside.Name = "Aside";
            this.Aside.Padding = new System.Windows.Forms.Padding(20);
            this.Aside.Size = new System.Drawing.Size(161, 423);
            this.Aside.TabIndex = 0;
            // 
            // HOME
            // 
            this.HOME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HOME.Location = new System.Drawing.Point(161, 35);
            this.HOME.Name = "HOME";
            this.HOME.Size = new System.Drawing.Size(609, 388);
            this.HOME.TabIndex = 2;
            // 
            // P_MAIN
            // 
            this.P_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_MAIN.Location = new System.Drawing.Point(161, 35);
            this.P_MAIN.Name = "P_MAIN";
            this.P_MAIN.Size = new System.Drawing.Size(609, 388);
            this.P_MAIN.TabIndex = 0;
            // 
            // TOOL_BAR
            // 
            this.TOOL_BAR.BackColor = System.Drawing.Color.Transparent;
            this.TOOL_BAR.Controls.Add(this.Main_Lable);
            this.TOOL_BAR.Dock = System.Windows.Forms.DockStyle.Top;
            this.TOOL_BAR.Location = new System.Drawing.Point(161, 0);
            this.TOOL_BAR.Name = "TOOL_BAR";
            this.TOOL_BAR.Size = new System.Drawing.Size(609, 35);
            this.TOOL_BAR.TabIndex = 1;
            this.TOOL_BAR.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Main_Lable
            // 
            this.Main_Lable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Main_Lable.AutoSize = true;
            this.Main_Lable.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Lable.Location = new System.Drawing.Point(265, 8);
            this.Main_Lable.Name = "Main_Lable";
            this.Main_Lable.Size = new System.Drawing.Size(48, 24);
            this.Main_Lable.TabIndex = 0;
            this.Main_Lable.Text = "Main";
            this.Main_Lable.Click += new System.EventHandler(this.label1_Click);
            // 
            // FRM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 423);
            this.Controls.Add(this.HOME);
            this.Controls.Add(this.P_MAIN);
            this.Controls.Add(this.TOOL_BAR);
            this.Controls.Add(this.Aside);
            this.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRM_MAIN_Load);
            this.TOOL_BAR.ResumeLayout(false);
            this.TOOL_BAR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Aside;
        private System.Windows.Forms.Panel HOME;
        private System.Windows.Forms.Panel P_MAIN;
        private System.Windows.Forms.Panel TOOL_BAR;
        private System.Windows.Forms.Label Main_Lable;
    }
}