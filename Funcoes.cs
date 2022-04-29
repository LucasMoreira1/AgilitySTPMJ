using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_STPMJ
{
    class Funcoes
    {
        public Boolean CameraOn = false;
        public void IniciarCamera()
        {
            {

                if (!CameraOn)
                {
                    videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboxCamera.SelectedIndex].MonikerString);
                    videoCaptureDevice.NewFrame += new NewFrameEventHandler(VideoCaptureDevice_NewFrame);
                    CameraOn = true;
                    videoCaptureDevice.Start();
                }
            }
        }
    }
}
