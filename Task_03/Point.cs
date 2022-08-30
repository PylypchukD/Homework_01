namespace Task_03
{
    internal class Point
    {
        string name;
        int x;
        int y;

        public Point(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }

        public string Name { get { return name; } }
        public int X { get { return x; } }
        public int Y { get { return y; } }

    }
}
