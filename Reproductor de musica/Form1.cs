using System;
using System.Windows.Forms;
using MySqlConnector;

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
            OpenFileDialog File = new OpenFileDialog();
            File.Multiselect = true;
            File.Filter = "Media Files|*.mpg;*.avi;*.wma;*.mov;*.wav;*.mp2;*.mp3;*.mp4|All Files|*.*";
            if (File.ShowDialog() == DialogResult.OK)
            {
                archivo = File.SafeFileNames;
                ruta = File.FileNames;
                for (int i = 0; i < archivo.Length; i++)
                {
                    dataGridView1.Rows.Add(archivo[i]);
                }
            }
        }
    
        private void btnreproducir_Click(object sender, EventArgs e)
        {   
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                btnpausar.BringToFront();
                timer1.Start();
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();  
                timer1.Stop();
            }
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
        }
        public void Datos()
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                mtbbarra.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused){
                timer1.Stop();              

            }else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped){
                timer1.Stop();
               
            }
            lblInicio.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            Datos(); 
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            cont = dataGridView1.CurrentRow.Index;
            cont += 1;
            if (dataGridView1.Rows.Count == cont && dataGridView1.Rows.Count > 0)
            {
                cont = 0;
                dataGridView1.CurrentCell.Value = cont;
            }
            else if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.CurrentCell.Value = cont;
                dataGridView1.Rows[cont].Selected = true;
            }
            else
            {
                MessageBox.Show("No hay medio para saltar", "SISTEMA");
            }
            Datos();
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            cont = dataGridView1.CurrentRow.Index;
            cont -= 1;
            if (dataGridView1.Rows.Count == cont && dataGridView1.Rows.Count > 0)
            {
                cont = 0;
                dataGridView1.CurrentCell.Value = cont;
            }
            else if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.CurrentCell.Value = cont;
                dataGridView1.Rows[cont].Selected = true;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = conexion.Consulta("Select * from canciones");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique la conexion o consulta" + ex.Message, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            axWindowsMediaPlayer1.URL = dataGridView1.Rows[index].Cells[4].Value.ToString();
            lblFinal.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            timer1.Start();
        }       
    }
}
