using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBi
{
    public partial class Form2 : Form
    {
        private object Textnum2;
        private object Textnum1;
        private Action<object, EventArgs> potencia;

        public Form2()
        {
            InitializeComponent();
        }

        private void Btnproducto_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(Textnum1.Text);
            int num2 = int.Parse(Textnum2.text);
            int producto = Num1 * num2;
            MessageBox.Show("el resultado del produccto es" + producto);


        }

        private void Btnsuma_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(Textnum1.text);
            int num2 = int.Parse(Textnum2.text);
            int suma = Num1 + num2;
            MessageBox.Show("el resultado de la suma es" + suma);
        }

        private void Btnpotencia_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(Textnum1.text);
            int num2 = int.Parse(Textnum2.text);
            int num3 = 0;
            int potencia = 1;
            while (num3 != num2)
            {
                potencia = potencia * Num1;
                num3++;
            }
            MessageBox.Show("el resultado de la potencia es" + potencia );
        }

        private void Btndivicion_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(Textnum1.text);
            float num2 = float.Parse(Textnum2.text);

            if (num2 > 0)
            {
                float divicion = num1 / num2;
                MessageBox.Show("resultado es" + divicion);
            }
            else
        }


        
        


    }
}
