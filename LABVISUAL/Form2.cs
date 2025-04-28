using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LABVISUAL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Creamos variables para usarlas luego
        String Nombre, Grado, Seccion, Telefono, Matricula, Ciclo, Codigo, Clave, Cumple, Direccion, Alergias;

        private void button2_Click(object sender, EventArgs e)
        {   //BOTON EDITAR
            //Cambia/Edita los valores de la fila seleccionada por otros escritos en los textBox
            //Es el mismo codigo por textBox ya que cada uno ocupa una celda de la fila
            dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
            dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
            dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text;
            dataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;
            dataGridView1.CurrentRow.Cells[4].Value = textBox5.Text;
            dataGridView1.CurrentRow.Cells[5].Value = textBox6.Text;
            dataGridView1.CurrentRow.Cells[6].Value = textBox7.Text;
            dataGridView1.CurrentRow.Cells[7].Value = textBox8.Text;
            dataGridView1.CurrentRow.Cells[8].Value = textBox9.Text;
            dataGridView1.CurrentRow.Cells[9].Value = textBox10.Text;
            dataGridView1.CurrentRow.Cells[10].Value = textBox11.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {   //BOTON BORRAR
            //Elimina la fila seleccionada
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Almacena/Registra los datos de cada celda
            //Es el mismo codigo por textBox ya que cada uno ocupa una celda de la fila
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //BOTON GUARDAR
            Nombre = textBox1.Text;     //Asignar una variable al textBox
            Grado = textBox2.Text;     //Asignar una variable al textBox
            Seccion = textBox3.Text;     //Asignar una variable al textBox
            Telefono = textBox4.Text;     //Asignar una variable al textBox
            Matricula = textBox5.Text;     //Asignar una variable al textBox
            Ciclo = textBox6.Text;     //Asignar una variable al textBox
            Codigo = textBox7.Text;     //Asignar una variable al textBox
            Clave = textBox8.Text;     //Asignar una variable al textBox
            Cumple = textBox9.Text;     //Asignar una variable al textBox
            Direccion = textBox10.Text;     //Asignar una variable al textBox
            Alergias = textBox11.Text;     //Asignar una variable al textBox
            dataGridView1.Rows.Add(Nombre, Grado, Seccion, Telefono, Matricula, Ciclo, Codigo, Clave, Cumple, Direccion, Alergias);
        //Colocamos los textBoxs en el dataGRid para que se alamacenen los datso en cada celda correspondiente 
            
            textBox1.Text = ""; //Vaciar las cajas de texto cuando se hayan almacenado los datos en la tabla
            textBox2.Text = ""; //Vaciar las cajas de texto cuando se hayan almacenado los datos en la tabla
            textBox3.Text = ""; //Vaciar las cajas de texto cuando se hayan almacenado los datos en la tabla
            textBox4.Text = ""; //Vaciar las cajas de texto cuando se hayan almacenado los datos en la tabla
            textBox5.Text = ""; //Vaciar las cajas de texto cuando se hayan almacenado los datos en la tabla
            textBox6.Text = ""; //Vaciar las cajas de texto cuando se hayan almacenado los datos en la tabla
            textBox7.Text = ""; //Vaciar las cajas de texto cuando se hayan almacenado los datos en la tabla
            textBox8.Text = ""; //Vaciar las cajas de texto cuando se hayan almacenado los datos en la tabla
            textBox9.Text = ""; //Vaciar las cajas de texto cuando se hayan almacenado los datos en la tabla
            textBox10.Text = ""; //Vaciar las cajas de texto cuando se hayan almacenado los datos en la tabla
            textBox11.Text = ""; //Vaciar las cajas de texto cuando se hayan almacenado los datos en la tabla
        }
    }
}
