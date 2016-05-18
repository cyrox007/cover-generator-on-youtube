using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assistant_of_the_player
{
    class Values
    {
        //Form1 f;
        private string textValue;
        public string TextValue
        {
            get
            {
                return textValue;
            }
            set
            {
                textValue = value;
                
                //f.PicbImage_Update();
            }
        }
        private string fileWey;
        public string FileWey
        {
            get
            {
                return fileWey;
            }
            set
            {
                fileWey = value;
            }
        }

        private int Wpoint;
        public int WPoint
        {
            get
            {
                return Wpoint;
            }
            set
            {
                Wpoint = value;
            }
        }
        private double Hpoint;
        public double HPoint
        {
            get
            {
                return Hpoint;
            }
            set
            {
                Hpoint = value;
            }
        }

    }
}
