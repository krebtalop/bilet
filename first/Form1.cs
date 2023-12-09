using System.Windows.Forms;

namespace first
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bin = boxbin.Text;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            veriler.Items.Add(txtadsoy.Text);
            veriler.Items.Add(txttc.Text);
            veriler.Items.Add(maskedTextBox1.Text);
            veriler.Items.Add(boxbin.Text);
            veriler.Items.Add(boxvaris.Text);
            veriler.Items.Add(dateTimePicker1.Text);
            veriler.Items.Add(boxsaat.Text);
   

           if (maskedTextBox1.MaskFull)
            {
                
            }
            else
            {
                MessageBox.Show("Telefon numarasý 10 hane olmalý !!!");
                veriler.Items.Clear();
            }


            int lenght = txttc.TextLength;
            if (lenght != 11)
            {
                MessageBox.Show("TC kimlik numarasý 11 hane olmalý !!!");
                veriler.Items.Clear();
            }

            if (boxsaat.SelectedIndex == -1)
            {
                MessageBox.Show("Saat seçiniz!!!");
                veriler.Items.Clear();
            }
            if (boxbin.SelectedIndex == -1)
            {
                MessageBox.Show("Biniþ þehri seçiniz!!!");
                veriler.Items.Clear();
            }
            if (boxvaris.SelectedIndex == -1)
            {
                MessageBox.Show("Varýþ þehri seçiniz!!!");
                veriler.Items.Clear();
            }
            


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string varis = boxvaris.Text;
        }



        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            double time;
            time = double.Parse(boxsaat.Text);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttondegis_Click(object sender, EventArgs e)
        {
            string temp = boxbin.Text;
            boxbin.Text = boxvaris.Text;
            boxvaris.Text = temp;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date;
            date = (dateTimePicker1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            veriler.Items.Clear();
        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
            
        }

        private void txtadsoy_TextChanged(object sender, EventArgs e)
        {
            string isim_soy = txtadsoy.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txttc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
