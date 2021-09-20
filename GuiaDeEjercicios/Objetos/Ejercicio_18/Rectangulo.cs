using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        private int baseRectangulo;
        private int alturaRectangulo;

        private float area;
        private float perimetro;

        private int x_Inicio;
        private int y_Inicio;

        public int BaseRectangulo 
        {
            get
            {
                return this.baseRectangulo;
            }
            
        }

        public int AlturaRectangulo
        {
            get
            {
                return this.alturaRectangulo;
            }

        }

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            float b = 0;
            float h = 0;

            b = (float)(Math.Abs((vertice1.getX() - vertice3.getX())));
            h = (float)(Math.Abs((vertice1.getY() - vertice3.getY())));



            this.area = this.getPerimetro();// (b * h);
            this.perimetro = this.getPerimetro();//(b + h) * 2;

            this.alturaRectangulo = (int)h;
            this.baseRectangulo = (int)b;
            this.x_Inicio = vertice1.getX();
            this.y_Inicio = vertice1.getY();

        }

        public float getPerimetro()
        {
            float b = 0;
            float h = 0;
            float perimetro = 0;

            b = (float)(Math.Abs((vertice1.getX() - vertice3.getX())));
            h = (float)(Math.Abs((vertice1.getY() - vertice3.getY())));

            perimetro = (b + h) * 2;

            return perimetro;
        }

        public float getArea()
        {
            float b = 0;
            float h = 0;
            float area = 0;

            b = (float)(Math.Abs((vertice1.getX() - vertice3.getX())));
            h = (float)(Math.Abs((vertice1.getY() - vertice3.getY())));
        

            area = (b*h);

            return area;
        }

        
    }
}
