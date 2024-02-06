using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Prototype
{
    public class BreadthFirst : Traversers
    {
        private Queue<Nodes> nodeQueue { get; set; } = new Queue<Nodes>();

        public Queue<Nodes> BreadthSearch(Nodes previous, Nodes Start)
        {
            Queue<Nodes> BreadthSearch = new Queue<Nodes>();
            
            if (previous != null)
            {
                //goes until it finds the start node
                while (!(previous.xLocation == Start.xLocation && previous.yLocation == Start.yLocation))
                {
                    BreadthSearch.Enqueue(previous);
                    //goes to the previous parent form the node
                    previous = previous.Parents;
                }
            }
            
            //returns the queue to be used for the final path
            return BreadthSearch;
        }

        public Nodes BreadthFirstSearch(Nodes start, Nodes end, Control.ControlCollection allControls, Form mainForm, int speedOfAlgorithm, Maze currentMaze)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 500;
            nodeQueue.Enqueue(start);
            SetStartandEnd(start, end);
            AddNeighbours();

            while (nodeQueue.Any())
            {
                //gets the next node to search from 
                Nodes currentNode = nodeQueue.First();
                nodeQueue.Dequeue();
                //this is to show to the user that it has been searched
                if (!(currentNode.xLocation == startX && currentNode.yLocation == startY) && (!currentNode.isObstacle))
                {
                    currentNode.BackColor = Color.DarkBlue;
                }
                //goes through all of the adjacent nodes
                foreach (KeyValuePair<int, int> XorY in nodesNeighbours)
                {
                    //the next adjacent nodes to be searched
                    int nextX = currentNode.xLocation + XorY.Key;
                    int nextY = currentNode.yLocation + XorY.Value;

                    //to help check for rutime errors and not out of bounds
                    if (nextX > maxXlocation || nextX < 12)
                    {
                        continue;
                    }
                    else if (nextY > maxYlocation || nextY < 12)
                    {
                        continue;
                    }
                    

                    Nodes nextNode = findPanelNode(nextX, nextY, allControls);

                    //checks to see if the node is an obstacle
                    if (!nextNode.isObstacle)
                    {
                        //if it has been visited then it will go the next node
                        if (visitedNodes.Contains(nextNode))
                        {
                            continue;
                        }
                        //adds the parents as the current node
                        nextNode.Parents = currentNode;
                        if (nextNode.xLocation == endX && nextNode.yLocation == endY)
                        {
                            return currentNode;
                        }
                        else
                        {
                            Task.Delay(speedOfAlgorithm).Wait();
                            nextNode.Location = new Point(nextX, nextY);
                            //this is to show to the user the node that could be searched next
                            if (!(nextNode.xLocation == startX && nextNode.yLocation == startY))
                            {
                                nextNode.BackColor = Color.LightBlue;
                                if (!currentMaze.searchedNodes.Contains(nextNode))
                                {
                                    currentMaze.searchedNodes.Add(nextNode);
                                }
                            }
                            mainForm.Controls.Add(nextNode);
                            
                        }

                        //enqueues the next node to be searched form next
                        visitedNodes.Add(nextNode);
                        nodeQueue.Enqueue(nextNode);
                    }

                }

            }
            return null;
        }

    }
}
