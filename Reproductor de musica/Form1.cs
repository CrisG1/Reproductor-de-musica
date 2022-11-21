using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor_de_musica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.settings.volume = 25;
        }
        string[] archivo, ruta;
        int cont;
        private void btnelegir_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
                MessageBox.Show("Se elimino la lista anterior", "SISTEMA");  
            }
            OpenFileDialog File = new OpenFileDialog();
            File.Multiselect = true;
            File.Filter = "Media Files|*.mpg;*.avi;*.wma;*.mov;*.wav;*.mp2;*.mp3;*.mp4|All Files|*.*";
            if (File.ShowDialog() == DialogResult.OK)
            {
                archivo = File.SafeFileNames;
                ruta = File.FileNames;
                for (int i = 0; i < archivo.Length; i++)
                {
                    listBox1.Items.Add(archivo[i]);
                }
            }
        }
    
        private void btnreproducir_Click(object sender, EventArgs e)
        {   
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No hay canciones para reproducir, porfavor agregar...", "SISTEMA");
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();  
                btnpausar.BringToFront();
            }
        }
        private void btnpausar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            btnreproducir.BringToFront();
        }

        private void btnparar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            btnreproducir.BringToFront();
        }
        private void mtbvolume_ValueChanged(object sender, decimal value)
        {
            axWindowsMediaPlayer1.settings.volume = mtbvolume.Value;
            label2.Text = mtbvolume.Value.ToString();
            if (mtbvolume.Value == 0)
            {
                button1.BringToFront();
            }
            else
            {
                button2.BringToFront();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Datos();
            mtbvolume.Value = axWindowsMediaPlayer1.settings.volume;
            mtbbarra.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            label2.Text = mtbvolume.Value.ToString();
            //axWindowsMediaPlayer1.
        }
        public void Datos()
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                timer1.Start();
            }else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused){
                timer1.Stop();              

            }else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped){
                timer1.Stop();
               
            }
        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            Datos(); 
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            cont = listBox1.SelectedIndex;
            cont += 1;
            if (listBox1.Items.Count == cont && listBox1.Items.Count > 0)
            {
            cont = 0;
            listBox1.SetSelected(cont, true);
            }
            else if (listBox1.Items.Count > 0)
            {
            listBox1.SetSelected(cont,true);

            }
            else
            {
                MessageBox.Show("No hay medio para saltar", "SISTEMA");
            } 
           Datos();
        }
        private void btnleft_Click(object sender, EventArgs e)
        {
            cont = listBox1.SelectedIndex;
            cont += 1;
            if (listBox1.Items.Count == cont && listBox1.Items.Count > 0)
            {
                cont = 0;
                listBox1.SetSelected(cont, true);
            }
            else if (listBox1.Items.Count > 0)
            {
                listBox1.SetSelected(cont, true);

            }
            else
            {
                MessageBox.Show("No hay medio para saltar", "SISTEMA");
            }
            Datos();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            cont = mtbvolume.Value;
            button1.BringToFront();
            mtbvolume.Value = 0;
            label2.Text = mtbvolume.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.BringToFront();
            mtbvolume.Value = cont;
            label2.Text = mtbvolume.Value.ToString();
        }

        private void mtbbarra_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = mtbbarra.Value;
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Seleccione cancion para eliminar del listado", "SISTEMA", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                //listBox1.Items.RemoveAt(archivo);
                listBox1.Items.Remove(listBox1.SelectedItem);
                MessageBox.Show("Se elimino la canción", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {   
            try
            { 
                axWindowsMediaPlayer1.URL = ruta[listBox1.SelectedIndex];              
                btnpausar.BringToFront();
            }
            catch (Exception)
            {
    
            }  
        }
       
    }
}
