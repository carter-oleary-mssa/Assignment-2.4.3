Point p1 = new Point(1, 1);
Point p2 = new Point(-1, 1);
Point p3 = new Point(-1, -1);
Point p4 = new Point(1, -1);
Point[] pointArr = {p1, p2, p3, p4};

for (int i = 0; i < pointArr.Length; i++)
{
    Console.WriteLine($"Point {i+1} is in the {pointArr[i].GetQuadrant()} quadrant");
}