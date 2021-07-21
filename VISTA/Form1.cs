using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class Form1 : Form
    {

        public MODELO.Propiedad oPropiedad;
        public MODELO.Inmobilaria oInmobiliaria = new MODELO.Inmobilaria();
        string ACCION;

        public Form1()
        {
            InitializeComponent();
            gbxCARGA.Enabled = false;
            
        }


        public void cambiarAcciones()
        {
            gbxACCIONES.Enabled = true;
            gbxCARGA.Enabled = false;
        }

        public void cambiarCarga()
        {
            gbxCARGA.Enabled = true;
            gbxACCIONES.Enabled = false;
        }

        public void GRILLA()
        {
            dgwALQUILERES.DataSource = null;
            dgwALQUILERES.DataSource = oInmobiliaria.PROPIEDADES;
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            cambiarCarga();
            ACCION = "A";
            
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            pnlTIPO.Enabled = false;
            cambiarCarga();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            pnlTIPO.Enabled = false;
            cambiarCarga();

        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            pnlTIPO.Enabled = false;
            cambiarCarga();

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGUARDAR_Click(object sender, EventArgs e)
        {
            pnlTIPO.Enabled = true;
            cambiarAcciones();

            if(ACCION == "A")
            {
                oPropiedad = new MODELO.Propiedad();
                oPropiedad.superficieCubierta = Int32.Parse(tbxCUBIERTA.Text);
                if (rbtCASA.Checked)
                {
                    oPropiedad = new MODELO.Casa();

                    ((MODELO.Casa)oPropiedad).superficieDescubierta = Int32.Parse(tbxDESCUBIERTA.Text);
                    oPropiedad.importe = ((MODELO.Casa)oPropiedad).valor;
                }

                oPropiedad.domicilioPropiedad = tbxDOMICILIO.Text;
                oPropiedad.nombrePropietario = tbxNOMBRE.Text;
                oPropiedad.telefono = Int32.Parse(tbxTELEFONO.Text);
                oPropiedad.superficieCubierta = Int32.Parse(tbxCUBIERTA.Text);

                oInmobiliaria.PROPIEDADES.Add(oPropiedad);
                

                GRILLA();

            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            pnlTIPO.Enabled = true;
            cambiarAcciones();
        }

        private void btnASIGNAR_Click(object sender, EventArgs e)
        {
            oInmobiliaria.precio_m2 = float.Parse(tbxASIGNAR.Text);
            tbxASIGNAR.Text = string.Empty;
        }

        private void rbtCASA_CheckedChanged(object sender, EventArgs e)
        {
                tbxDESCUBIERTA.Enabled = true; 
        }

        private void rbtDEPARTAMENTO_CheckedChanged(object sender, EventArgs e)
        {
            tbxDESCUBIERTA.Enabled = false;
        }
    }
}
