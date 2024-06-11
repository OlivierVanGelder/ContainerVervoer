using Containervervoer.Classes;
using System.Diagnostics;

namespace TestContainerVervoer
{
    [TestClass]
    public class ShipTest
    {
        [TestMethod]
        public void CheckShipWeigthFunctionInValid()
        {
            // Arange
            Ship ship = new Ship(5, 4);
            FillShipWithWeight(ship, 1200, 6, 4, 30, 31);

            // Act
            ship.OrganizeContainers();

            // Assert
            Assert.IsFalse(ship.CheckEnoughWeigth());
        }


        [TestMethod]
        public void CheckShipWeigthFunctionValid()
        {
            // Arange
            Ship ship = new Ship(3, 4);
            FillShipWithWeight(ship, 1200, 6, 4, 30, 31);

            // Act
            ship.OrganizeContainers();
            DebugShip(ship);

            // Assert
            Assert.IsTrue(ship.CheckEnoughWeigth());
        }

        [TestMethod]
        public void CheckSurroundingFunction()
        {
            // Arange
            Ship ship = new Ship(3, 1);
            FillShipWithWeight(ship, 300, 3, 0, 30, 31);

            //Act
            ship.OrganizeContainers();
            DebugShip(ship);

            //Assert
            Assert.IsTrue(ship.CheckSurrounding(1, 0, 2));
        }

        [TestMethod]
        public void CheckValuableAccessibility()
        {
            // Arange
            Ship ship = new Ship(8, 1);
            FillShipWithWeight(ship, 850, 0, 5, 30, 31);

            //Act
            ship.OrganizeContainers();
            DebugShip(ship);

            //Assert
            Assert.IsTrue(CheckValuablesAccessible(ship));
        }

        [TestMethod]
        public void CheckNothingOnTopOfValuable()
        {
            // Arange
            Ship ship = new Ship(3, 2);
            FillShipWithWeight(ship, 800, 0, 4, 30, 31);

            // Act
            ship.OrganizeContainers();
            DebugShip(ship);

            // Assert
            Assert.IsTrue(CheckShipValuablesStacked(ship));
        }

        [TestMethod]
        public void CheckCoolableFirstRow()
        {
            // Arange
            Ship ship = new Ship(3, 2);
            FillShipWithWeight(ship, 800, 3, 2, 30, 31);

            // Act
            ship.OrganizeContainers();
            DebugShip(ship);

            // Assert
            Assert.IsTrue(CheckCoolablesInFirstRow(ship));
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

        bool CheckValuablesAccessible(Ship ship)
        {
            return ship.Rows.All(r => r.stacks.Where(s => s.Containers.LastOrDefault()?.Valuable ?? false).All(s => ship.CheckSurrounding(s.RowIndex, s.StackIndex, s.Containers.Count - 1)));
        }

        bool CheckCoolablesInFirstRow(Ship ship)
        {
            return ship.Rows.Skip(1).All(r => r.stacks.All(s => s.Containers.All(c => !c.Coolable)));
        }

        bool CheckShipValuablesStacked(Ship ship)
        {
            return ship.Rows.All(r => r.stacks.All(s => s.Containers.SkipLast(1).All(c => !c.Valuable)));
        }

        void DebugShip(Ship ship)
        {
            Debug.WriteLine($"https://i872272.luna.fhict.nl/ContainerVisualizer/index.html?width={ship.Length}&length={ship.Width}&stacks={string.Join("/", ship.Rows.Select(r => string.Join(",", r.stacks.Select(s => string.Join("-", s.Containers.Select(c => 1 + (c.Valuable ? 1 : 0) + 2 * (c.Coolable ? 1 : 0)))))))}&weights={string.Join("/", ship.Rows.Select(r => string.Join(",", r.stacks.Select(s => string.Join("-", s.Containers.Select(c => c.Weight))))))}");
        }
    }
}