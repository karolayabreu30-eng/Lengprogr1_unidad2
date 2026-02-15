namespace tarea9
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;

            if (int.TryParse(textBox1.Text, out numero))
            {
                MessageBox.Show("Es un número válido");
            }
            else
            {
                MessageBox.Show("Error: Debe ingresar un número");
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }}
