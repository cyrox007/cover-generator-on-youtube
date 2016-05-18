using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace assistant_of_the_player
{
    public partial class Form1 : Form
    {
        Values v = new Values();
        ColorDialog cd = new ColorDialog();
        string rbch = null;
        public Form1()
        {
            InitializeComponent();
        }
        public void PicbImage_Update()
        {
            //Image img = Image.FromFile(v.FileWey);
            try
            {
                pbImage.Image = Image.FromFile(v.FileWey);
                using (Graphics g = Graphics.FromImage(pbImage.Image))
                {
                    Font drawFont = new Font(cbFonts.Text, float.Parse(cbFontSize.Text));
                    SolidBrush drawBrush = new SolidBrush(cd.Color);
                    g.DrawString(rbch + " " + v.TextValue, drawFont, drawBrush, new Point(v.WPoint, (int)v.HPoint));
                    lWidHeight.Text = v.WPoint.ToString() + " / " + v.HPoint;
                }
                pbImage.Visible = false;
                pbImage.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbDop_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbDop.Checked)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                rbch = null;
            }
            else
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                
            }
            PicbImage_Update();
        }

        //private void tbText_TextChanged(object sender, EventArgs e)
        //{
        //    v.TextValue = tbText.Text;
        //    PicbImage_Update();
        //}

        private void btViewFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = ofd.FileName;
                v.FileWey = ofd.FileName;
                Image img2 = Image.FromFile(v.FileWey);
                tbhW.Maximum = img2.Width;
                tbvH.Minimum = 0 - img2.Height;
                PicbImage_Update();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (cd.ShowDialog() == DialogResult.OK)
            {
                PicbImage_Update();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach(FontFamily font in fonts.Families)
            {
                cbFonts.Items.Add(font.Name);
            }
        }

        private void cbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            PicbImage_Update();
        }

        private void cbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            PicbImage_Update();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                rbch = radioButton1.Text;
            }
            PicbImage_Update();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                rbch = radioButton2.Text;
            }
            PicbImage_Update();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                rbch = radioButton3.Text;
            }
            PicbImage_Update();
        }

        private void tbhW_Scroll(object sender, EventArgs e)
        {
            v.WPoint = tbhW.Value;
            PicbImage_Update();
        }

        private void tbvH_Scroll(object sender, EventArgs e)
        {
            v.HPoint = Math.Sqrt(tbvH.Value * tbvH.Value);
            PicbImage_Update();
        }

        private void nudValue_ValueChanged(object sender, EventArgs e)
        {
            v.TextValue = nudValue.Value.ToString();
            PicbImage_Update();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!cbMultyImage.Checked)
            {
                pbImage.Image.Save(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "/image.jpg");
            }
            else
            {
                int i = (int)nudValue.Value;
                for (int j = i; j <= nudValue2.Value; j++)
                {
                    pbImage.Image = Image.FromFile(v.FileWey);
                    using (Graphics g = Graphics.FromImage(pbImage.Image))
                    {
                        Font drawFont = new Font(cbFonts.Text, float.Parse(cbFontSize.Text));
                        SolidBrush drawBrush = new SolidBrush(cd.Color);
                        g.DrawString(rbch + " " + j, drawFont, drawBrush, new Point(v.WPoint, (int)v.HPoint));
                        lWidHeight.Text = v.WPoint.ToString() + " / " + v.HPoint;
                    }
                    pbImage.Image.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + j + ".jpg");
                    pbImage.Visible = false;
                    pbImage.Visible = true;
                    
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMultyImage.Checked)
            {
                nudValue2.Enabled = true;
                label2.Enabled = true;
            }
            else
            {
                nudValue2.Enabled = false;
                label2.Enabled = false;
            }
        }
    }   
}
