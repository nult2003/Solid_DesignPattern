using NUnit.Framework;

namespace StudyTest.CreationalPattern
{
    public class BuilderTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Build_GarageTest()
        {
            Director cls = new Director();
            HouseBuilder houseWithGarage = new HouseBuilder();
            cls.BuildHouseWithGarage(houseWithGarage);
            var result = houseWithGarage.GetResult();

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.withGarage);
        }

        [Test]
        public void Build_GardenTest()
        {
            Director cls = new Director();
            HouseBuilder houseWithGarden = new HouseBuilder();
            cls.BuildHouseWithGarden(houseWithGarden);
            var result = houseWithGarden.GetResult();

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.withGarden);
        }

    }


    /// <summary>
    /// Problem for this way is that we have some redunant variable
    /// </summary>
    public class House_problem
    {
        public House_problem()
        {

        }

        public House_problem(int? withGarage = null, int? withSwimmingPool = null, int? withFancySatues = null, int? withGarden = null) { }
    }

    public interface IHouse
    {
        void BuildWalls();
        void BuilDoor();
        void BuildRoof();
    }

    public interface IHouseBuilder
    {
        void BuildGarage();
        void BuilSwimming();
        void BuildGarden();

        House GetResult();
    }

    public class House : IHouse
    {
        public bool withGarage { get; set; } = false;

        public bool withGarden { get; set; } = false;
        public void BuilDoor()
        {

        }

        public void BuildRoof()
        {

        }

        public void BuildWalls()
        {

        }
    }

    public class HouseBuilder : House, IHouseBuilder
    {
        public void BuildGarden()
        {
            withGarden = true;
        }

        public void BuildGarage()
        {
            withGarage = true;
        }

        public void BuilSwimming()
        {

        }

        public House GetResult()
        {
            return this;
        }
    }

    public class Director
    {
        public void BuildHouseWithGarage(HouseBuilder builder)
        {
            builder.BuildWalls();
            builder.BuildRoof();
            builder.BuilDoor();
            builder.BuildGarage();
        }

        public void BuildHouseWithGarden(HouseBuilder builder)
        {
            builder.BuildWalls();
            builder.BuildRoof();
            builder.BuilDoor();
            builder.BuildGarden();
        }
    }

}