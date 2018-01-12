using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning
{
    public partial class Ch2Video : Form
    {
       
        public Ch2Video()
        {
            InitializeComponent();
        }

        public static void OpenForm()
        {
            Application.Run(new Chapter2());
        }
        private void back_pnl_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenForm));
            this.Close();
            t.Start();
        }
    }
}
