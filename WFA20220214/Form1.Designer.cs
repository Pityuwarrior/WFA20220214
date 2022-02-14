
namespace WFA20220214
{
    partial class Form1
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
            this.lb_idezet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.témaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idézetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.tema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idezetekszama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.szerzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A nap idézete:";
            // 
            // lb_idezet
            // 
            this.lb_idezet.BackColor = System.Drawing.Color.White;
            this.lb_idezet.Location = new System.Drawing.Point(12, 31);
            this.lb_idezet.Name = "lb_idezet";
            this.lb_idezet.Size = new System.Drawing.Size(516, 63);
            this.lb_idezet.TabIndex = 1;
            this.lb_idezet.Text = "###Quote###";
            this.lb_idezet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "###DateTime###";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "###NumberofQuotes###";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.szerkesztésToolStripMenuItem,
            this.keresésToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(537, 174);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(83, 176);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(76, 4);
            // 
            // szerkesztésToolStripMenuItem
            // 
            this.szerkesztésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerkesztőToolStripMenuItem,
            this.témaToolStripMenuItem,
            this.forrásToolStripMenuItem,
            this.idézetToolStripMenuItem});
            this.szerkesztésToolStripMenuItem.Image = global::WFA20220214.Properties.Resources.edit;
            this.szerkesztésToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(76, 83);
            this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
            this.szerkesztésToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // szerkesztőToolStripMenuItem
            // 
            this.szerkesztőToolStripMenuItem.Name = "szerkesztőToolStripMenuItem";
            this.szerkesztőToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.szerkesztőToolStripMenuItem.Text = "Szerkesztő";
            // 
            // témaToolStripMenuItem
            // 
            this.témaToolStripMenuItem.Name = "témaToolStripMenuItem";
            this.témaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.témaToolStripMenuItem.Text = "Téma";
            // 
            // forrásToolStripMenuItem
            // 
            this.forrásToolStripMenuItem.Name = "forrásToolStripMenuItem";
            this.forrásToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.forrásToolStripMenuItem.Text = "Forrás";
            // 
            // idézetToolStripMenuItem
            // 
            this.idézetToolStripMenuItem.Name = "idézetToolStripMenuItem";
            this.idézetToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.idézetToolStripMenuItem.Text = "Idézet";
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Image = global::WFA20220214.Properties.Resources.search;
            this.keresésToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(76, 83);
            this.keresésToolStripMenuItem.Text = "Keresés";
            this.keresésToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(202, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Az idézetek száma témák szerint:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.5534F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.4466F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DGV, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DGV2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 98);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.716418F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.28358F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 268);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Az idézetek száma szezők szerint: ";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tema,
            this.Idezetekszama});
            this.DGV.Location = new System.Drawing.Point(3, 21);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.Size = new System.Drawing.Size(208, 244);
            this.DGV.TabIndex = 8;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // tema
            // 
            this.tema.HeaderText = "Téma";
            this.tema.Name = "tema";
            // 
            // Idezetekszama
            // 
            this.Idezetekszama.HeaderText = "Idézetek száma";
            this.Idezetekszama.Name = "Idezetekszama";
            // 
            // DGV2
            // 
            this.DGV2.AllowUserToAddRows = false;
            this.DGV2.AllowUserToDeleteRows = false;
            this.DGV2.AllowUserToResizeColumns = false;
            this.DGV2.AllowUserToResizeRows = false;
            this.DGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.szerzo,
            this.szama});
            this.DGV2.Location = new System.Drawing.Point(217, 21);
            this.DGV2.Name = "DGV2";
            this.DGV2.RowHeadersVisible = false;
            this.DGV2.Size = new System.Drawing.Size(295, 244);
            this.DGV2.TabIndex = 9;
            // 
            // szerzo
            // 
            this.szerzo.HeaderText = "Szerző";
            this.szerzo.Name = "szerzo";
            // 
            // szama
            // 
            this.szama.HeaderText = "Idézetek száma";
            this.szama.Name = "szama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 378);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_idezet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_idezet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkesztőToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem témaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forrásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idézetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idezetekszama;
        private System.Windows.Forms.DataGridView DGV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn szerzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn szama;
    }
}

