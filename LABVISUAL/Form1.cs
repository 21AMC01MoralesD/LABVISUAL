using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABVISUAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "12345") //Asignamos la contraseña del login
            { 
                Form2 v1 = new Form2(); //Decimos que v1 es la ventana del CRUD
                v1.Show(); //Mostrara la ventana del CRUD
                this.Hide(); //Ocultara la ventana del login al presionar el boton
                //Si se ingresa la contraseña correctamente, se mostrar el CRUD
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
                //En caso no ingresar la contraseña correcta, aparecera
                //un mensaje notificando de lo sucedido
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Boton para dirigir a la ventana de creditos
            Form3 v2 = new Form3();
            v2.Show();
        }
    }
}
