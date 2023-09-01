
namespace Canciones
{
    partial class frmCanciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCanciones));
            this.wmpCanciones = new AxWMPLib.AxWindowsMediaPlayer();
            this.cbTemas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.wmpCanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpCanciones
            // 
            this.wmpCanciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmpCanciones.Enabled = true;
            this.wmpCanciones.Location = new System.Drawing.Point(12, 12);
            this.wmpCanciones.Name = "wmpCanciones";
            this.wmpCanciones.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpCanciones.OcxState")));
            this.wmpCanciones.Size = new System.Drawing.Size(699, 362);
            this.wmpCanciones.TabIndex = 0;
            this.wmpCanciones.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // cbTemas
            // 
            this.cbTemas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTemas.FormattingEnabled = true;
            this.cbTemas.Location = new System.Drawing.Point(12, 392);
            this.cbTemas.Name = "cbTemas";
            this.cbTemas.Size = new System.Drawing.Size(699, 21);
            this.cbTemas.TabIndex = 1;
            this.cbTemas.SelectedIndexChanged += new System.EventHandler(this.cbTemas_SelectedIndexChanged);
            // 
            // frmCanciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 426);
            this.Controls.Add(this.cbTemas);
            this.Controls.Add(this.wmpCanciones);
            this.Name = "frmCanciones";
            this.Text = "Canciones";
            this.Load += new System.EventHandler(this.frmCanciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpCanciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpCanciones;
        private System.Windows.Forms.ComboBox cbTemas;
    }
}

