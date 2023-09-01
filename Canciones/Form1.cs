using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Canciones
{
    public partial class frmCanciones : Form
    {
        public frmCanciones()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void frmCanciones_Load(object sender, EventArgs e)
        {
            wmpCanciones.uiMode = "none";
            
            StreamReader sr = new StreamReader("Videos.txt");

            string linea;
            
            while(sr.EndOfStream == false) 
            {
                linea = sr.ReadLine();
                string[] datos = linea.Split(',');
                cbTemas.Items.Add(datos[2]);

            }
            cbTemas.SelectedIndex = 0;
            sr.Close();
            sr.Dispose();
        }

        private void cbTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cancion = "video" + (cbTemas.SelectedIndex + 1).ToString() + ".mp4";
            wmpCanciones.URL = cancion;
        }
    }
}
