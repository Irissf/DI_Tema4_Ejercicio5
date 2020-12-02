using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_Tema4_Ejercicio5
{
    public partial class Form1 : Form
    {
        string cadena;
        bool icono = true;
        bool alterna = true;
        int contador;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "Lista principal " + listBox1.Items.Count;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            label1.Text = "Lista principal " + listBox1.Items.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedIndices.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                label1.Text = "Lista principal " + listBox1.Items.Count;
            }
                listBox1.ClearSelected();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //https://www.youtube.com/watch?v=de4-Aaow5q0
            while (listBox1.SelectedIndices.Count > 0)
            {
                listBox2.Items.Insert(0, listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            toolTip1.SetToolTip(listBox2, "La lista tiene: " + listBox2.Items.Count + " elementos");//nop
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, listBox2.SelectedItem);
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            toolTip1.SetToolTip(listBox2, "La lista tiene: " + listBox2.Items.Count + " elementos");//nop
        }

        private void CountItems(object sender, EventArgs e)
        { //lo encontré
           
            label2.Text = "" + listBox1.SelectedIndices.Count;
        }

        private void TimerCodigo(object sender, EventArgs e)
        {
            this.Text = ""+cadena[contador];
            if(contador == 26)
            {
                contador = 0;
            }
            else
            {
                contador++;
            }   
            
            if (icono)
            {
                //a la primera entro
                if (alterna)
                {
                    this.Icon = Icon.ExtractAssociatedIcon("mascara-de-gato (1).ico");
                    alterna = false;
                }
                else
                {
                    this.Icon = Icon.ExtractAssociatedIcon("guadana.ico");
                    alterna = true;
                }
                icono = false;
            }
            else
            { // a la siguiente no así intermitente, suman 400
                icono = true;
            }
        }

        private void Inicio(object sender, EventArgs e)
        {
            listBox1.Items.Add("Uno");
            listBox1.Items.Add("Dos");
            listBox1.Items.Add("Tres");
            listBox1.Items.Add("Cuatro");
            listBox1.Items.Add("Cinco");

            cadena = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";//27

            toolTip1.SetToolTip(listBox2, "La lista tiene: " + listBox2.Items.Count + " elementos");//nop
            toolTip1.SetToolTip(listBox1, "lista de elementos");
            toolTip1.SetToolTip(button1, "agregar un elemento");
            toolTip1.SetToolTip(button2, "Eliminar elementos");
            toolTip1.SetToolTip(button3, "traspasar de lista dos a lista uno");
            toolTip1.SetToolTip(button4, "traspasar de lista uno a lista dos");
            toolTip1.SetToolTip(textBox1, "Elementos a agregar");
            toolTip1.SetToolTip(label1, "Elementos en la lista uno");
            toolTip1.SetToolTip(label2, "Elementos de la lista uno seleccionados");
        }

      
    }
}
