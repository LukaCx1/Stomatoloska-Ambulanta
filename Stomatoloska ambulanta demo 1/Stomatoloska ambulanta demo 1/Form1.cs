using Microsoft.VisualBasic.ApplicationServices;

namespace Stomatoloska_ambulanta_demo_1
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string jmbg = textBox2.Text;

            // poziva se login metoda
            Database database = new Database();
            bool loginSuccessful = database.Login(email, jmbg);

            // uporedjuju se uneti podaci sa podacima iz db
            if (loginSuccessful)
            {
                MessageBox.Show("Login uspesan!");
               

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login neuspešan.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
