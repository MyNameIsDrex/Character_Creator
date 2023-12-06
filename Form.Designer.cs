namespace Character_Creator
{
    partial class Form
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
            theme_select = new ComboBox();
            alignment_select = new ComboBox();
            SuspendLayout();
            // 
            // theme_select
            // 
            theme_select.FormattingEnabled = true;
            theme_select.Items.AddRange(new object[] { "Fantasy", "Steampunk", "Future" });
            theme_select.Location = new Point(12, 12);
            theme_select.Name = "theme_select";
            theme_select.Size = new Size(121, 23);
            theme_select.TabIndex = 0;
            // 
            // alignment_select
            // 
            alignment_select.FormattingEnabled = true;
            alignment_select.Items.AddRange(new object[] { "Neutral", "Chaotic", "Good" });
            alignment_select.Location = new Point(12, 41);
            alignment_select.Name = "alignment_select";
            alignment_select.Size = new Size(121, 23);
            alignment_select.TabIndex = 1;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(alignment_select);
            Controls.Add(theme_select);
            Name = "Form";
            Text = "Character Creator";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox theme_select;
        private ComboBox alignment_select;
    }
}