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
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") 
            {
                MessageBox.Show("falta informações");
            }
            else
            {
                Class1.Nome = textBox1.Text;
                Class1.Email = textBox2.Text;
                Class1.Password = textBox3.Text;

                MessageBox.Show("Foi guardado com êxito");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
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
