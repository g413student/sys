using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int a, b, c;

            if (!(int.TryParse(tbA.Text, out a) && (int.TryParse(tbB.Text, out b) && (int.TryParse(tbC.Text, out c)))))
            {
                labelResult.Text = "Некорректно введены строны треугольника!";
                return;
            }

            string TriangleType = Method.CheckTriangle(a, b, c);
            labelResult.Text = "Треугольник: " + TriangleType;
        }
    }
}
