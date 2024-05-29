namespace Containervervoer.Classes
{
    public class Row
    {
        public List<Stack> stacks { get; set; } = new();
    
        public bool AddContainer(Container container, Func<int, int, int, bool> checkEmptySurrounding)
        {
            return stacks.OrderBy(s => s.CalculateTotalWeigth()).Any(s => s.TryAdd(container, checkEmptySurrounding));
        }
    }
}