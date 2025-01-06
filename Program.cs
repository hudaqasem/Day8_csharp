using Day8.Classses;
using Day8.Interfces;

namespace Day8
{
    internal class Program
    {
        public static void PrintTenShapes(IShapeSeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{series.CurrentShapeArea} ");
                series.GetNextArea();
            }
            series.ResetSeries();
            Console.WriteLine();
        }

        public static void SelectionSort(double[] numbers)
        {
            int n = numbers.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIdx])
                    {
                        minIdx = j;
                    }
                }
                double temp = numbers[minIdx];
                numbers[minIdx] = numbers[i];
                numbers[i] = temp;
            }
        }

        
        




        static void Main(string[] args)
        {
            #region  IVehicle
            //Car c = new Car();
            //c.StartEngine();
            //c.StopEngine();
            //Console.WriteLine("----------------------------");
            //Bike b = new Bike();
            //b.StartEngine();
            //b.StopEngine(); 
            #endregion

            #region Abstract Shape
            //Rectangle rectangle = new Rectangle(4, 5);
            //Console.WriteLine(rectangle.GetArea());
            //Console.WriteLine("--------------------------");
            //Circle circle = new Circle(2);
            //Console.WriteLine(circle.GetArea()); 
            #endregion

            #region Icomparable
            //Product[] products = new Product[]
            //{
            //    new Product(1,"p1",5),
            //    new Product(2,"p2",2.5),
            //    new Product(3,"p3",10),
            //    new Product(4,"p4",8)
            //};
            //Console.WriteLine("Before Sorting : ");
            //foreach (Product product in products)
            //{
            //    Console.WriteLine(product.ToString());
            //}
            //Array.Sort(products);
            //Console.WriteLine("\nAfter Sorting : ");
            //foreach (Product product in products)
            //{
            //    Console.WriteLine(product.ToString());
            //} 
            #endregion

            #region shallow & deep copy
            //Student student1 = new Student(1,"Hody",100);
            //Student student2 = new Student(2, "Jory", 150);

            //Console.WriteLine("Before copy : ");
            //Console.WriteLine(student1);
            //Console.WriteLine(student2);
            //Console.WriteLine(student1.GetHashCode()); //54267293
            //Console.WriteLine(student2.GetHashCode()); //18643596

            //student1 = student2; // shallow copy
            //Console.WriteLine("\nshallow copy : ");
            //Console.WriteLine(student1);
            //Console.WriteLine(student2);
            //Console.WriteLine(student1.GetHashCode()); // 18643596
            //Console.WriteLine(student2.GetHashCode()); // 18643596

            //student1 = new Student(student2);// deep copy
            //Console.WriteLine("\ndeep copy : ");
            //Console.WriteLine(student1);
            //Console.WriteLine(student2);
            //Console.WriteLine(student1.GetHashCode()); // 33574638
            //Console.WriteLine(student2.GetHashCode()); // 18643596 
            #endregion

            #region implement explicitly
            //Robot robot = new Robot();
            //robot.Walk();
            //Console.WriteLine("--------------------------");
            //IWalkable walkable = new Robot();
            //walkable.Walk(); 
            #endregion

            #region Struct Encapsulation
            //Account account = new Account();
            //account.AccountId = 1;
            //account.AccountHolder = "Ay 7aga";
            //account.Balance = 100;
            //Console.WriteLine(account); 
            #endregion

            #region  default implementation
            //ILogger ilog = new ConsoleLogger();
            //ilog.Log(); 
            #endregion


            #region constructor overloading
            //Book book1 = new Book("t1");
            //Book book2 = new Book("t1","a1"); 
            #endregion

            #region Shape Series
            //Console.WriteLine("SquareSeries");
            //SquareSeries square = new SquareSeries();    
            //PrintTenShapes(square);

            //Console.WriteLine("\nCircleSeries");
            //CircleSeries circle = new CircleSeries();
            //PrintTenShapes(circle); 
            #endregion

            #region Sorting for Shapes
            //ShapeCompare[] shapeCompares =
            //{
            //    new ShapeCompare("Square", 16),
            //    new ShapeCompare("Circle", 5), 
            //    new ShapeCompare("Rectangle", 12),
            //    new ShapeCompare("Triangle",1),
            //    new ShapeCompare("Square", 4),
            //    new ShapeCompare("Circle", 100)
            //};

            //Console.WriteLine("Before Sorting : ");
            //foreach (var item in shapeCompares)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Sort(shapeCompares);
            //Console.WriteLine("\nAfter Sorting : ");
            //foreach (var item in shapeCompares)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Shape Hierarchy 
            //Triangle triangle = new Triangle();
            //triangle.Dimension1 = 10;
            //triangle.Dimension2 = 20;
            //Console.WriteLine(triangle);

            //RectangleG rectangleG = new RectangleG();
            //rectangleG.Dimension1 = 10;
            //rectangleG.Dimension2 = 20;
            //Console.WriteLine(rectangleG); 
            #endregion

            #region  SelectionSort
            //double[] shapeAerea =
            //{
            //  5 ,1,80,4,1,5,6
            //};

            //Console.WriteLine("Before Sorting : ");
            //foreach (var item in shapeAerea)
            //{
            //    Console.WriteLine(item);
            //}

            //SelectionSort(shapeAerea);
            //Console.WriteLine("\nAfter Sorting : ");
            //foreach (var item in shapeAerea)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Factory Pattern 
            //GeometricShape rectangle = ShapeFactory.CreateShape("rectangle", 5, 3);
            //GeometricShape triangle = ShapeFactory.CreateShape("triangle", 4, 6);
            //Console.WriteLine(rectangle);
            //Console.WriteLine(triangle); 
            #endregion

            #region  operator overloading
            Point p1 = new Point(1, 1);
            Point p2 = new Point(2, 3);

            Point addTwoPoints = p1 + p2;
            Console.WriteLine(addTwoPoints);

            Point incrementPoint = ++p1;
            Console.WriteLine(incrementPoint);

            #endregion


        }
    }
}
