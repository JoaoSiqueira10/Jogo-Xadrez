using Heranca5_MetodosAbstratos.Entities.Enums;

namespace Heranca5_MetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}
