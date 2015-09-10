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
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 183);
            this.Controls.Add(this.cbHighlightVerbs);
            this.Controls.Add(this.cbShowID);
            this.Name = "FormConfig";
            this.Text = "FormConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbShowID;
        private System.Windows.Forms.CheckBox cbHighlightVerbs;
    }
}