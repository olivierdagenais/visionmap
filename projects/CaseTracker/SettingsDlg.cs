﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FogBugzCaseTracker
{
    public partial class SettingsDlg : Form
    {
        public double UserOpacity
        {
            get
            {
                return (double)numOpacity.Value / 100.0;
            }
            set
            {
                numOpacity.Value = (decimal)(100.0 * value);
            }
        }

        public Font UserFont
        {
            set
            {
                fontDialog1.Font = value;
                lblChosenFont.Text = String.Format("{0} {1}", value.Name, + value.SizeInPoints);
            }
            get
            {
                return fontDialog1.Font;

            }
        }

        public SettingsDlg()
        {
            InitializeComponent();
        }

        private void numOpacity_ValueChanged(object sender, EventArgs e)
        {
            Owner.Opacity = (double)numOpacity.Value / 100.0;
        }

        private void btnChooseFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                UserFont = fontDialog1.Font;
        }
    }
}