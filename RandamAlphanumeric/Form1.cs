using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandamAlphanumeric
{
    public partial class Form1 : Form
    {
        private const string Letters = "abcdefghijklmnopqrstuvwxyz";
        private readonly char[] alphanumeric = (Letters + Letters.ToUpper() + "0123456789").ToCharArray();
        public Form1()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(generateAlphaNumeric(Convert.ToInt32(textBox1.Text)));
        }

        private string generateAlphaNumeric( int length) {
            StringBuilder result = new StringBuilder();
            Random rn = new Random();
            for (int i=0;i<length ; i++) {
                result.Append(alphanumeric[rn.Next(alphanumeric.Length)]);
            }
            return result.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
