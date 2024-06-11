using System.ComponentModel;

namespace Containervervoer.Classes
{
    public class Container
    {
        public bool Valuable { get; set; } = false;
        public bool Coolable { get; set; } = false;
        public int Weight { get; set; } = 0;

        public int STANDARD_WEIGHT { get; } = 4;
        public int STANDARD_MAX_WEIGHT { get; } = 30;

        public bool WeightExeeds(int weight)
        {
            if (weight >= STANDARD_MAX_WEIGHT - STANDARD_WEIGHT)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
