namespace _4
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            textBox6.Text += Environment.NewLine + "�������: " + x;
            string y = textBox2.Text;
            textBox6.Text += Environment.NewLine + "���: " + y;
            string z = textBox3.Text;
            textBox6.Text += Environment.NewLine + "��������: " + z;
            if (radioButton1.Checked)
            {
                textBox6.Text += Environment.NewLine + "���: " + radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                textBox6.Text += Environment.NewLine + "���: " + radioButton2.Text;
            }
            textBox6.Text += Environment.NewLine + "���� ��������";
            textBox6.Text += Environment.NewLine + "����: " + comboBox1.Text;
            textBox6.Text += Environment.NewLine + "�����: " + comboBox2.Text;
            textBox6.Text += Environment.NewLine + "���: " + comboBox3.Text;
            textBox6.Text += Environment.NewLine + "����� ����������: " + comboBox4.Text;
            textBox6.Text += Environment.NewLine + "����� ����������� �����: " + textBox4.Text;
            textBox6.Text += Environment.NewLine + "��������� �������: " + textBox5.Text + comboBox5.Text;

            if (radioButton3.Checked)
            {
                textBox6.Text += Environment.NewLine + "����� ������: " + radioButton3.Text;
            }
            if (radioButton4.Checked)
            {
                textBox6.Text += Environment.NewLine + "����� ������: " + radioButton4.Text;
            }
            if (radioButton5.Checked)
            {
                textBox6.Text += Environment.NewLine + "����� ������: " + radioButton5.Text;
            }
            if (radioButton6.Checked)
            {
                textBox6.Text += Environment.NewLine + "����� ������: " + radioButton6.Text;
            }
            if (radioButton7.Checked)
            {
                textBox6.Text += Environment.NewLine + "����� ������: " + radioButton7.Text;
            }

            textBox6.Text += Environment.NewLine + "������ �������� ";
            if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox6.Text += Environment.NewLine + checkBox1.Text;
                textBox6.Text += Environment.NewLine + checkBox2.Text;
            }
            if (checkBox1.Checked)
            {
                textBox6.Text += Environment.NewLine + checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                textBox6.Text += Environment.NewLine + checkBox2.Text;

            }
            if (checkBox3.Checked)
            {
                textBox6.Text += Environment.NewLine + checkBox3.Text;
            }
            if (checkBox4.Checked)
            {
                textBox6.Text += Environment.NewLine + checkBox4.Text;
            }
            if (checkBox5.Checked)
            {
                textBox6.Text += Environment.NewLine + checkBox5.Text;
            }
            if (checkBox6.Checked)
            {
                textBox6.Text += Environment.NewLine + checkBox6.Text;
            }

            textBox6.Text += Environment.NewLine + "����� ���������� �����: �� " + domainUpDown1.Text + " �� " + domainUpDown2.Text;
            textBox6.Text += Environment.NewLine + "�������������� ������: ";
            if (radioButton10.Checked)
            {
                textBox6.Text += radioButton10.Text + Environment.NewLine;
            }
            if (radioButton9.Checked)
            {
                textBox6.Text += radioButton9.Text + Environment.NewLine;
            }
            if (radioButton11.Checked)
            {
                textBox6.Text += radioButton11.Text + Environment.NewLine;
            }
            if (radioButton12.Checked)
            {
                textBox6.Text += radioButton12.Text + Environment.NewLine;
            }



        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}