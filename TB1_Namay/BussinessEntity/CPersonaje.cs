using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace TB1_Namay.BussinessEntity
{
   public  enum Direcciones { Ninguna, Arriba, Abajo, Derecha, Izquierda };
    public class CPersonaje
    {
        public Int32 Largo { get; set; }
        public Int32 Ancho { get; set; }
        public Int32 x { get; set; }
        public Int32 y { get; set; }
        
        public Int32 dx { get; set; }
        public Int32 dy { get; set; }
        public Int32 IndiceX { get; set; }
        public Direcciones Direccion { get; set; }
        public Direcciones UltimaDireccion { get; set; }

        public void Dibujar(BufferedGraphics buffer, Bitmap bmp)
        {
            Rectangle porcionAUsar = new Rectangle(Ancho * IndiceX, Largo, Ancho, Largo);
           
            Rectangle aumento = new Rectangle(x, y, Ancho * 1, Largo * 1);
            buffer.Graphics.DrawImage(bmp, aumento, porcionAUsar, GraphicsUnit.Pixel);
        }

        public void Mover(BufferedGraphics buffer, Bitmap bmp)
        {
            switch (Direccion)
            {
                case Direcciones.Arriba:
                    if (IndiceX >= 1 && IndiceX < 3)
                        IndiceX++;
                    else
                        IndiceX = 1;
                    dx = 0;
                    dy = -5;
                    UltimaDireccion = Direcciones.Arriba;
                    break;

                case Direcciones.Abajo:
                   
                    if (IndiceX >= 1 && IndiceX < 3)
                        IndiceX++;
                    else
                        IndiceX = 1;
                    dx = 0;
                    dy = 5;
                    UltimaDireccion = Direcciones.Abajo;
                    break;

                case Direcciones.Derecha:
                   
                    if (IndiceX >= 1 && IndiceX < 3)
                        IndiceX++;
                    else
                        IndiceX = 1;
                    dx = 5;
                    dy = 0;
                    UltimaDireccion = Direcciones.Derecha;
                    break;

                case Direcciones.Izquierda:
                    
                    if (IndiceX >= 1 && IndiceX < 3)
                        IndiceX++;
                    else
                        IndiceX = 1;
                    dx = -5;
                    dy = 0;
                    UltimaDireccion = Direcciones.Izquierda;
                    break;

                case Direcciones.Ninguna:
                    dx = dy = 0;
                    switch (Direcciones.Ninguna)
                    {
                        case Direcciones.Arriba:
                            IndiceX = 0;
                           
                            break;
                        case Direcciones.Abajo:
                            IndiceX = 0;
                           
                            break;
                        case Direcciones.Derecha:
                            IndiceX = 0;
                           
                            break;
                        case Direcciones.Izquierda:
                            IndiceX = 0;
                           
                            break;
                    }
                    break;

                    /*if (mapa[x][y] != 0)
                    {
                        x = 0;
                        y = 0;
                    }*/
            }
            Dibujar(buffer, bmp);
        }
       
    }
}
