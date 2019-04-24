
namespace ElementalTask2
{
    public class Envelope
    {
        private double width;
        private double heigth;

        public Envelope(double width, double heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }

        public double Width
        {
            get { return width; }
        }

        public double Heigth
        {
            get { return heigth; }
        }
    }
}
