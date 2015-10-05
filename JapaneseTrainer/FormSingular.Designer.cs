namespace JapaneseTrainer
{
    partial class FormSingular
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
            this.tblPanel_container = new System.Windows.Forms.TableLayoutPanel();
            this.tblPanel_japanese = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_japanese = new System.Windows.Forms.Label();
            this.lbl_furigana = new System.Windows.Forms.Label();
            this.tblPanel_meaning = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_meaning = new System.Windows.Forms.Label();
            this.lbl_extra = new System.Windows.Forms.Label();
            this.bar_trainer_timer = new System.Windows.Forms.ProgressBar();
            this.tbl_rating = new System.Windows.Forms.TableLayoutPanel();
            this.pbx_star1 = new System.Windows.Forms.PictureBox();
            this.pbx_star2 = new System.Windows.Forms.PictureBox();
            this.pbx_star3 = new System.Windows.Forms.PictureBox();
            this.pbx_star4 = new System.Windows.Forms.PictureBox();
            this.pbx_star5 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.increasePriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreasePriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showFuriganaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showKanjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMeaningsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.showIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblPanel_container.SuspendLayout();
            this.tblPanel_japanese.SuspendLayout();
            this.tblPanel_meaning.SuspendLayout();
            this.tbl_rating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_star5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPanel_container
            // 
            this.tblPanel_container.ColumnCount = 1;
            this.tblPanel_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel_container.Controls.Add(this.tblPanel_japanese, 0, 1);
            this.tblPanel_container.Controls.Add(this.tblPanel_meaning, 0, 2);
            this.tblPanel_container.Controls.Add(this.bar_trainer_timer, 0, 3);
            this.tblPanel_container.Controls.Add(this.tbl_rating, 0, 0);
            this.tblPanel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel_container.Location = new System.Drawing.Point(0, 24);
            this.tblPanel_container.Name = "tblPanel_container";
            this.tblPanel_container.RowCount = 4;
            this.tblPanel_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPanel_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPanel_container.Size = new System.Drawing.Size(284, 237);
            this.tblPanel_container.TabIndex = 0;
            // 
            // tblPanel_japanese
            // 
            this.tblPanel_japanese.ColumnCount = 1;
            this.tblPanel_japanese.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel_japanese.Controls.Add(this.lbl_japanese, 0, 1);
            this.tblPanel_japanese.Controls.Add(this.lbl_furigana, 0, 0);
            this.tblPanel_japanese.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel_japanese.Location = new System.Drawing.Point(3, 23);
            this.tblPanel_japanese.Name = "tblPanel_japanese";
            this.tblPanel_japanese.RowCount = 2;
            this.tblPanel_japanese.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblPanel_japanese.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblPanel_japanese.Size = new System.Drawing.Size(278, 92);
            this.tblPanel_japanese.TabIndex = 0;
            // 
            // lbl_japanese
            // 
            this.lbl_japanese.AutoSize = true;
            this.lbl_japanese.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_japanese.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_japanese.Location = new System.Drawing.Point(3, 36);
            this.lbl_japanese.Name = "lbl_japanese";
            this.lbl_japanese.Size = new System.Drawing.Size(272, 56);
            this.lbl_japanese.TabIndex = 0;
            this.lbl_japanese.Text = "label1";
            this.lbl_japanese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_furigana
            // 
            this.lbl_furigana.AutoSize = true;
            this.lbl_furigana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_furigana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_furigana.Location = new System.Drawing.Point(3, 0);
            this.lbl_furigana.Name = "lbl_furigana";
            this.lbl_furigana.Size = new System.Drawing.Size(272, 36);
            this.lbl_furigana.TabIndex = 1;
            this.lbl_furigana.Text = "label1";
            this.lbl_furigana.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tblPanel_meaning
            // 
            this.tblPanel_meaning.ColumnCount = 1;
            this.tblPanel_meaning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel_meaning.Controls.Add(this.lbl_meaning, 0, 0);
            this.tblPanel_meaning.Controls.Add(this.lbl_extra, 0, 1);
            this.tblPanel_meaning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel_meaning.Location = new System.Drawing.Point(3, 121);
            this.tblPanel_meaning.Name = "tblPanel_meaning";
            this.tblPanel_meaning.RowCount = 2;
            this.tblPanel_meaning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel_meaning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel_meaning.Size = new System.Drawing.Size(278, 92);
            this.tblPanel_meaning.TabIndex = 1;
            // 
            // lbl_meaning
            // 
            this.lbl_meaning.AutoSize = true;
            this.lbl_meaning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_meaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_meaning.Location = new System.Drawing.Point(3, 0);
            this.lbl_meaning.Name = "lbl_meaning";
            this.lbl_meaning.Size = new System.Drawing.Size(272, 46);
            this.lbl_meaning.TabIndex = 0;
            this.lbl_meaning.Text = "label1";
            this.lbl_meaning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_extra
            // 
            this.lbl_extra.AutoSize = true;
            this.lbl_extra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_extra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_extra.Location = new System.Drawing.Point(3, 46);
            this.lbl_extra.Name = "lbl_extra";
            this.lbl_extra.Size = new System.Drawing.Size(272, 46);
            this.lbl_extra.TabIndex = 1;
            this.lbl_extra.Text = "label1";
            this.lbl_extra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bar_trainer_timer
            // 
            this.bar_trainer_timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_trainer_timer.Location = new System.Drawing.Point(3, 219);
            this.bar_trainer_timer.Name = "bar_trainer_timer";
            this.bar_trainer_timer.Size = new System.Drawing.Size(278, 15);
            this.bar_trainer_timer.TabIndex = 2;
            // 
            // tbl_rating
            // 
            this.tbl_rating.ColumnCount = 5;
            this.tbl_rating.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_rating.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_rating.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_rating.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_rating.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_rating.Controls.Add(this.pbx_star1, 0, 0);
            this.tbl_rating.Controls.Add(this.pbx_star2, 1, 0);
            this.tbl_rating.Controls.Add(this.pbx_star3, 2, 0);
            this.tbl_rating.Controls.Add(this.pbx_star4, 3, 0);
            this.tbl_rating.Controls.Add(this.pbx_star5, 4, 0);
            this.tbl_rating.Location = new System.Drawing.Point(5, 0);
            this.tbl_rating.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tbl_rating.Name = "tbl_rating";
            this.tbl_rating.RowCount = 1;
            this.tbl_rating.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_rating.Size = new System.Drawing.Size(100, 20);
            this.tbl_rating.TabIndex = 3;
            // 
            // pbx_star1
            // 
            this.pbx_star1.Location = new System.Drawing.Point(0, 0);
            this.pbx_star1.Margin = new System.Windows.Forms.Padding(0);
            this.pbx_star1.Name = "pbx_star1";
            this.pbx_star1.Size = new System.Drawing.Size(20, 20);
            this.pbx_star1.TabIndex = 0;
            this.pbx_star1.TabStop = false;
            this.pbx_star1.Click += new System.EventHandler(this.star1_click);
            this.pbx_star1.MouseLeave += new System.EventHandler(this.starbox_leave);
            this.pbx_star1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.star1_move);
            // 
            // pbx_star2
            // 
            this.pbx_star2.Location = new System.Drawing.Point(20, 0);
            this.pbx_star2.Margin = new System.Windows.Forms.Padding(0);
            this.pbx_star2.Name = "pbx_star2";
            this.pbx_star2.Size = new System.Drawing.Size(20, 20);
            this.pbx_star2.TabIndex = 1;
            this.pbx_star2.TabStop = false;
            this.pbx_star2.Click += new System.EventHandler(this.star2_click);
            this.pbx_star2.MouseLeave += new System.EventHandler(this.starbox_leave);
            this.pbx_star2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.star2_move);
            // 
            // pbx_star3
            // 
            this.pbx_star3.Location = new System.Drawing.Point(40, 0);
            this.pbx_star3.Margin = new System.Windows.Forms.Padding(0);
            this.pbx_star3.Name = "pbx_star3";
            this.pbx_star3.Size = new System.Drawing.Size(20, 20);
            this.pbx_star3.TabIndex = 2;
            this.pbx_star3.TabStop = false;
            this.pbx_star3.Click += new System.EventHandler(this.star3_click);
            this.pbx_star3.MouseLeave += new System.EventHandler(this.starbox_leave);
            this.pbx_star3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.star3_move);
            // 
            // pbx_star4
            // 
            this.pbx_star4.Location = new System.Drawing.Point(60, 0);
            this.pbx_star4.Margin = new System.Windows.Forms.Padding(0);
            this.pbx_star4.Name = "pbx_star4";
            this.pbx_star4.Size = new System.Drawing.Size(20, 20);
            this.pbx_star4.TabIndex = 3;
            this.pbx_star4.TabStop = false;
            this.pbx_star4.Click += new System.EventHandler(this.star4_click);
            this.pbx_star4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.star4_move);
            // 
            // pbx_star5
            // 
            this.pbx_star5.Location = new System.Drawing.Point(80, 0);
            this.pbx_star5.Margin = new System.Windows.Forms.Padding(0);
            this.pbx_star5.Name = "pbx_star5";
            this.pbx_star5.Size = new System.Drawing.Size(20, 20);
            this.pbx_star5.TabIndex = 4;
            this.pbx_star5.TabStop = false;
            this.pbx_star5.Click += new System.EventHandler(this.star5_click);
            this.pbx_star5.MouseLeave += new System.EventHandler(this.starbox_leave);
            this.pbx_star5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.star5_move);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.kanjiToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // kanjiToolStripMenuItem
            // 
            this.kanjiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.increasePriorityToolStripMenuItem,
            this.decreasePriorityToolStripMenuItem});
            this.kanjiToolStripMenuItem.Name = "kanjiToolStripMenuItem";
            this.kanjiToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.kanjiToolStripMenuItem.Text = "Kanji";
            // 
            // nextToolStripMenuItem1
            // 
            this.nextToolStripMenuItem1.Name = "nextToolStripMenuItem1";
            this.nextToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.nextToolStripMenuItem1.Text = "Next";
            this.nextToolStripMenuItem1.Click += new System.EventHandler(this.nextToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(159, 6);
            // 
            // increasePriorityToolStripMenuItem
            // 
            this.increasePriorityToolStripMenuItem.Name = "increasePriorityToolStripMenuItem";
            this.increasePriorityToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.increasePriorityToolStripMenuItem.Text = "Increase priority";
            this.increasePriorityToolStripMenuItem.Click += new System.EventHandler(this.increasePriorityToolStripMenuItem_Click);
            // 
            // decreasePriorityToolStripMenuItem
            // 
            this.decreasePriorityToolStripMenuItem.Name = "decreasePriorityToolStripMenuItem";
            this.decreasePriorityToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.decreasePriorityToolStripMenuItem.Text = "Decrease priority";
            this.decreasePriorityToolStripMenuItem.Click += new System.EventHandler(this.decreasePriorityToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showFuriganaToolStripMenuItem,
            this.showKanjiToolStripMenuItem,
            this.showMeaningsToolStripMenuItem,
            this.ToolStripSeparator,
            this.showIDToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.displayToolStripMenuItem.Text = "View";
            // 
            // showFuriganaToolStripMenuItem
            // 
            this.showFuriganaToolStripMenuItem.CheckOnClick = true;
            this.showFuriganaToolStripMenuItem.Name = "showFuriganaToolStripMenuItem";
            this.showFuriganaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.showFuriganaToolStripMenuItem.Text = "Show Furigana";
            this.showFuriganaToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.showFuriganaToolStripMenuItem_CheckStateChanged);
            this.showFuriganaToolStripMenuItem.Click += new System.EventHandler(this.showFuriganaToolStripMenuItem_Click);
            // 
            // showKanjiToolStripMenuItem
            // 
            this.showKanjiToolStripMenuItem.CheckOnClick = true;
            this.showKanjiToolStripMenuItem.Name = "showKanjiToolStripMenuItem";
            this.showKanjiToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.showKanjiToolStripMenuItem.Text = "Show Kanji";
            this.showKanjiToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showKanjiToolStripMenuItem_CheckedChanged);
            this.showKanjiToolStripMenuItem.Click += new System.EventHandler(this.showKanjiToolStripMenuItem_Click);
            // 
            // showMeaningsToolStripMenuItem
            // 
            this.showMeaningsToolStripMenuItem.CheckOnClick = true;
            this.showMeaningsToolStripMenuItem.Name = "showMeaningsToolStripMenuItem";
            this.showMeaningsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.showMeaningsToolStripMenuItem.Text = "Show Meanings";
            this.showMeaningsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showMeaningsToolStripMenuItem_CheckedChanged);
            this.showMeaningsToolStripMenuItem.Click += new System.EventHandler(this.showMeaningsToolStripMenuItem_Click);
            // 
            // ToolStripSeparator
            // 
            this.ToolStripSeparator.Name = "ToolStripSeparator";
            this.ToolStripSeparator.Size = new System.Drawing.Size(155, 6);
            // 
            // showIDToolStripMenuItem
            // 
            this.showIDToolStripMenuItem.CheckOnClick = true;
            this.showIDToolStripMenuItem.Name = "showIDToolStripMenuItem";
            this.showIDToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.showIDToolStripMenuItem.Text = "Show ID";
            this.showIDToolStripMenuItem.Click += new System.EventHandler(this.showIDToolStripMenuItem1_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // FormSingular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tblPanel_container);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSingular";
            this.Text = "FormSingular";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSingular_FormClosed);
            this.Load += new System.EventHandler(this.FormSingular_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSingular_KeyDown);
            this.tblPanel_container.ResumeLayout(false);
            this.tblPanel_japanese.ResumeLayout(false);
            this.tblPanel_japanese.PerformLayout();
            this.tblPanel_meaning.ResumeLayout(false);
            this.tblPanel_meaning.PerformLayout();
            this.tbl_rating.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_star5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPanel_container;
        private System.Windows.Forms.TableLayoutPanel tblPanel_japanese;
        private System.Windows.Forms.TableLayoutPanel tblPanel_meaning;
        private System.Windows.Forms.Label lbl_japanese;
        private System.Windows.Forms.Label lbl_furigana;
        private System.Windows.Forms.Label lbl_meaning;
        private System.Windows.Forms.Label lbl_extra;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showFuriganaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showKanjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMeaningsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem showIDToolStripMenuItem;
        private System.Windows.Forms.ProgressBar bar_trainer_timer;
        private System.Windows.Forms.ToolStripMenuItem kanjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increasePriorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreasePriorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.TableLayoutPanel tbl_rating;
        private System.Windows.Forms.PictureBox pbx_star1;
        private System.Windows.Forms.PictureBox pbx_star2;
        private System.Windows.Forms.PictureBox pbx_star3;
        private System.Windows.Forms.PictureBox pbx_star4;
        private System.Windows.Forms.PictureBox pbx_star5;
    }
}