class Point
{
    // Field.
    private int x, y;

    // Property.
    public int X
    {
        get { return x; }
    }

    public int Y
    {
        get { return y; }
    }

    // Default konstruktor, field-ləri ilkin qiymətə mənimsədir.
    public Point()
    {
        Console.WriteLine("Default konstruktor!");
    }

    // istifadəçi konstruktoru, field-ləri istifadə tərəfindən göndərilmiş dəyərlərə mənimsədir.
    public Point(int x, int y)
    {
        Console.WriteLine("Istifadeci konstruktoru!");
        this.x = x;
        this.y = y;
    }
}