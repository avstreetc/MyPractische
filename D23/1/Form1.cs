using System.Globalization;

namespace _1
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

        private void button1_Click(object sender, EventArgs e)
        {
            string inputString = string.Empty;
            int count = 0;

            // �������� ��������� ������ �� ������
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                inputString += listBox1.Items[i].ToString() + " ";
            }

            // ������� ���������� �������� ������� ���� � ������
            foreach (char c in inputString)
            {
                if (c >= '�' && c <= '�')
                {
                    count++;
                }
            }
            // ������� ��������� �� �����
            label1.Text = "���������� �������� ������� ����: " + count.ToString();

        }
    }
}