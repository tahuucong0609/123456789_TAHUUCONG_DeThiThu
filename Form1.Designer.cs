namespace _123456789_TAHUUCONG
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            tiệnÍchToolStripMenuItem = new ToolStripMenuItem();
            giảiPhươngTrìnhBậc2ToolStripMenuItem = new ToolStripMenuItem();
            địnhDạngToolStripMenuItem = new ToolStripMenuItem();
            đăngKýMônHọcToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            giớiThiệuToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            Infor = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, tiệnÍchToolStripMenuItem, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(71, 20);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(104, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // tiệnÍchToolStripMenuItem
            // 
            tiệnÍchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { giảiPhươngTrìnhBậc2ToolStripMenuItem, địnhDạngToolStripMenuItem, đăngKýMônHọcToolStripMenuItem });
            tiệnÍchToolStripMenuItem.Name = "tiệnÍchToolStripMenuItem";
            tiệnÍchToolStripMenuItem.Size = new Size(60, 20);
            tiệnÍchToolStripMenuItem.Text = "Tiện ích";
            // 
            // giảiPhươngTrìnhBậc2ToolStripMenuItem
            // 
            giảiPhươngTrìnhBậc2ToolStripMenuItem.Name = "giảiPhươngTrìnhBậc2ToolStripMenuItem";
            giảiPhươngTrìnhBậc2ToolStripMenuItem.Size = new Size(198, 22);
            giảiPhươngTrìnhBậc2ToolStripMenuItem.Text = "Giải phương trình bậc 2";
            // 
            // địnhDạngToolStripMenuItem
            // 
            địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            địnhDạngToolStripMenuItem.Size = new Size(198, 22);
            địnhDạngToolStripMenuItem.Text = "Định dạng";
            // 
            // đăngKýMônHọcToolStripMenuItem
            // 
            đăngKýMônHọcToolStripMenuItem.Name = "đăngKýMônHọcToolStripMenuItem";
            đăngKýMônHọcToolStripMenuItem.Size = new Size(198, 22);
            đăngKýMônHọcToolStripMenuItem.Text = "Đăng ký môn học";
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { giớiThiệuToolStripMenuItem, cậpNhậtToolStripMenuItem });
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(62, 20);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // giớiThiệuToolStripMenuItem
            // 
            giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            giớiThiệuToolStripMenuItem.Size = new Size(180, 22);
            giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            giớiThiệuToolStripMenuItem.Click += giớiThiệuToolStripMenuItem_Click;
            // 
            // cậpNhậtToolStripMenuItem
            // 
            cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            cậpNhậtToolStripMenuItem.Size = new Size(180, 22);
            cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            // 
            // Infor
            // 
            Infor.AutoSize = true;
            Infor.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Infor.Location = new Point(275, 106);
            Infor.Name = "Infor";
            Infor.Size = new Size(85, 33);
            Infor.TabIndex = 2;
            Infor.Text = "label1";
            Infor.Click += Infor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Infor);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Đề Thi";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem tiệnÍchToolStripMenuItem;
        private ToolStripMenuItem giảiPhươngTrìnhBậc2ToolStripMenuItem;
        private ToolStripMenuItem địnhDạngToolStripMenuItem;
        private ToolStripMenuItem đăngKýMônHọcToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private Label Infor;
    }
}
