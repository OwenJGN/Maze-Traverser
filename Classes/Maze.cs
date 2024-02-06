using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NEA_Prototype
{
    public class Maze : Nodes
    {
        public List<Nodes> searchedNodes { get; set; } = new List<Nodes>();
        public Queue<Nodes> nextEnd { get; set; } = new Queue<Nodes>();
        public List<Nodes> allMazeNodes { get; set; } = new List<Nodes>();

        public void ResetStartAndEnd(List<Nodes> StartandEnds)
        {           
            foreach (Nodes n in StartandEnds)
            {
                n.BackColor = Color.White;
                n.Controls.Clear();
            }
        }

        public void ClearAllNodes(Control.ControlCollection allControls, Maze formMaze)
        {
           
            foreach (Nodes node in formMaze.allMazeNodes)
            {
                allControls.Remove(node);
            }
            formMaze.allMazeNodes.Clear();
        }

        public void ClearHighlightedNodes(Control.ControlCollection allControls, Maze formMaze)
        {
            foreach (Nodes node in formMaze.searchedNodes)
            {
                Random rng = new Random();
                if (node.BackColor != Color.DimGray && node.BackColor != Color.Red)
                {
                    node.BackColor = Color.White;
                    node.weight = 0;
                    node.weightFrom = 0;
                    node.weightTo = 0;
                    node.isObstacle = false;
                    node.cost = node.constCost;
                }
                node.xLocation = node.constXLocation;
                node.yLocation = node.constYLocation;
            } 
          
            formMaze.searchedNodes.Clear();
        }
       
    }
}
