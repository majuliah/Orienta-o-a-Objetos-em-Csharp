using Cap1._5.Entities.Enums;

namespace Cap1._5.Entities
{
    abstract public class Shape
    {
        public Color Color { get; set; }
        
        //não construir um cosntrutor vazio obriga a infomar a cor quando criar a forma geométrica
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}