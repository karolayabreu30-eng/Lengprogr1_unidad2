namespace tarea6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Rojo");
            comboBox1.Items.Add("Verde");
            comboBox1.Items.Add("Azul");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Rojo")
                this.BackColor = Color.Red;

            if (comboBox1.SelectedItem.ToString() == "Verde")
                this.BackColor = Color.Green;

            if (comboBox1.SelectedItem.ToString() == "Azul")
                this.BackColor = Color.Blue;

        }
    }
}
