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
    public partial class PincoPallino : Form
    {
        public bool[] Btn = new bool[16];
        public string n, n2;
        public int v = 16;
        public List<Button> btns = new List<Button>();

        public PincoPallino(string s, string s2)
        {
            CenterToScreen();
            InitializeComponent();
            n = s;
            n2 = s2;
            Loading();
            btns.Add(B1);
            btns.Add(B2);
            btns.Add(B3);
            btns.Add(B4);
            btns.Add(B5);
            btns.Add(B6);
            btns.Add(B7);
            btns.Add(B8);
            btns.Add(B9);
            btns.Add(B10);
            btns.Add(B11);
            btns.Add(B12);
            btns.Add(B13);
            btns.Add(B14);
            btns.Add(B15);
            btns.Add(B16);
        }

        public void Loading()
        {
            Random rnd = new Random();
            int r = rnd.Next(0, 10);

            if (r % 2 == 0)
            {
                string temp = n;
                n = n2;
                n2 = temp;
            }
            for (int i = 0; i < 16; i++)
            {
                Btn[i] = false;
            }

            Nome.Text = n;
            FineTurno.Enabled = false;
        }

        public void CheckWin()
        {
            int sum = 0;
            foreach (bool b in Btn)
            {
                if (b)
                {
                    sum++;
                }
            }

            FineTurno.Enabled = true;

            if (sum == 15)
            {
                B1.Enabled = false;
                B2.Enabled = false;
                B3.Enabled = false;
                B4.Enabled = false;
                B5.Enabled = false;
                B6.Enabled = false;
                B7.Enabled = false;
                B8.Enabled = false;
                B9.Enabled = false;
                B10.Enabled = false;
                B11.Enabled = false;
                B12.Enabled = false;
                B13.Enabled = false;
                B14.Enabled = false;
                B15.Enabled = false;
                B16.Enabled = false;
                FineTurno.Enabled = false;
                MessageBox.Show(n+" ha vinto!", "Fine partita");
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Btn[0] = true;
            B1.Visible = false;
            for (int i = 7; i < 16; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            CheckWin();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Btn[1] = true;
            B2.Visible = false;
            for (int i = 7; i < 16; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            CheckWin();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Btn[2] = true;
            B3.Visible = false;
            for (int i = 7; i < 16; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            CheckWin();
        }

        private void B4_Click(object sender, EventArgs e)
        {
            Btn[3] = true;
            B4.Visible = false;
            for (int i = 7; i < 16; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            CheckWin();
        }

        private void B5_Click(object sender, EventArgs e)
        {
            Btn[4] = true;
            B5.Visible = false;
            for (int i = 7; i < 16; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            CheckWin();
        }

        private void B6_Click(object sender, EventArgs e)
        {
            Btn[5] = true;
            B6.Visible = false;
            for (int i = 7; i < 16; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            CheckWin();
        }

        private void B7_Click(object sender, EventArgs e)
        {
            Btn[6] = true;
            B7.Visible = false;
            for (int i = 7; i < 16; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            CheckWin();
        }

        private void B8_Click(object sender, EventArgs e)
        {
            Btn[7] = true;
            B8.Visible = false;
            for (int i = 0; i < 7; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            for (int i = 12; i < 16; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            CheckWin();
        }

        private void B9_Click(object sender, EventArgs e)
        {
            Btn[8] = true;
            B9.Visible = false;
            for (int i = 0; i < 7; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            for (int i = 12; i < 16; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            CheckWin();
        }

        private void B10_Click(object sender, EventArgs e)
        {
            Btn[9] = true;
            B10.Visible = false;
            for (int i = 0; i < 7; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            for (int i = 12; i < 16; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            CheckWin();
        }

        private void B11_Click(object sender, EventArgs e)
        {
            Btn[10] = true;
            B11.Visible = false;
            for (int i = 0; i < 7; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            for (int i = 12; i < 16; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            CheckWin();
        }

        private void B12_Click(object sender, EventArgs e)
        {
            Btn[11] = true;
            B12.Visible = false;
            for (int i = 0; i < 7; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            for (int i = 12; i < 16; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            CheckWin();
        }

        private void B13_Click(object sender, EventArgs e)
        {
            Btn[12] = true;
            B13.Visible = false;
            for (int i = 0; i < 12; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            btns.ElementAt(15).Enabled = false;
            CheckWin();
        }

        private void B14_Click(object sender, EventArgs e)
        {
            Btn[13] = true;
            B14.Visible = false;
            for (int i = 0; i < 12; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            btns.ElementAt(15).Enabled = false;
            CheckWin();
        }

        private void B15_Click(object sender, EventArgs e)
        {
            Btn[14] = true;
            B15.Visible = false;
            for (int i = 0; i < 12; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            btns.ElementAt(15).Enabled = false;
            CheckWin();
        }

        private void B16_Click(object sender, EventArgs e)
        {
            Btn[15] = true;
            B16.Visible = false;
            for (int i = 0; i < 15; i++)
            {
                btns.ElementAt(i).Enabled = false;
            }
            CheckWin();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            B1.Visible = true;
            B2.Visible = true;
            B3.Visible = true;
            B4.Visible = true;
            B5.Visible = true;
            B6.Visible = true;
            B7.Visible = true;
            B8.Visible = true;
            B9.Visible = true;
            B10.Visible = true;
            B11.Visible = true;
            B12.Visible = true;
            B13.Visible = true;
            B14.Visible = true;
            B15.Visible = true;
            B16.Visible = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            B4.Enabled = true;
            B5.Enabled = true;
            B6.Enabled = true;
            B7.Enabled = true;
            B8.Enabled = true;
            B9.Enabled = true;
            B10.Enabled = true;
            B11.Enabled = true;
            B12.Enabled = true;
            B13.Enabled = true;
            B14.Enabled = true;
            B15.Enabled = true;
            B16.Enabled = true;
            Loading();
        }

        private void Keys_Click(object sender, EventArgs e)
        {
            B8.Text = "Q";
            B9.Text = "W";
            B10.Text = "E";
            B11.Text = "R";
            B12.Text = "T";
            B13.Text = "A";
            B14.Text = "S";
            B15.Text = "D";
            B16.Text = "Z";
        }

        private void Keys2_Click(object sender, EventArgs e)
        {
            B8.Text = "8";
            B9.Text = "9";
            B10.Text = "10";
            B11.Text = "11";
            B12.Text = "12";
            B13.Text = "13";
            B14.Text = "14";
            B15.Text = "15";
            B16.Text = "16";
        }

        private void FineTurno_Click(object sender, EventArgs e)
        {
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            B4.Enabled = true;
            B5.Enabled = true;
            B6.Enabled = true;
            B7.Enabled = true;
            B8.Enabled = true;
            B9.Enabled = true;
            B10.Enabled = true;
            B11.Enabled = true;
            B12.Enabled = true;
            B13.Enabled = true;
            B14.Enabled = true;
            B15.Enabled = true;
            B16.Enabled = true;

            string temp = n;
            n = n2;
            n2 = temp;

            Nome.Text = n;

            FineTurno.Enabled = false;
        }
    }
}
