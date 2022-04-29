using System;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;

namespace Programa_STPMJ
{
    class Funcoes
    {
        
        public void CarregarCamera()
        {
            //filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //foreach (FilterInfo filterInfo in filterInfoCollection)
            //    formCadastro.cboxCamera.Items.Add(filterInfo.Name);
            //formCadastro.cboxCamera.SelectedIndex = 0;
            //videoCaptureDevice = new VideoCaptureDevice();
        }
        public void IniciarCamera()
        {

            //if (!CameraOn)
            //{
            //    videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[formCadastro.cboxCamera.SelectedIndex].MonikerString);
            //    videoCaptureDevice.NewFrame += new NewFrameEventHandler(VideoCaptureDevice_NewFrame);
            //    CameraOn = true;
            //    videoCaptureDevice.Start();
            //}
        }

        public void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //imgCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }
    }
}
