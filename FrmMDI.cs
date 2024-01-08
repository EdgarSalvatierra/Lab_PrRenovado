using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Pr
{
    public partial class FrmMDI : MaterialForm
    { 
        public FrmMDI()
        {
            InitializeComponent();  
        }
        private void FrmMDI_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            FrmConfiguracion fr = new FrmConfiguracion();
            fr.Show();
        }
    }
}
