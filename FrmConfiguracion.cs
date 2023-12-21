using MaterialSkin;
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
    public partial class FrmConfiguracion : MaterialForm
    {
        /*readonly MaterialSkinManager materialSkinManager;*/
        public FrmConfiguracion()
        {
            InitializeComponent();
/*
            FrmMDI  mdiForm = Application.OpenForms.OfType<FrmMDI>().FirstOrDefault();

            if (mdiForm != null)
            {
                materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.EnforceBackcolorOnAllComponents = true;
                materialSkinManager.AddFormToManage(mdiForm);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(MaterialSkin.Primary.LightBlue200,MaterialSkin.Primary.LightBlue400,MaterialSkin.Primary.LightBlue100,MaterialSkin.Accent.Teal200,           
                TextShade.WHITE);
            }
            */
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
           
        }
    }
}
