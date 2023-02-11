// See https://aka.ms/new-console-template for more information


using Lab___Polymorphism.Problem_1;
using Lab___Polymorphism.Problem_2;
using Lab___Polymorphism.Problem_3;

TestProblem3();

static void TestProblem1()
{
    MathOperations myMath = new MathOperations();
    Console.WriteLine(myMath.Add(2,3));
    Console.WriteLine(myMath.Add(2.2,3.3,5.5));
    Console.WriteLine(myMath.Add(2.2m,3.3m,4.4m));
}

static void TestProblem2()
{
    Animal myCat = new Cat("Pesho", "Whiskas");
    Animal myDog = new Dog("Gosho", "Meat");
    Console.WriteLine(myCat.ExplainSelf());
    Console.WriteLine(myDog.ExplainSelf());
}

static void TestProblem3()
{
    Shape myCircle = new Circle(30);
    Shape myRect = new Rectangle(30,40);
    Console.WriteLine(myCircle.CalculateArea());
    Console.WriteLine(myCircle.CalculatePerimeter());
    Console.WriteLine(myCircle.Draw());
    Console.WriteLine(myRect.CalculateArea());
    Console.WriteLine(myRect.CalculatePerimeter());
    Console.WriteLine(myCircle.Draw());
}