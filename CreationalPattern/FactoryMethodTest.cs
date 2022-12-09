using NUnit.Framework;

namespace StudyTest.CreationalPattern
{
    public class FactoryMethodTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFactory()
        {
            var a = new MainApp();
        }

    }

    /// <summary>
    /// This is a problem when exist Sea transport
    /// </summary>
    public class TruckTransportOld
    {

        public TruckTransportOld() { }

        public int TransportType { get; set; }

        public void Deliver()
        {
            // do some stuff
            if (TransportType == 1)
            {
                // do some stuff for Truck transport
            }

            if (TransportType == 2)
            {
                // do some stuff for Sea transport
            }
            //....maybe add other transports in near future
        }
    }

    // ====== apply factory pattern to improve above codes
    public interface ITransPort { }
    public interface ITruckTransport : ITransPort
    {
        void Deliver();
    }
    public class TruckTransport : ITruckTransport
    {
        public TruckTransport() { }

        public void Deliver()
        {
        }
    }
    public abstract class LogisticsApp
    {
        public abstract ITransPort CreateTransport();
    }

    public class RoadLogistics : LogisticsApp
    {
        public override ITransPort CreateTransport()
        {
            return new TruckTransport();
        }
    }

    public class SeaLogistics : LogisticsApp
    {
        public override ITransPort CreateTransport()
        {
            throw new System.NotImplementedException();
        }
    }

    public class MainApp
    {
        public MainApp()
        {
            var truck = (ITruckTransport)new RoadLogistics().CreateTransport();
            truck.Deliver();
        }
    }
}