namespace ActuarialIntelligence.DLTS.Infrastructure
{
    public class Point<X,Y>
    {
        public X x { get; private set; }
        public Y y { get; private set; }
        public Point(X x, Y y)
        {
            this.y = y;
            this.x = x;
        }
    }
}
