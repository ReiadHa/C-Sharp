

namespace lightswitch
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
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                button1.BackColor = Color.Red;
                button1.ForeColor = Color.Black;
                BackColor = Color.Blue;
                count++;
               
            }
            else if(count == 1)
            {
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;
                BackColor = Color.Red;
                count--;
                
            }
        }
    }
}