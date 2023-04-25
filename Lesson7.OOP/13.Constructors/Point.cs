// Konstruktor this açar sözündən istifadə edərək digər konstruktoru çağıra bilər
class Point
{
    // Field.

    private int x, y;
    private string name;

    // Properties.
    public int X
    {
        get { return x; }
    }

    public int Y
    {
        get { return y; }
    }

    public string Name
    {
        get { return name; }
    }

    // Konstruktorlar.

    // 43-cü sətrdə olan this açar sözü aşağıdakı konstruktorun çağırılmasına gətirib çıxarır.        
    public Point(int x, int y)
    {
        Console.WriteLine("Iki parametrli konstruktor.");
        this.x = x;
        this.y = y;
    }

    public Point(string name)
        : this(300, 400)
    {
        Console.WriteLine("Bir parametrli konstruktor");
        this.name = name;
    }
}