using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB1_Namay.BussinessEntity;
namespace TB1_Namay
{
    public partial class Form1 : Form
    {

        protected Bitmap mapa { get; set; }
        protected Bitmap personaje { get; set; }
        protected Bitmap Enemigo { get; set; }
        protected CPersonaje objPersonaje { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mapa = new Bitmap("mapa.png");
            personaje = new Bitmap("Personaje.png");
            Enemigo = new Bitmap("enemigo.png");

            objPersonaje = new CPersonaje();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Graphics  g = this.CreateGraphics();

            BufferedGraphicsContext  espacio = BufferedGraphicsManager.Current;
            BufferedGraphics  buffer = espacio.Allocate(g, this.ClientRectangle);

            Rectangle elmapa = new Rectangle(0, 0, 900, 544);
            //bmpMapa->MakeTransparent(bmpMapa->GetPixel(1, 1));
            buffer.Graphics.DrawImage(mapa, 15, 20, elmapa, GraphicsUnit.Pixel);

            //MyForm::Text = "Pos X: " + personaje->getX().ToString() + " Pos Y: " + personaje->getY().ToString();

            objPersonaje.Mover(buffer, personaje);
        }

        private void MoverPersonaje(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    objPersonaje.Direccion = Direcciones.Izquierda;
                    break;
                case Keys.Right:
                    objPersonaje.Direccion = Direcciones.Derecha;
                    break;
                case Keys.Up:
                    objPersonaje.Direccion = Direcciones.Arriba;
                    break;
                case Keys.Down:
                    objPersonaje.Direccion = Direcciones.Abajo;
                    break;
               
                
            }
        }
    }
}
