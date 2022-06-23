namespace JsonParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UI events

        private void btnDeserialise_Click(object sender, EventArgs e)
        {
            txtDebugOutput.Text = txtInput.Text;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDebugOutput.Text = string.Empty;
        }

        #endregion

      
    }
}