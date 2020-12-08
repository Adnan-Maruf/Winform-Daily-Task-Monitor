using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Daily_Task
{
    public partial class SingleTask : UserControl
    {
        public SingleTask()
        {
            InitializeComponent();
        }

        private void btn_active_Click(object sender, EventArgs e)
        {
            if (btn_active.Text.Equals("Active"))
            {
                btn_active.Text = "Deactive";
            }
            else if (btn_active.Text.Equals("Deactive"))
            {
                btn_active.Text = "Active";
            }
        }

        private void btn_active_TextChanged(object sender, EventArgs e)
        {
            if (btn_active.Text.Equals("Active"))
            {
                btn_active.BackColor = ColorTranslator.FromHtml("#80ff80");
            }
            else if (btn_active.Text.Equals("Deactive"))
            {
                btn_active.BackColor = ColorTranslator.FromHtml("#ff1a1a");
            }
        }
    }
}
