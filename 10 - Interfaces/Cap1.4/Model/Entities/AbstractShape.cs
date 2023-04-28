using enums;

namespace entities
{
    public abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        
        public abstract double Area();
        //implementando a interface com método abstrato
    }
}