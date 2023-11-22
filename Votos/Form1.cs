namespace Votos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.download;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.a;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.mbapep;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.images;
            lbl1.Text = "felicidade";
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}