namespace tarea11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Fecha seleccionada: " + dateTimePicker1.Value.ToShortDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
