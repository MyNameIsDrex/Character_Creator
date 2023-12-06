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
        }
    }
}