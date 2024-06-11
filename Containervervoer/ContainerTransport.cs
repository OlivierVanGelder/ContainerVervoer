using Containervervoer.Classes;
using System.Data;
using System.Linq;

namespace Containervervoer
{
    public partial class ContainerTransport : Form
    {
        public ContainerTransport()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = string.Empty;
            Ship ship = new Ship(Convert.ToInt32(LengthInput.Value), Convert.ToInt32(WidthInput.Value));
            FillContainers(ship, Convert.ToInt32(normalWeightInput.Value), Convert.ToInt32(valuableWeightInput.Value), Convert.ToInt32(coolableWeightInput.Value), Convert.ToInt32(BothInput.Value));
            if (!ship.OrganizeContainers())
                ShowSizeErrorMessage();
            DrawShip(ship);
        }

        private void DrawShip(Ship ship)
        {
            ShipLayoutPanel.Controls.Clear();

            foreach (Row row in ship.Rows)
            {
                DrawRow(row);
            }
        }

        public void ShowSizeErrorMessage()
        {
            ErrorLabel.Text = "Schip is te smal voor de vracht!";
        }

        private void DrawRow(Row row)
        {
            FlowLayoutPanel rowPanel = new FlowLayoutPanel();
            ShipLayoutPanel.Controls.Add(rowPanel);
            rowPanel.FlowDirection = FlowDirection.LeftToRight;
            rowPanel.AutoSize = true;

            foreach (Stack stack in row.stacks)
            {
                FlowLayoutPanel stackPanel = new FlowLayoutPanel();
                rowPanel.Controls.Add(stackPanel);
                stackPanel.FlowDirection = FlowDirection.BottomUp;
                stackPanel.AutoSize = true;

                foreach (Container container in stack.Containers)
                {
                    Label containerLabel = new Label();
                    stackPanel.Controls.Add(containerLabel);
                    containerLabel.AutoSize = true;

                    int type = 1;
                    if (container.Coolable == true)
                    {
                        type += 2;
                    }
                    if (container.Valuable == true)
                    {
                        type++;
                    }
                    containerLabel.Text += $"{type} {container.Weight}t";
                }
            }
        }

        private void FillContainers(Ship ship, int normalWeight, int valuableWeight, int coolableWeight, int bothWeight)
        {
            ship.ClearContainers();

            FillContainersUntilWeight(ship, normalWeight, false, false);
            FillContainersUntilWeight(ship, valuableWeight, false, true);
            FillContainersUntilWeight(ship, coolableWeight, true, false);
            FillContainersUntilWeight(ship, bothWeight, true, true);
        }

        private void FillContainersUntilWeight(Ship ship, int weight, bool coolable, bool valuable)
        {
            while (weight > 0)
            {
                Container container = new Container();

                if (container.WeightExeeds(weight))
                {
                    weight -= (container.STANDARD_MAX_WEIGHT - container.STANDARD_WEIGHT);
                    ship.AddContainer(new Container() { Weight = container.STANDARD_MAX_WEIGHT, Coolable = coolable, Valuable = valuable });
                }
                else
                {
                    ship.AddContainer(new Container() { Weight = weight + container.STANDARD_WEIGHT, Coolable = coolable, Valuable = valuable });
                    weight = 0;
                }
            }
        }

        private void ContainerTransport_Load(object sender, EventArgs e)
        {

        }
    }
}