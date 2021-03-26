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

namespace BreederReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSelectFile = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\djapo\AppData\local\Radiant",
                Title = "Select save game file",

                //  check file and path
                CheckFileExists = true,
                CheckPathExists = true,

                RestoreDirectory = true
            };

            if (ofdSelectFile.ShowDialog() == DialogResult.OK)
            {
                tbxSelectedFile.Text = ofdSelectFile.FileName;
            }
        }

        //private void btnBrowse_Click(object sender, EventArgs e)
        //{
        //    int size = -1;
        //    OpenFileDialog ofdSelectFile = new System.Windows.Forms.OpenFileDialog();
        //    DialogResult result = ofdSelectFile.ShowDialog();   //  show the dialog
        //    if (result == DialogResult.OK)  //  test result
        //    {
        //        string file = ofdSelectFile.FileName;
        //        tbxSelectedFile.Text = file;

        //        try
        //        {

        //        }
        //        catch (IOException)
        //        {

        //        }
        //    }
        //}
    }
}
