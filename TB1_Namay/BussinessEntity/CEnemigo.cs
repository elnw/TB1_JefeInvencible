using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace TB1_Namay.BussinessEntity
{
    public class CEnemigo
    {
        public Int32 Ataque { get; set; }
        public Int32 Stamina { get; set; }
        public Int32 Vida { get; set; }
        public Int32 Velocidad { get; set; }

        public Int32 X { get; set; }
        public Int32 Y { get; set; }

        public Int32 dx { get; set; }
        public Int32 dy { get; set; }
        public Int32 IndiceX { get; set; }

        public Int32 Ancho { get; set; }
        public Int32 Largo{get;set;}

        public void Dibujar(BufferedGraphics buffer, Bitmap bmp)
        {
            Rectangle porcionAUsar = new Rectangle(Ancho * IndiceX, Largo, Ancho, Largo);

            Rectangle aumento = new Rectangle(X, Y, Ancho * 1, Largo * 1);
            buffer.Graphics.DrawImage(bmp, aumento, porcionAUsar, GraphicsUnit.Pixel);
        }

        public void Mover(BufferedGraphics buffer, Bitmap bmp, Boolean personaje)
        {
            if (personaje)
            {
                dx *= 1;
            }
            else { dx *= -1; }
             
        }

    }
}
