using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Dexterity.Bridge;
using Microsoft.Dexterity.Applications;
using Microsoft.Dexterity.Shell;

namespace PondView.AprobacionTransferencias
{
    public partial class PVSVC00100 : DexUIForm
    {
        public PVSVC00100()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}