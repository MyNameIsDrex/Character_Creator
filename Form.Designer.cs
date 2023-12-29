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
            name_box = new TextBox();
            name_label = new Label();
            config_panel = new Panel();
            leader_checkbox = new CheckBox();
            theme_label = new Label();
            gender_label = new Label();
            gender_select = new ComboBox();
            generator_panel = new Panel();
            name_button = new Button();
            config_panel.SuspendLayout();
            generator_panel.SuspendLayout();
            SuspendLayout();
            // 
            // theme_select
            // 
            theme_select.DropDownStyle = ComboBoxStyle.DropDownList;
            theme_select.FormattingEnabled = true;
            theme_select.Items.AddRange(new object[] { "Fantasy", "Steampunk", "Future", "Robot" });
            theme_select.Location = new Point(7, 87);
            theme_select.Margin = new Padding(3, 4, 3, 4);
            theme_select.Name = "theme_select";
            theme_select.Size = new Size(138, 28);
            theme_select.TabIndex = 1;
            // 
            // name_box
            // 
            name_box.Location = new Point(7, 28);
            name_box.Margin = new Padding(3, 4, 3, 4);
            name_box.Name = "name_box";
            name_box.ReadOnly = true;
            name_box.Size = new Size(262, 27);
            name_box.TabIndex = 4;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(7, 4);
            name_label.Name = "name_label";
            name_label.Size = new Size(52, 20);
            name_label.TabIndex = 3;
            name_label.Text = "Name:";
            // 
            // config_panel
            // 
            config_panel.BorderStyle = BorderStyle.FixedSingle;
            config_panel.Controls.Add(leader_checkbox);
            config_panel.Controls.Add(theme_label);
            config_panel.Controls.Add(gender_label);
            config_panel.Controls.Add(gender_select);
            config_panel.Controls.Add(theme_select);
            config_panel.Location = new Point(16, 19);
            config_panel.Margin = new Padding(6, 7, 6, 7);
            config_panel.Name = "config_panel";
            config_panel.Padding = new Padding(3, 4, 3, 4);
            config_panel.Size = new Size(161, 562);
            config_panel.TabIndex = 4;
            // 
            // leader_checkbox
            // 
            leader_checkbox.AutoSize = true;
            leader_checkbox.Location = new Point(7, 122);
            leader_checkbox.Name = "leader_checkbox";
            leader_checkbox.Size = new Size(83, 24);
            leader_checkbox.TabIndex = 5;
            leader_checkbox.Text = "Leader?";
            leader_checkbox.UseVisualStyleBackColor = true;
            // 
            // theme_label
            // 
            theme_label.AutoSize = true;
            theme_label.Location = new Point(7, 63);
            theme_label.Name = "theme_label";
            theme_label.Size = new Size(57, 20);
            theme_label.TabIndex = 4;
            theme_label.Text = "Theme:";
            // 
            // gender_label
            // 
            gender_label.AutoSize = true;
            gender_label.Location = new Point(7, 4);
            gender_label.Name = "gender_label";
            gender_label.Size = new Size(60, 20);
            gender_label.TabIndex = 3;
            gender_label.Text = "Gender:";
            // 
            // gender_select
            // 
            gender_select.DropDownStyle = ComboBoxStyle.DropDownList;
            gender_select.FormattingEnabled = true;
            gender_select.Items.AddRange(new object[] { "Male", "Female" });
            gender_select.Location = new Point(7, 28);
            gender_select.Margin = new Padding(3, 4, 3, 4);
            gender_select.Name = "gender_select";
            gender_select.Size = new Size(138, 28);
            gender_select.TabIndex = 0;
            // 
            // generator_panel
            // 
            generator_panel.BorderStyle = BorderStyle.FixedSingle;
            generator_panel.Controls.Add(name_button);
            generator_panel.Controls.Add(name_label);
            generator_panel.Controls.Add(name_box);
            generator_panel.Location = new Point(189, 19);
            generator_panel.Margin = new Padding(6, 7, 6, 7);
            generator_panel.Name = "generator_panel";
            generator_panel.Padding = new Padding(3, 4, 3, 4);
            generator_panel.Size = new Size(279, 562);
            generator_panel.TabIndex = 5;
            // 
            // name_button
            // 
            name_button.Location = new Point(7, 67);
            name_button.Margin = new Padding(3, 4, 3, 4);
            name_button.Name = "name_button";
            name_button.Size = new Size(86, 31);
            name_button.TabIndex = 5;
            name_button.Text = "Generate";
            name_button.UseVisualStyleBackColor = true;
            name_button.Click += name_button_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(generator_panel);
            Controls.Add(config_panel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Character Creator";
            Load += Form_Load;
            config_panel.ResumeLayout(false);
            config_panel.PerformLayout();
            generator_panel.ResumeLayout(false);
            generator_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox name_box;
        private Label name_label;
        private Panel config_panel;
        private Panel generator_panel;
        private Label gender_label;
        private Label theme_label;
        private Button name_button;
        public ComboBox gender_select;
        public ComboBox theme_select;
        private CheckBox leader_checkbox;
    }
}