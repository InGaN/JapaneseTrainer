namespace JapaneseTrainer
{
    partial class FormConfig
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
            this.cbShowID = new System.Windows.Forms.CheckBox();
            this.cbHighlightVerbs = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_timer3 = new System.Windows.Forms.Label();
            this.num_timer1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_timer1 = new System.Windows.Forms.Label();
            this.cbx_trainer_timer = new System.Windows.Forms.CheckBox();
            this.lbl_timer4 = new System.Windows.Forms.Label();
            this.num_timer2 = new System.Windows.Forms.NumericUpDown();
            this.lbl_timer2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_timer2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbShowID
            // 
            this.cbShowID.AutoSize = true;
            this.cbShowID.Location = new System.Drawing.Point(12, 12);
            this.cbShowID.Name = "cbShowID";
            this.cbShowID.Size = new System.Drawing.Size(67, 17);
            this.cbShowID.TabIndex = 0;
            this.cbShowID.Text = global::JapaneseTrainer.strings.showID;
            this.cbShowID.UseVisualStyleBackColor = true;
            this.cbShowID.CheckedChanged += new System.EventHandler(this.cbShowID_CheckedChanged);
            // 
            // cbHighlightVerbs
            // 
            this.cbHighlightVerbs.AutoSize = true;
            this.cbHighlightVerbs.Location = new System.Drawing.Point(12, 36);
            this.cbHighlightVerbs.Name = "cbHighlightVerbs";
            this.cbHighlightVerbs.Size = new System.Drawing.Size(97, 17);
            this.cbHighlightVerbs.TabIndex = 1;
            this.cbHighlightVerbs.Text = global::JapaneseTrainer.strings.highlightVerbs;
            this.cbHighlightVerbs.UseVisualStyleBackColor = true;
            this.cbHighlightVerbs.CheckedChanged += new System.EventHandler(this.cbHighlightVerbs_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_timer2);
            this.groupBox1.Controls.Add(this.num_timer2);
            this.groupBox1.Controls.Add(this.lbl_timer4);
            this.groupBox1.Controls.Add(this.lbl_timer3);
            this.groupBox1.Controls.Add(this.num_timer1);
            this.groupBox1.Controls.Add(this.lbl_timer1);
            this.groupBox1.Controls.Add(this.cbx_trainer_timer);
            this.groupBox1.Location = new System.Drawing.Point(185, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 159);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trainers";
            // 
            // lbl_timer3
            // 
            this.lbl_timer3.AutoSize = true;
            this.lbl_timer3.Location = new System.Drawing.Point(6, 40);
            this.lbl_timer3.Name = "lbl_timer3";
            this.lbl_timer3.Size = new System.Drawing.Size(84, 13);
            this.lbl_timer3.TabIndex = 4;
            this.lbl_timer3.Text = "Time until reveal";
            // 
            // num_timer1
            // 
            this.num_timer1.Location = new System.Drawing.Point(9, 56);
            this.num_timer1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_timer1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_timer1.Name = "num_timer1";
            this.num_timer1.Size = new System.Drawing.Size(50, 20);
            this.num_timer1.TabIndex = 3;
            this.num_timer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_timer1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_timer1.ValueChanged += new System.EventHandler(this.num_timer_ValueChanged);
            // 
            // lbl_timer1
            // 
            this.lbl_timer1.AutoSize = true;
            this.lbl_timer1.Location = new System.Drawing.Point(65, 58);
            this.lbl_timer1.Name = "lbl_timer1";
            this.lbl_timer1.Size = new System.Drawing.Size(47, 13);
            this.lbl_timer1.TabIndex = 2;
            this.lbl_timer1.Text = "seconds";
            // 
            // cbx_trainer_timer
            // 
            this.cbx_trainer_timer.AutoSize = true;
            this.cbx_trainer_timer.Location = new System.Drawing.Point(7, 20);
            this.cbx_trainer_timer.Name = "cbx_trainer_timer";
            this.cbx_trainer_timer.Size = new System.Drawing.Size(88, 17);
            this.cbx_trainer_timer.TabIndex = 0;
            this.cbx_trainer_timer.Text = "Enable Timer";
            this.cbx_trainer_timer.UseVisualStyleBackColor = true;
            this.cbx_trainer_timer.CheckedChanged += new System.EventHandler(this.cbx_trainer_timer_CheckedChanged);
            // 
            // lbl_timer4
            // 
            this.lbl_timer4.AutoSize = true;
            this.lbl_timer4.Location = new System.Drawing.Point(9, 83);
            this.lbl_timer4.Name = "lbl_timer4";
            this.lbl_timer4.Size = new System.Drawing.Size(101, 13);
            this.lbl_timer4.TabIndex = 5;
            this.lbl_timer4.Text = "Time until next Kanji";
            // 
            // num_timer2
            // 
            this.num_timer2.Location = new System.Drawing.Point(9, 100);
            this.num_timer2.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_timer2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_timer2.Name = "num_timer2";
            this.num_timer2.Size = new System.Drawing.Size(50, 20);
            this.num_timer2.TabIndex = 6;
            this.num_timer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_timer2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_timer2.ValueChanged += new System.EventHandler(this.num_timer2_ValueChanged);
            // 
            // lbl_timer2
            // 
            this.lbl_timer2.AutoSize = true;
            this.lbl_timer2.Location = new System.Drawing.Point(65, 102);
            this.lbl_timer2.Name = "lbl_timer2";
            this.lbl_timer2.Size = new System.Drawing.Size(47, 13);
            this.lbl_timer2.TabIndex = 7;
            this.lbl_timer2.Text = "seconds";
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 183);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbHighlightVerbs);
            this.Controls.Add(this.cbShowID);
            this.Name = "FormConfig";
            this.Text = "FormConfig";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_timer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbShowID;
        private System.Windows.Forms.CheckBox cbHighlightVerbs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbx_trainer_timer;
        private System.Windows.Forms.Label lbl_timer1;
        private System.Windows.Forms.NumericUpDown num_timer1;
        private System.Windows.Forms.Label lbl_timer3;
        private System.Windows.Forms.Label lbl_timer2;
        private System.Windows.Forms.NumericUpDown num_timer2;
        private System.Windows.Forms.Label lbl_timer4;
    }
}