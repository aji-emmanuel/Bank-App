
namespace MyBankAppWindows
{
    partial class DashBoardForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DepositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WithDrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountStatementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlaceHolder = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Your DashBoard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(235)))), ((int)(((byte)(182)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 100);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "BROKE BANK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyBankAppWindows.Properties.Resources.BankLogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(235)))), ((int)(((byte)(182)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DepositToolStripMenuItem,
            this.WithDrawToolStripMenuItem,
            this.TransferToolStripMenuItem,
            this.AccountDetailsToolStripMenuItem,
            this.accountStatementToolStripMenuItem,
            this.createAccountToolStripMenuItem,
            this.toolStripMenuItem1,
            this.logOutToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 100);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(198, 588);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DepositToolStripMenuItem
            // 
            this.DepositToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositToolStripMenuItem.Name = "DepositToolStripMenuItem";
            this.DepositToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 0, 6, 25);
            this.DepositToolStripMenuItem.Size = new System.Drawing.Size(185, 54);
            this.DepositToolStripMenuItem.Text = "Deposit";
            this.DepositToolStripMenuItem.Click += new System.EventHandler(this.DepositToolStripMenuItem_Click);
            // 
            // WithDrawToolStripMenuItem
            // 
            this.WithDrawToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithDrawToolStripMenuItem.Name = "WithDrawToolStripMenuItem";
            this.WithDrawToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 0, 6, 25);
            this.WithDrawToolStripMenuItem.Size = new System.Drawing.Size(185, 54);
            this.WithDrawToolStripMenuItem.Text = "WithDraw";
            this.WithDrawToolStripMenuItem.Click += new System.EventHandler(this.WithDrawToolStripMenuItem_Click);
            // 
            // TransferToolStripMenuItem
            // 
            this.TransferToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferToolStripMenuItem.Name = "TransferToolStripMenuItem";
            this.TransferToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 0, 6, 25);
            this.TransferToolStripMenuItem.Size = new System.Drawing.Size(185, 54);
            this.TransferToolStripMenuItem.Text = "Transfer";
            this.TransferToolStripMenuItem.Click += new System.EventHandler(this.TransferToolStripMenuItem_Click);
            // 
            // AccountDetailsToolStripMenuItem
            // 
            this.AccountDetailsToolStripMenuItem.Checked = true;
            this.AccountDetailsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AccountDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountDetailsToolStripMenuItem.Name = "AccountDetailsToolStripMenuItem";
            this.AccountDetailsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 0, 6, 25);
            this.AccountDetailsToolStripMenuItem.Size = new System.Drawing.Size(185, 54);
            this.AccountDetailsToolStripMenuItem.Text = "Account Details";
            this.AccountDetailsToolStripMenuItem.Click += new System.EventHandler(this.AccountDetailsToolStripMenuItem_Click);
            // 
            // accountStatementToolStripMenuItem
            // 
            this.accountStatementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountStatementToolStripMenuItem.Name = "accountStatementToolStripMenuItem";
            this.accountStatementToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 0, 6, 25);
            this.accountStatementToolStripMenuItem.Size = new System.Drawing.Size(185, 54);
            this.accountStatementToolStripMenuItem.Text = "Account Statement";
            this.accountStatementToolStripMenuItem.Click += new System.EventHandler(this.AccountStatementToolStripMenuItem_Click);
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 0, 6, 25);
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(185, 54);
            this.createAccountToolStripMenuItem.Text = "Create Account";
            this.createAccountToolStripMenuItem.Click += new System.EventHandler(this.CreateAccountToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 4);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 0, 6, 25);
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(185, 54);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 0, 6, 25);
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(185, 54);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // PlaceHolder
            // 
            this.PlaceHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlaceHolder.Location = new System.Drawing.Point(198, 100);
            this.PlaceHolder.Name = "PlaceHolder";
            this.PlaceHolder.Size = new System.Drawing.Size(758, 588);
            this.PlaceHolder.TabIndex = 8;
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 688);
            this.Controls.Add(this.PlaceHolder);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DepositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WithDrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountStatementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel PlaceHolder;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}