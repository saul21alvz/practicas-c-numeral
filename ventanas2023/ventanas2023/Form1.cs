using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventanas2023
{
    public partial class Form1 : Form
    {
        List<List<string>> listas = new List<List<string>>();
        public Form1()
        {
            InitializeComponent();
            
        }
        string nombre, edad, sexo;

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                nombre = Txtnombre.Text;
                edad = txtedad.Text;
                sexo = txtsexo.Text;
                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(edad) || string.IsNullOrEmpty(sexo) )
                {
                    MessageBox.Show("Alguna de las casillas esta vacia");
                }
                else
                {
                    int ce = 0;
                    int cl = 0;
                    byte[] arr = Encoding.ASCII.GetBytes(nombre);
                    foreach (byte b in arr)
                    {
                        if ((char)b == 32)//contador espacio
                        {
                            ce++;
                        }
                        if ((char)b >= 65 && (char)b <= 90 || (char)b >= 97 && (char)b <= 122)//contador letras
                        {
                            cl++;
                        }
                    }
                    if (nombre.Length == ce + cl)
                    {
                        //siguiente validacion
                        int f;
                        if (int.TryParse(edad, out f))
                        {
                            //validar sexo
                            if (sexo == "h" || sexo == "m")
                            {
                                List<string> lista = new List<string>();
                                lista.Add(nombre);
                                lista.Add(edad);
                                lista.Add(sexo);
                                listas.Add(lista);
                                foreach (var i in listas)
                                {
                                    MessageBox.Show(string.Join(", ", i));
                                }                              
                            }
                            else
                            {
                                MessageBox.Show("El valor del sexo no es valido");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La edad tiene un valor no valido");
                        }
                    }
                    else
                    {
                        //mostrar que esta mal el nombre
                        MessageBox.Show("El nombre tiene valores no validos");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //lista.add(Txtnombre.ToString());
            //MessageBox.Show("hola mundo");
            //MessageBox.Show("otro mensaje");
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    



