namespace Bank
{
    public partial class Form1 : Form
    {
        Database database = new Database();
        Class1 class1 = new Class1();   


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

                string email = textBox1.Text;
                string passssword = textBox2.Text;  
                if(class1.Verify(email, passssword) == 200)
                {
                    label1.Text = "hoise";
                }
                else
                {
                    label1.Text = "vul";
                }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}