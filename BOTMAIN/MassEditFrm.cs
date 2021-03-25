using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOTMAIN
{
    public partial class MassEditFrm : Form
    {
        public string MassURL = "";
        public MassEditFrm()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(MassText.Text=="")
            {
                MassText.LineIdleColor = Color.Red;
                MassText.LineMouseHoverColor = Color.Red;
            }
            else
            {
                MassURL = MassText.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void MassText_OnValueChanged(object sender, EventArgs e)
        {
            MassText.LineIdleColor = Color.Gray;
            MassText.LineMouseHoverColor = Color.White;
        }
    }
}
