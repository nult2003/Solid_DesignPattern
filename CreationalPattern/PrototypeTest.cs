using NUnit.Framework;

namespace StudyTest.CreationalPattern
{
    public class PrototypeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestProblem()
        {
            PrototypeMainApp cls = new PrototypeMainApp();
        }

        [Test]
        public void Test1()
        {
            var rec = new Rectangle();
            rec.Width = 5;
            rec.Height = 1;

            var recClone = rec.Clone();
        }
    }

    /// <summary>
    /// Problem for this pattern
    /// </summary>
    public class Prototype_Problem
    {
        private int _test = 1;

        public int MyProperty { get; set; }

        public Prototype_Problem()
        {
        }

        public void SetTestValue(int value)
        {
            _test = value;
        }

    }

    class PrototypeMainApp
    {
        public PrototypeMainApp()
        {
            var cls = new Prototype_Problem() { MyProperty = 2 };
            cls.SetTestValue(2);

            // clone
            // can't clone _test's value
            var cls1 = new Prototype_Problem();
            cls1.MyProperty = cls.MyProperty;
        }
    }

    // Protype design pattern
    public abstract class Shape
    {
        public abstract Shape Clone();
    }

    public class Rectangle : Shape
    {
        int width;
        int height;

        public int Width
        {
            get { return width; }

            set { width = value; }
        }
        public int Height
        {
            get { return height; }

            set { height = value; }
        }

        public Rectangle()
        {

        }

        public Rectangle(Rectangle source)
        {
            width = source.width;
            height = source.height;
        }
        public override Shape Clone()
        {
            return new Rectangle(this);
        }
    }
}