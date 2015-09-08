using System.Threading;
using System.Globalization;

namespace JapaneseTrainer
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
            this.btnNextKanji = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayFuriganaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayKanjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayMeaningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbTimer = new System.Windows.Forms.ProgressBar();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.lblJapanese = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.innerTable = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNextKanji
            // 
            this.btnNextKanji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextKanji.Location = new System.Drawing.Point(609, 3);
            this.btnNextKanji.Name = "btnNextKanji";
            this.btnNextKanji.Size = new System.Drawing.Size(74, 30);
            this.btnNextKanji.TabIndex = 0;
            this.btnNextKanji.Text = global::JapaneseTrainer.strings.next;
            this.btnNextKanji.UseVisualStyleBackColor = true;
            this.btnNextKanji.Click += new System.EventHandler(this.btnNextKanji_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.kanjiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = global::JapaneseTrainer.strings.file;
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = global::JapaneseTrainer.strings.close;
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // kanjiToolStripMenuItem
            // 
            this.kanjiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayFuriganaToolStripMenuItem,
            this.displayKanjiToolStripMenuItem,
            this.displayMeaningToolStripMenuItem,
            this.fontSizeToolStripMenuItem});
            this.kanjiToolStripMenuItem.Name = "kanjiToolStripMenuItem";
            this.kanjiToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.kanjiToolStripMenuItem.Text = global::JapaneseTrainer.strings.kanji;
            // 
            // displayFuriganaToolStripMenuItem
            // 
            this.displayFuriganaToolStripMenuItem.CheckOnClick = true;
            this.displayFuriganaToolStripMenuItem.Name = "displayFuriganaToolStripMenuItem";
            this.displayFuriganaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.displayFuriganaToolStripMenuItem.Text = global::JapaneseTrainer.strings.displayFurigana;
            // 
            // displayKanjiToolStripMenuItem
            // 
            this.displayKanjiToolStripMenuItem.CheckOnClick = true;
            this.displayKanjiToolStripMenuItem.Name = "displayKanjiToolStripMenuItem";
            this.displayKanjiToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.displayKanjiToolStripMenuItem.Text = global::JapaneseTrainer.strings.displayKanji;
            // 
            // displayMeaningToolStripMenuItem
            // 
            this.displayMeaningToolStripMenuItem.CheckOnClick = true;
            this.displayMeaningToolStripMenuItem.Name = "displayMeaningToolStripMenuItem";
            this.displayMeaningToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.displayMeaningToolStripMenuItem.Text = global::JapaneseTrainer.strings.displayMeaning;
            // 
            // fontSizeToolStripMenuItem
            // 
            this.fontSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increaseToolStripMenuItem,
            this.decreaseToolStripMenuItem});
            this.fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.fontSizeToolStripMenuItem.Text = global::JapaneseTrainer.strings.fontSize;
            // 
            // increaseToolStripMenuItem
            // 
            this.increaseToolStripMenuItem.Name = "increaseToolStripMenuItem";
            this.increaseToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.increaseToolStripMenuItem.Text = global::JapaneseTrainer.strings.increase;
            this.increaseToolStripMenuItem.Click += new System.EventHandler(this.increaseToolStripMenuItem_Click);
            // 
            // decreaseToolStripMenuItem
            // 
            this.decreaseToolStripMenuItem.Name = "decreaseToolStripMenuItem";
            this.decreaseToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.decreaseToolStripMenuItem.Text = global::JapaneseTrainer.strings.decrease;
            this.decreaseToolStripMenuItem.Click += new System.EventHandler(this.decreaseToolStripMenuItem_Click);
            // 
            // pbTimer
            // 
            this.pbTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTimer.Location = new System.Drawing.Point(3, 3);
            this.pbTimer.Name = "pbTimer";
            this.pbTimer.Size = new System.Drawing.Size(600, 30);
            this.pbTimer.TabIndex = 2;
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeaning.Location = new System.Drawing.Point(3, 188);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(686, 51);
            this.lblMeaning.TabIndex = 3;
            this.lblMeaning.Text = "EN";
            this.lblMeaning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJapanese
            // 
            this.lblJapanese.AutoSize = true;
            this.lblJapanese.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJapanese.Font = new System.Drawing.Font("Microsoft YaHei", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJapanese.Location = new System.Drawing.Point(3, 0);
            this.lblJapanese.Name = "lblJapanese";
            this.lblJapanese.Size = new System.Drawing.Size(686, 45);
            this.lblJapanese.TabIndex = 4;
            this.lblJapanese.Text = "JP";
            this.lblJapanese.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblJapanese, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMeaning, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.innerTable, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.97106F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.59271F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.43623F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 281);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.pbTimer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNextKanji, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 242);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(686, 36);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // innerTable
            // 
            this.innerTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.innerTable.AutoSize = true;
            this.innerTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.innerTable.ColumnCount = 1;
            this.innerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.innerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.innerTable.Location = new System.Drawing.Point(346, 116);
            this.innerTable.Name = "innerTable";
            this.innerTable.RowCount = 2;
            this.innerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.innerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.innerTable.Size = new System.Drawing.Size(0, 0);
            this.innerTable.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 305);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "日本語";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNextKanji;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayFuriganaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayKanjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayMeaningToolStripMenuItem;
        private System.Windows.Forms.ProgressBar pbTimer;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.Label lblJapanese;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel innerTable;
    }
}

