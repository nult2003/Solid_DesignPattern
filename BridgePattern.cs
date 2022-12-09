using NUnit.Framework;
using System.Drawing;

namespace StudyTest
{
    public class BridgePattern
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var red = new Red(); red.SetRed(255); red.SetBlue(0); red.SetGreen(0);
            var cls = new Circle(red);

            var blue = new Blue(); blue.SetRed(0); blue.SetBlue(255); blue.SetGreen(0);
            var rec = new Rectangle(blue);
        }

        [Test]
        public void UtilsTest()
        {

        }



    }

    // Problem for below architect
    public class Shape_Problem
    {
    }

    public class CircleRed : Shape_Problem
    {
        public CircleRed()
        {
        }
        // code here
    }

    public class CircleBlue : Shape_Problem
    {
        public CircleBlue()
        {
        }
        // code here
    }

    public class RectangleRed : Shape_Problem
    {
        public RectangleRed()
        {
        }
        // code here
    }

    public class RectangleBlue : Shape_Problem
    {
        public RectangleBlue()
        {
        }
        // code here
    }


    // Bridge Design pattern resolves above problem
    public interface IColour
    {
        void SetRed(int red);
        void SetBlue(int blue);
        void SetGreen(int green);
    }

    public class Red : IColour 
    {
        int red = default;
        int blue = default;
        int green = default;

        public void SetRed(int red)
        {
            this.red = red;
        }

        public void SetBlue(int blue)
        {
            this.blue = blue;
        }

        public void SetGreen(int green)
        {
            this.green = green;
        }
    }

    public class Blue : IColour
    {
        int red = default;
        int blue = default;
        int green = default ;

        public void SetRed(int red)
        {
            this.red = red;
        }

        public void SetBlue(int blue)
        {
            this.blue = blue;
        }

        public void SetGreen(int green)
        {
            this.green = green;
        }
    }
    public class Shape
    {
        protected IColour color;
    }

    public class Circle : Shape
    {
        public Circle(IColour color)
        {
            this.color = color;
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(IColour colour)
        {
            this.color = colour;
        }
    }
}