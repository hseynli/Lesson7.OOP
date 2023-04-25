// Default konstruktordan isfidadə edirik.
Point pointA = new Point();
Console.WriteLine("pointA.X = {0} pointA.Y = {1}", pointA.X, pointA.Y);

Console.WriteLine(new string('-', 30));

// İstifadəçi tərəfindən yaradılan paramterli konstruktordan istifadə edirik.
Point pointB = new(100, 200);
Console.WriteLine("pointB.X = {0} pointB.Y = {1}", pointB.X, pointB.Y);