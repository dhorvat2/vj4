using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loto_aplikacija
{
    public partial class Form1 : Form
    {

        private Loto loto;
       
        public Form1()
        {
            InitializeComponent();
            loto=new Loto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> vrijednosti = new List<string>(); 
            vrijednosti.Add(textBox1.Text);
            vrijednosti.Add(textBox2.Text);
            vrijednosti.Add(textBox3.Text);
            vrijednosti.Add(textBox4.Text);
            vrijednosti.Add(textBox5.Text);
            vrijednosti.Add(textBox6.Text);
            vrijednosti.Add(textBox7.Text);

            bool ispravnaKombinacija = loto.UnesiUplaceneBrojeve(vrijednosti);
            if (ispravnaKombinacija == true) {
                button2.Enabled = true; 
            } 
            else { 
                button2.Enabled = false; 
                MessageBox.Show("Kombinacija uplaćenih brojeva nije ispravna!"); }

        }

        private void button2_Click(object sender, EventArgs e)

        {
            
            loto.GenerirajDobitnuKombinaciju();
            textBox8.BackColor = Color.White;
            textBox9.BackColor = Color.White;
            textBox10.BackColor = Color.White;
            textBox11.BackColor = Color.White;
            textBox12.BackColor = Color.White;
            textBox13.BackColor = Color.White;
            textBox14.BackColor = Color.White;
            textBox8.Text = loto.DobitniBrojevi[0].ToString();
            textBox9.Text = loto.DobitniBrojevi[1].ToString();
            textBox10.Text = loto.DobitniBrojevi[2].ToString();
            textBox11.Text = loto.DobitniBrojevi[3].ToString();
            textBox12.Text = loto.DobitniBrojevi[4].ToString();
            textBox13.Text = loto.DobitniBrojevi[5].ToString();
            textBox14.Text = loto.DobitniBrojevi[6].ToString();
            if (loto.UplaceniBrojevi.Contains(loto.DobitniBrojevi[0]) == true)
            {
                textBox8.BackColor = Color.Green;
            }
            if (loto.UplaceniBrojevi.Contains(loto.DobitniBrojevi[1]) == true)
            {
                textBox9.BackColor = Color.Green;
            }
            if (loto.UplaceniBrojevi.Contains(loto.DobitniBrojevi[2]) == true)
            {
                textBox10.BackColor = Color.Green;
            }
            if (loto.UplaceniBrojevi.Contains(loto.DobitniBrojevi[3]) == true)
            {
                textBox11.BackColor = Color.Green;
            }
            if (loto.UplaceniBrojevi.Contains(loto.DobitniBrojevi[4]) == true)
            {
                textBox12.BackColor = Color.Green;
            }
            if (loto.UplaceniBrojevi.Contains(loto.DobitniBrojevi[5]) == true)
            {
                textBox13.BackColor = Color.Green;
            }
            if (loto.UplaceniBrojevi.Contains(loto.DobitniBrojevi[6]) == true)
            {
                textBox14.BackColor = Color.Green;
            }

            
            int brojPogodaka = loto.IzracunajBrojPogodaka(); 
            label2.Text = brojPogodaka.ToString();
        }

        private void textBox14_BackColorChanged(object sender, EventArgs e)
        {

        }

        

        

        
    }
}
