using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PincoPallino
{
    public partial class Main : Form
    {
        public Main()
        {
            CenterToScreen();
            InitializeComponent();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            PincoPallino pinco = new PincoPallino(Name1.Text, Name2.Text);
            Hide();
            pinco.Show();
        }
    }
}
