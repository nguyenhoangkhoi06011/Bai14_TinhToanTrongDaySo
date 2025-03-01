﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai14_TinhToanTrongDaySo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int nho = Convert.ToInt32(txtSo1.Text);
            int lon = Convert.ToInt32(txtSo2.Text);
            int chan = 0, le = 0;

            txtTC.Text = "";
            txtle.Text = "";

            for (int i = nho; i <= lon; i++)
            {
                if (i % 2 == 0)
                {
                    chan += i;
                }
                else
                {
                    le += i;
                }
            }
            txtTC.Text = chan.ToString();
            txtle.Text = le.ToString();
            txtTong.Text = (chan + le).ToString();
        }
    }
}
