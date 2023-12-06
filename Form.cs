using Character_Creator.Properties;

namespace Character_Creator
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            default_values();
        }

        public void default_values()
        {
            theme_select.SelectedIndex = 0;
            alignment_select.SelectedIndex = 0;
            gender_select.SelectedIndex = 0;
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void name_button_Click(object sender, EventArgs e)
        {
            Program.name_generator();
            name_box.Text = Settings.Default.name;
        }
    }
}