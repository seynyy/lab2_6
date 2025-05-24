using System;
using System.Windows.Forms;
using lab2_61.Model;

namespace lab2_61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            ISolid pyramid = new Pyramid(Convert.ToDouble(tbPyramidA.Text), Convert.ToDouble(tbPyramidH.Text));
            ISolid sphere = new Sphere(Convert.ToDouble(tbSphereR.Text));

            lbPyramidVolume.Text = @"Об'єм піраміди: " + pyramid.GetVolume().ToString("F2");
            lbSphereVolume.Text = @"Об'єм кулі: " + sphere.GetVolume().ToString("F2");

        }
    }
}