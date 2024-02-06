using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NEA_Prototype
{
    public class Nodes : Panel
    {
        public bool isObstacle { get; set; } = false; 
        public int xLocation { get; set; }
        public int yLocation { get; set; }
        public int constXLocation { get; set; }
        public int constYLocation { get; set; }
        public int constCost { get; set; }
        public int cost { get; set; }
        public int nodeID { get; set; } = -1;
        public Nodes Parents { get; set; }
        public int weight { get; set; } = 0;
        public int weightFrom { get; set; } = 0;
        public int weightTo { get; set; } = 0;

        //this is set to every instance of a node object
        public Nodes()
        {
            Size = new Size(18, 18);
            BorderStyle = BorderStyle.FixedSingle;
            cost = -1;
            this.DoubleBuffered = false;          
        }

        public void changeToNode(Nodes selectedNode, int distance)
        {
            selectedNode.cost = distance;
            selectedNode.BackColor = Color.White;
            selectedNode.isObstacle = false;
        }

        public void changeToObstacle(Nodes selectedNode)
        {
            selectedNode.BackColor = Color.DimGray;
            selectedNode.isObstacle = true;
        }

        public void selectingStart(Nodes selectedNode)
        {
            selectedNode.cost = 0;
            selectedNode.BackColor = Color.LimeGreen;
            selectedNode.isObstacle = false;
        }

        public void selectingEnd(Nodes selectedNode, int distance)
        {
            selectedNode.cost = distance;
            selectedNode.BackColor = Color.Red;
            selectedNode.isObstacle = false;
        }
        public bool isOverlappingSorE(Nodes affectedCell)
        {
            if (affectedCell.BackColor != Color.LimeGreen && affectedCell.BackColor != Color.Red)
            {
                return true;
            }

            return false;
        }
               
    }
}
