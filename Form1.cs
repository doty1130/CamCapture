using AForge.Video;
using AForge.Video.DirectShow;
using System.Diagnostics;

namespace CamControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            FilterInfoCollection filterIC;
            VideoCaptureDevice VCDevice;
            
        
        int res = 0;
        private void StartButton_Click(object sender, EventArgs e)
        {
            VCDevice = new VideoCaptureDevice(filterIC[cbo_Cams.SelectedIndex].MonikerString);
            VCDevice.VideoResolution = VCDevice.VideoCapabilities[5];
            VCDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VCDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Pic.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

                
                filterIC = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo filterInfo in filterIC)
                {
                    cbo_Cams.Items.Add(filterInfo.Name);
                }
                cbo_Cams.SelectedIndex = 0;
                VCDevice = new VideoCaptureDevice();
                
                

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VCDevice.IsRunning == true)
            {
                try
                {
                    VCDevice.SignalToStop();
                }
                catch (Exception ex)
                {
                    VCDevice.Stop();
                    Debug.Print(ex.Message.ToString());
                }
            }
        }
    }
}