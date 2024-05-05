namespace pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
            groupBox1.Parent = pictureBox1;
            groupBox1.BackColor = Color.Transparent;
            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;
            label7.Parent = pictureBox1;
            label7.BackColor = Color.Transparent;
            label8.Parent = pictureBox1;
            label8.BackColor = Color.Transparent;
            label9.Parent = pictureBox1;
            label9.BackColor = Color.Transparent;
            label10.Parent = pictureBox1;
            label10.BackColor = Color.Transparent;
            label11.Parent = pictureBox1;
            label11.BackColor = Color.Transparent;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            listBox6.Items.Add(label12.Text + " " + label13.Text + " " + label14.Text + " " + label15.Text + " " + label16.Text + " " + label17.Text);






        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = checkBox3.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label13.Text = checkBox2.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label14.Text = checkBox1.Text;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label15.Text = checkBox4.Text;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label16.Text = checkBox5.Text;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            label17.Text = checkBox6.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            label12.Text = " ";
            label13.Text= " ";
            label14.Text = " ";
            label15.Text = " ";
            label16.Text = " ";
            label17.Text = " ";

        }
    }
}
