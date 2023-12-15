namespace WinFormsApp12
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, preencha o campo 'Nome'.", "Campo em Falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            else if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Por favor, preencha o campo 'Senha'.", "Campo em Falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Por favor, preencha o campo 'Email'.", "Campo em Falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
            }
            else
            {
                Class1 instancia = new Class1();
                instancia.Nome = textBox1.Text;

                MessageBox.Show("saved with success");
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.UseSystemPasswordChar = true;
            }
            else
            {
                textBox3.UseSystemPasswordChar = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            closefrms.closefrm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
