using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cesa.Ferramentas
{    
    public partial class FrmCapturarFoto : Form
    {
        FilterInfoCollection _filterInfoCollection;
        VideoCaptureDevice _videoCaptureDevice;
        public FrmCapturarFoto()
        {
            InitializeComponent();

            _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in _filterInfoCollection)
                cb_combo.Items.Add(filterInfo.Name);

            cb_combo.SelectedIndex = 0;
            _videoCaptureDevice = new VideoCaptureDevice();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[cb_combo.SelectedIndex].MonikerString);

            _videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            _videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs e)
        {
            pictureStream.Image = (Bitmap)e.Frame.Clone();
        }

        private void BtnCapturar_Click(object sender, EventArgs e)
        {
            // Captura a Imagem da Stream para captura
            Clipboard.Clear();
            Clipboard.SetImage(pictureStream.Image);
            pictureCaptura.Image = Clipboard.GetImage();
            Clipboard.Clear();

            string nome = txtNome.Text;

            // Escolhe onde vai salvar a captura da imagem da tela
            pictureCaptura.Image.Save(@"C:\cesa\img\foto-" + nome+".png", System.Drawing.Imaging.ImageFormat.Png);
            LimparCampo();
        }

        private void LimparCampo()
        {
            txtNome.Text = "";
            txtNome.Focus();
        }

        private void Encerrar()
        {
            if (!(_videoCaptureDevice == null))
                if (_videoCaptureDevice.IsRunning)
                {
                    _videoCaptureDevice.NewFrame -= VideoCaptureDevice_NewFrame;
                    _videoCaptureDevice.SignalToStop();
                    _videoCaptureDevice = null;
                }
        }

        private void BtnEncerrar_Click(object sender, EventArgs e)
        {
            Encerrar();
        }

        private void CapturarFoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Encerrar();
        }

        private void FrmCapturarFoto_Load(object sender, EventArgs e)
        {

        }
    }
}
