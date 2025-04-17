class Point
{
    public int X {  get; set; }
    public int Y { get; set; }

    public Point()
    {
        X = 0;
        Y = 0;
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public string GetQuadrant()
    {
        switch(X, Y)
        {
            case (< 0, < 0):
                return "Third";
            case ( < 0, >= 0):
                return "Second";
            case (>= 0, < 0):
                return "Fourth";
            default:
                return "First";

        }
    }
}
