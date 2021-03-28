using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreApp
{
    public partial class LoadingForm : Form
    {
        int i = 0, count = 0;
        Color[] colors = { Color.Transparent, Color.WhiteSmoke, Color.Gainsboro, Color.LightGray,
                Color.Silver, Color.DarkGray, Color.Gray, Color.DimGray};
        int loadCount = 0;
        int index;
        public LoadingForm()
        {
            InitializeComponent();
            index = colors.Length - 1;
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            if (loadCount%2 == 0)
            {
                lblLoading.ForeColor = colors[index--];
                //lblLoading.Text = "" + index--;
                if (index == 0)
                {
                    loadCount++;
                }
            }else
            {
                lblLoading.ForeColor = colors[index++];
                //lblLoading.Text = "" + index++;
                if (index == colors.Length-1)
                {
                    loadCount++;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {          if (i < 10)
            {
                label1.Top -= i;
                i++;
            }
            else if (i >= 10 && i < 20)
            {
                label1.Top += i - 10;
                i++;
            }
            else if (i >= 20 && i < 30)
            {
                label2.Top -= i - 20;
                i++;
            }
            else if (i >= 30 && i < 40)
            {
                label2.Top += i - 30;
                i++;
            }
            else if (i >= 40 && i < 50)
            {
                label3.Top -= i - 40;
                i++;
            }
            else if (i >= 50 && i < 60)
            {
                label3.Top += i - 50;
                i++;
            }
            else if (i >= 60 && i < 70)
            {
                label5.Top -= i -60;
                i++;
            }
            else if (i >= 70 && i < 80)
            {
                label5.Top += i - 70;
                i++;
            }
            else
            {
                i = 1;
                count++;
            }
            if (count == 4)
            {
                timeJump.Enabled = false;
                timerLoading.Enabled = false;
                MainPanel mp = new MainPanel();

                this.Hide();
                mp.ShowDialog();
            }
        }
    }
}
