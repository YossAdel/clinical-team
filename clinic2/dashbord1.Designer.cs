namespace clinic2
{
    partial class dashbord1
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
            this.bunifuAppBar1 = new Bunifu.Utils.BunifuAppBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bunifuAppBar1
            // 
            this.bunifuAppBar1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuAppBar1.ControlBoxColor = System.Drawing.Color.Gray;
            this.bunifuAppBar1.ControlBoxColorActive = System.Drawing.SystemColors.Control;
            this.bunifuAppBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuAppBar1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuAppBar1.ForeColor = System.Drawing.Color.White;
            this.bunifuAppBar1.Icon = null;
            this.bunifuAppBar1.Location = new System.Drawing.Point(271, 0);
            this.bunifuAppBar1.Name = "bunifuAppBar1";
            this.bunifuAppBar1.Size = new System.Drawing.Size(851, 46);
            this.bunifuAppBar1.TabIndex = 0;
            this.bunifuAppBar1.Title = "";
            this.bunifuAppBar1.TitleMargin = new System.Windows.Forms.Padding(47, 12, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 715);
            this.panel1.TabIndex = 1;
            // 
            // dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1122, 715);
            this.Controls.Add(this.bunifuAppBar1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "dashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashbord";
            this.Load += new System.EventHandler(this.dashbord_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Utils.BunifuAppBar bunifuAppBar1;
        private System.Windows.Forms.Panel panel1;
    }
}