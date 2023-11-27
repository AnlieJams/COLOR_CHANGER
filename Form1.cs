namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ColorDialog colorDialog = new ColorDialog();


            DialogResult result = colorDialog.ShowDialog();


            if (result == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }
    }
}