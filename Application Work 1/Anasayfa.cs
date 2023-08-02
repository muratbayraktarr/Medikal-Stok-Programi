using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Application_Work_1
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        FrmUrunler fr;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr==null)
            {
                fr = new FrmUrunler();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                fr.Activate();
            }

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            
        }
        FrmStok fr2;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr2==null)
            {
                 fr2 = new FrmStok();
                 fr2.MdiParent = this;
                 fr2.Show(); 
            }
            else
            {
                fr2.Activate();
            }


        }
        FrmSiparis fr3;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr3==null)
            {
            fr3 = new FrmSiparis();
            fr3.MdiParent = this;
            fr3.Show();
            }
            else
            {
                fr3.Activate();
            }
        }
        FrmPersonel fr4;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null)
            {
                fr4 = new FrmPersonel();
                fr4.MdiParent = this;
                fr4.Show();
            }
            else
            {
                fr4.Activate();
            }
        }
    }
}
