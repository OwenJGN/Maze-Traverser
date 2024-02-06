using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Prototype
{
    public class Dijkstras : Traversers
    {

        public Queue<Nodes> DijkstrasPath(Nodes previous, Nodes Start)
        {
            Queue<Nodes> DijksPath = new Queue<Nodes>();
            if (previous != null)
            {
                //goes to all the parent nodes until it gets to the start
                while (!(previous.xLocation == Start.xLocation && previous.yLocation == Start.yLocation))
                {
                    
                    DijksPath.Enqueue(previous);
                    //goes to the previous parent node representing the shortest path
                    previous = previous.Parents;
                }
                
            }
            //returns the Queue to be shown to the user as the shortest path
            return DijksPath;

        }

        public Nodes DijkstrasAlgorithm(Nodes start, Nodes end, Control.ControlCollection allControls, Form mainForm, int speedOfAlgorithm, Maze currentMaze)
        {
          //  Timer djikTimer = new Timer(1000);
            visitedNodes.Clear();
            start.weight = 0;
            var nodePQ = new List<Nodes>();
            nodePQ.Add(start);

            SetStartandEnd(start, end);
            AddNeighbours();

            visitedNodes.Add(start);

            while (nodePQ.Any())
            {
                //sorts the queue based on weights for the next node to be selected
                nodePQ = nodePQ.OrderBy(x => x.weight).ToList();
                Nodes currentNode = nodePQ.First(); 
                nodePQ.Remove(currentNode);
                
                //this is to show to the user the ndoes that have been searched
                if (!(currentNode.xLocation == startX && currentNode.yLocation == startY))
                {
                    currentNode.BackColor = Color.DarkBlue;
                    currentMaze.searchedNodes.Add(currentNode);
                }

                foreach (KeyValuePair<int, int> XorY in nodesNeighbours)
                {
                    int nextX = currentNode.xLocation + XorY.Key;
                    int nextY = currentNode.yLocation + XorY.Value;

                    if (nextX > maxXlocation || nextX < 12)
                    {
                        continue;
                    }
                    else if (nextY > maxYlocation || nextY < 12)
                    {
                        continue;
                    }


                    Nodes nextNode = findPanelNode(nextX, nextY, allControls);

                    if (!nextNode.isObstacle)
                    {
                        //checks to see if it has been visited already
                        if (visitedNodes.Contains(nextNode))
                        {
                            continue;
                        }

                        Task.Delay(speedOfAlgorithm).Wait();
                        nextNode.Parents = currentNode;
                        //checks to see if it is the end node
                        if (nextNode.xLocation == endX && nextNode.yLocation == endY)
                        {
                            return currentNode;
                        }
                        //settings the cost of the nextNode
                        else if ((nextNode.cost <= currentNode.weight) || (currentNode.weight == 0) )
                        {
                            nextNode.weight = nextNode.cost += currentNode.cost;
                            //this is to show to the user the next node that could possibly be searched
                            if (!(nextNode.xLocation == startX && nextNode.yLocation == startY))
                            {
                                nextNode.BackColor = Color.LightBlue;
                                currentMaze.searchedNodes.Add(nextNode);
                            }
                            nextNode.Location = new Point(nextX, nextY);
                            mainForm.Controls.Add(nextNode);
                        }
                        
                        visitedNodes.Add(nextNode);
                        nodePQ.Add(nextNode);
                    }

                }
            }
            return null;
        }
    }
}
