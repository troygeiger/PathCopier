using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PathCopier
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
            btnTopColor.BackColor = Settings.GradientTopColor;
            btnBottomColor.BackColor = Settings.GradientBottomColor;
            btnOutlineColor.BackColor = Settings.OutlineColor;
            btnTextColor.BackColor = Settings.TextColor;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Settings.GradientTopColor = btnTopColor.BackColor;
            Settings.GradientBottomColor = btnBottomColor.BackColor;
            Settings.OutlineColor = btnOutlineColor.BackColor;
            Settings.TextColor = btnTextColor.BackColor;
            Settings.Save();
            pop.Popup(new string[]{});
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            dlgColor.Color = ((Button)sender).BackColor;
            if (dlgColor.ShowDialog(this) == DialogResult.OK)
            {
                ((Button)sender).BackColor = dlgColor.Color;
                pop.GradientTopColor = btnTopColor.BackColor;
                pop.GradientBottomColor = btnBottomColor.BackColor;
                pop.TextColor = btnTextColor.BackColor;
                pop.OutlineColor = btnOutlineColor.BackColor;
                pop.Popup(null);
            }
            
        }
        frmPopup pop;

        private void Setup_Load(object sender, EventArgs e)
        {
            pop = new frmPopup();
            pop.ConfigurationMode = true;
            pop.Popup(null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}