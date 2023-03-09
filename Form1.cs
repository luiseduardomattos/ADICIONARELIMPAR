using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADICIONARELIMPAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btonAd_Click(object sender, EventArgs e)
        {
            if (textBoxNome.TextLength== 0)
                MessageBox.Show ("Por favor digite algo!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxNome.Focus();
            { 
            comboBox1.Items.Add(textBoxNome.Text);
            textBoxNome.Clear();
            textBoxNome.Focus();
            }
        }

        private void btnRm_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                MessageBox.Show("Por favor, selecione um item", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxNome.Focus();
            { 
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                comboBox1.SelectedIndex = 0;    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        //    comboBox1.SelectedIndex = 0;
        }
    }
}
