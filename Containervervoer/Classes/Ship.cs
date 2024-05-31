using System.Linq;

namespace Containervervoer.Classes
{
    public class Ship
    {
        private List<Container> containers = new();
        public List<Row> Rows { get; set; } = new();
        public int Length { get; set; }
        public int Width { get; set; }

        public Ship(int length, int width) 
        {
            Length = length;
            Width = width;
            MakeShip();
        }

        public void ClearContainers() => containers.Clear();

        public void AddContainer(Container container) => containers.Add(container);

        public void MakeShip()
        {
            Rows.Clear();

            for (int i = 0; i < Length; i++)
            {
                Rows.Add(new());
                for (int j = 0; j < Width; j++)
                {
                    Rows.Last().stacks.Add(new(i, j));
                }
            }
        }

        public bool SortContainers()
        {
            return containers.OrderByDescending(c => c.Valuable).All(SortContainer);
        }

        private bool SortContainer(Container container)
        {
            if (container.Coolable)
            {
                return Rows.First().AddContainer(container, CheckSurrounding, CheckValuable);
            }
            foreach (Row row in Rows.Skip(1).Append(Rows.First()))
            {
                if (row.AddContainer(container, CheckSurrounding, CheckValuable))
                    return true;
            }
            return false;
        }

        public bool CheckSurrounding(int row, int stack, int spot)
        {
            if (ContainerAt(row - 1, stack, spot) == null)
                return true;
            if (ContainerAt(row + 1, stack, spot) == null)
                return true;
            return false;
        }

        public bool CheckValuable(int row, int stack, int spot)
        {
            var frontContainerValuable = ContainerAt(row - 1, stack, spot)?.Valuable ?? false;
            var backContainerValuable = ContainerAt(row + 1, stack, spot)?.Valuable ?? false;

            if (frontContainerValuable)
            {
                var frontValuableAccessible = ContainerAt(row - 2, stack, spot) == null;
                if (!frontValuableAccessible)
                    return false;
            }
            if (backContainerValuable)
            {
                var backValuableAccessible = ContainerAt(row + 2, stack, spot) == null;
                if (!backValuableAccessible)
                    return false;
            }
            return true;
        }

        private Container? ContainerAt(int row, int stack, int spot)
        {
            return Rows.ElementAtOrDefault(row)?.stacks.ElementAtOrDefault(stack)?.Containers.ElementAtOrDefault(spot);
        }

        private int CalculateMaxWeight(List<Row> rows)
        {
            int maxweigth = Length * Width * 5 * 30;
            return maxweigth;
        }

        public bool CheckEnoughWeigth()
        {
            int totalweigth = 0;

            foreach (Container container in containers)
                totalweigth += container.Weight;

            if (totalweigth < (CalculateMaxWeight(Rows)/2))
                return false;

            return true;
        }
    }
}