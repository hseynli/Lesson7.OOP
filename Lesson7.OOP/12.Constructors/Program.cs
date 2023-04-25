// Default konstruktordan istifadə etməyə çalışırıq.  
//Point pointA = new Point();                                              //  Şərhdən çıxarmaq
//Console.WriteLine("pointA.X = {0} pointA.Y = {1}", pointA.X, pointA.Y);  // 

Console.WriteLine(new string('-', 30));

// Paramterli konstruktordan istifadə edirik
Point pointB = new Point(100, 200);
Console.WriteLine("pointB.X = {0} pointB.Y = {1}", pointB.X, pointB.Y);