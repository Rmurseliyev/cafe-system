namespace cafe_system
{
    public partial class Form1 : Form
    {
        double total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Tort - 4.5");

            total += 4.5;

            label1.Text = "Qaytarılır: " + listBox1.Items.Count;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kofe - 3");

            total += 3;

            label1.Text = "Qaytarılır: " + listBox1.Items.Count;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Şirə - 2.5");

            total += 2.5;

            label1.Text = "Qaytarılır: " + listBox1.Items.Count;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Qızardılmış toyuq - 9");

            total += 9;

            label1.Text = "Qaytarılır: " + listBox1.Items.Count;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Burger - 6.3");

            total += 6.3;

            label1.Text = "Qaytarılır: " + listBox1.Items.Count;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Hot-doq - 4");

            total += 4;

            label1.Text = "Qaytarılır: " + listBox1.Items.Count;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Toyuq - 7");

            total += 7;

            label1.Text = "Qaytarılır: " + listBox1.Items.Count;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Pizza - 8.5");

            total += 8.5;

            label1.Text = "Qaytarılır: " + listBox1.Items.Count;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cola - 2");

            total += 2;

            label1.Text = "Qaytarılır: " + listBox1.Items.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show(
      "Xanalar sıfırlansınmı?",
      "Təsdiq",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Question
  );

            if (cavab == DialogResult.Yes)
            {
                listBox1.Items.Clear();

                total = 0;

                textBox1.Clear();

                textBox2.Clear();

                textBox3.Clear();

                label1.Text = "Qaytarılır: 0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show(
                    "Səbətdə yemək yoxdur!"
                );

                return;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show(
                    "Əvvəlcə Yekun hesab düyməsinə basın!"
                );

                return;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show(
                    "Məbləğ xanasını doldurun!"
                );

                return;
            }

            double mebleg;

            if (!double.TryParse(
                textBox1.Text.Replace(',', '.'),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out mebleg))
            {
                MessageBox.Show(
                    "Məbləği düzgün daxil edin!"
                );

                return;
            }

            if (mebleg < total)
            {
                MessageBox.Show(
                    "Daxil edilən məbləğ hesabdan azdır"
                );

                return;
            }

            double qaliq = mebleg - total;

            textBox2.Text = qaliq.ToString("0.00");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show(
                    "Səbətdə yemək yoxdur!"
                );

                return;
            }

            textBox3.Text = total.ToString("0.00");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox2.Clear();
        }
    }
}
