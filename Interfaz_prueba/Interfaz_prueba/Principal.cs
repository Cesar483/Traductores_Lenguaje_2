using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Interfaz_prueba
{
    public partial class Principal : Form
    {
    //***Opciones del menú****
        public Principal()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.BackColor = System.Drawing.Color.LightGreen;    
        }

// ****IP****
        private void Ipbutton_Click(object sender, EventArgs e)
        {
            Regex rge = new Regex(@"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(\.|$)){4}\b");
            if (rge.IsMatch(IpTextbox()))
            {
                this.ipRegEx_Pass.Text = "Valida";
                this.ipRegEx_Pass.BackColor = Color.Green;
            }
            else
            {
                this.ipRegEx_Pass.Text = "Invalida";
                this.ipRegEx_Pass.BackColor = Color.Red;
            }
        }
        private string IpTextbox()
        {
            string ipvalidated = this.ipTextBox.Text;
            return ipvalidated;
        }


 //  Botón de salir
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            //Finalizar app
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
//Mes y día de la semana******
        private void MyDbutton_Click(object sender, EventArgs e)
        { 
                Regex rge = new Regex(@"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$");
                if (rge.IsMatch(MyDTextbox()))
                {
                    this.MyDRegEx_Pass.Text = "Valida";
                    this.MyDRegEx_Pass.BackColor = Color.Green;
                }
                else
                {
                    this.MyDRegEx_Pass.Text = "Invalida";
                    this.MyDRegEx_Pass.BackColor = Color.Red;
                }
            }
            private string MyDTextbox()
            {

                string MyDvalidated = this.MyDiTextBox.Text;
                return MyDvalidated;
            }
       

        }
    }

