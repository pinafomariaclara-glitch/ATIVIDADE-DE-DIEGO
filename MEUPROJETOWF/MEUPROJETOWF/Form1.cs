namespace MEUPROJETOWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void focoPeso(object sender, EventArgs e)
        {
            txtPeso.BackColor = Color.Red;
            txtAltura.BackColor = Color.White;
        }

        private void focoAltura(object sender, EventArgs e)
        {
            txtAltura.BackColor = Color.Red;
            txtPeso.BackColor = Color.White;
        }

        private void gerarNumeros(object sender, EventArgs e)
        {
            if (txtPeso.BackColor == "Red")
            {
                txtPeso.Text = ((Button)sender).Text;
            }
            else if (txtAltura.BackColor == -Color.Red)
            {
                txtAltura.Text += ((Button)sender).Text;
            }
        }
