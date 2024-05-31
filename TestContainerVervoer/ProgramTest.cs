using Containervervoer.Classes;
using System.Diagnostics;

namespace TestContainerVervoer
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void CheckShipWeigthInValid()
        {
            // Arange
            Ship ship = new Ship(5, 4);
            FillShipWithWeight(ship, 1200, 6, 4, 30, 31);

            // Act
            ship.SortContainers();

            // Assert
            Assert.IsFalse(ship.CheckEnoughWeigth());
        }


        [TestMethod]
        public void CheckShipWeigthValid()
        {
            // Arange
            Ship ship = new Ship(3, 4);
            FillShipWithWeight(ship, 1200, 6, 4, 30, 31);

            // Act
            ship.SortContainers();
            DebugShip(ship);

            // Assert
            Assert.IsTrue(ship.CheckEnoughWeigth());
        }

        [TestMethod]
        public void CheckSurroundingSpace()
        {
            // Arange
            Ship ship = new Ship(3,1);
            FillShipWithWeight(ship, 300, 3, 0, 30, 31);

            //Act
            ship.SortContainers();
            DebugShip(ship);

            //Assert
            Assert.IsTrue(ship.CheckSurrounding(1,0,2));
        }

        void FillShipWithWeight(Ship ship, int weight, int coolableCount, int valuableCount, int minimumWeight, int maximumWeight)
        {
            Random random = new();
            int totalWeight = 0;
            while (totalWeight < weight)
            {
                Container container = new() { Weight = random.Next(minimumWeight, maximumWeight), Coolable = coolableCount-- > 0, Valuable = valuableCount-- > 0 };
                ship.AddContainer(container);
                totalWeight += container.Weight;
            }
        }

        void DebugShip(Ship ship)
        {
            Debug.WriteLine($"https://i872272.luna.fhict.nl/ContainerVisualizer/index.html?width={ship.Length}&length={ship.Width}&stacks={string.Join("/", ship.Rows.Select(r => string.Join(",", r.stacks.Select(s => string.Join("-", s.Containers.Select(c => 1 + (c.Valuable ? 1 : 0) + 2 * (c.Coolable ? 1 : 0)))))))}&weights={string.Join("/", ship.Rows.Select(r => string.Join(",", r.stacks.Select(s => string.Join("-", s.Containers.Select(c => c.Weight))))))}");
        }
    }
}