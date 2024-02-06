using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace NEA_Prototype
{
    public class Traversers : Nodes
    {
        //these properties can be used in the four algorithm classes
        public int maxXlocation { get; set; } = ((44 * 18) + 12);
        public int maxYlocation { get; set; } = ((32 * 18) + 12);
        public int startX { get; set; }
        public int startY { get; set; }
        public int endX { get; set; }
        public int endY { get; set; }
        public Stopwatch mazeTimer { get; set; } = new Stopwatch();
        public List<Nodes> visitedNodes { get; set; } = new List<Nodes>();
        public List<KeyValuePair<int, int>> nodesNeighbours { get; set; } = new List<KeyValuePair<int, int>>();

        public void SetStartandEnd(Nodes start, Nodes end)
        {
            this.startX = start.xLocation;
            this.startY = start.yLocation;
            this.endX = end.xLocation;
            this.endY = end.yLocation;
        }

        public void AddNeighbours()
        {
            nodesNeighbours.Add(new KeyValuePair<int, int>(-18, 0));
            nodesNeighbours.Add(new KeyValuePair<int, int>(0, 18));
            nodesNeighbours.Add(new KeyValuePair<int, int>(18, 0));
            nodesNeighbours.Add(new KeyValuePair<int, int>(0, -18));
        }
        public Nodes findPanelNode(int x, int y, ControlCollection controls)
        {
            List<Control> list = new List<Control>();

            foreach (Control ctr in controls)
            {
                if (ctr is Nodes)
                {
                    list.Add(ctr);
                }
            }
            foreach (Nodes n in list)
            {
                if (n.Location == (new Point(x, y)))
                {
                    return n;
                }

            }
            return null;
        }

        public Stopwatch timerStart()
        {
            Stopwatch pathTimer = new Stopwatch();
            pathTimer.Start();
            return pathTimer;        
        }

        public double timerEnd(Traversers currentTraverser)
        {
            currentTraverser.mazeTimer.Stop();
            double timeTaken = (currentTraverser.mazeTimer.ElapsedMilliseconds) / 1000.0;
            
            return timeTaken;
        }
        
    }
}
