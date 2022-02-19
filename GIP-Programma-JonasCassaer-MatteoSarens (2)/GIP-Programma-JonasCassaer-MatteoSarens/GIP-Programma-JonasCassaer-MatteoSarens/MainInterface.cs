using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;

namespace GIP_Programma_JonasCassaer_MatteoSarens
{

    public partial class MainInterface : Form
    {
        

        public MainInterface()
        {
            InitializeComponent();
            dgvGegevenstabel.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblTitel.Text = "Home";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnlocation_Click(object sender, EventArgs e)
        {
            lblTitel.Text = "Location";
            
        }





        // MENU HOVER COLOR CHANGE BUTTONS

        private void btnlocation_MouseHover(object sender, EventArgs e)
        {
            btnlocation.BackColor = Color.FromArgb(122, 194, 84);
        }

        private void btnTemperature_MouseHover(object sender, EventArgs e)
        {
            btnTemperature.BackColor = Color.FromArgb(122, 194, 84);
        }

        private void btnhumidity_MouseHover(object sender, EventArgs e)
        {
            btnhumidity.BackColor = Color.FromArgb(122, 194, 84);
        }

        private void btn25micro_MouseHover(object sender, EventArgs e)
        {
            btn25micro.BackColor = Color.FromArgb(122, 194, 84);
        }

        private void btn10micro_MouseHover(object sender, EventArgs e)
        {
            btn10micro.BackColor = Color.FromArgb(122, 194, 84);
        }

        private void btnSettings_MouseHover(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(122, 194, 84);
        }


        //MENU HOVER COLOR BUTTON RESTORE

        private void btnlocation_MouseLeave(object sender, EventArgs e)
        {
            btnlocation.BackColor = Color.FromArgb(94,94,94);
        }

        private void btnTemperature_MouseLeave(object sender, EventArgs e)
        {
            btnTemperature.BackColor = Color.FromArgb(94, 94, 94);
        }

        private void btnhumidity_MouseLeave(object sender, EventArgs e)
        {
            btnhumidity.BackColor = Color.FromArgb(94, 94, 94);
        }

        private void btn25micro_MouseLeave(object sender, EventArgs e)
        {
            btn25micro.BackColor = Color.FromArgb(94, 94, 94);
        }

        private void btn10micro_MouseLeave(object sender, EventArgs e)
        {
            btn10micro.BackColor = Color.FromArgb(94, 94, 94);
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(94, 94, 94);
        }

        private void lblTitel_Click(object sender, EventArgs e)
        {

        }


        //BUTTON CLICK INSTRUCTIONS

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            lblTitel.Text = "Temperature";
            dgvGegevenstabel.Visible = true;
        }

        private void btnhumidity_Click(object sender, EventArgs e)
        {
            lblTitel.Text = "Humidity";
            dgvGegevenstabel.Visible = true;
        }

        private void btn25micro_Click(object sender, EventArgs e)
        {
            lblTitel.Text = "2,5µm";
            dgvGegevenstabel.Visible = true;
        }

        private void btn10micro_Click(object sender, EventArgs e)
        {
            lblTitel.Text = "10µm";
            dgvGegevenstabel.Visible = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            lblTitel.Text = "Settings";
            dgvGegevenstabel.Visible = true;
        }



    }
}
