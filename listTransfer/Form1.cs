using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listTransfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> liste = new List<string>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            lboxSol.Items.Add(txtVeriEkle.Text);
            liste.Add(txtVeriEkle.Text);
            txtVeriEkle.Clear();
        }

        private void btnSagaTekli_Click(object sender, EventArgs e)
        {
            if (lboxSol.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Eleman Seçmediniz.");
            }
            else
            {
                for (int i = lboxSol.SelectedIndices.Count - 1; i >= 0; i--)
                {

                    labelSag.Items.Add(lboxSol.SelectedItems[i]);
                    lboxSol.Items.Remove(lboxSol.SelectedItems[i]);
                }
            }


        }

        private void btnSolaTekli_Click(object sender, EventArgs e)
        {
            if (labelSag.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Eleman Seçmediniz.");
            }
            else
            {
                for (int i = labelSag.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    lboxSol.Items.Add(labelSag.SelectedItem);
                    labelSag.Items.Remove(labelSag.SelectedItem);
                }
            }

        }

        private void btnSagaCoklu_Click(object sender, EventArgs e)
        {
            labelSag.Items.Clear();
            labelSag.Items.AddRange(liste.ToArray());
            lboxSol.Items.Clear();
        }

        private void btnSolaCoklu_Click(object sender, EventArgs e)
        {
            lboxSol.Items.Clear();
            lboxSol.Items.AddRange(liste.ToArray());
            labelSag.Items.Clear();
        }

    }
}