using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Prototype
{
    public class AStar : Traversers
    {     
        //these properties are only used within this class so can be private
        private Dictionary<string, Nodes> aStarVisitedNodes { get; set; } = new Dictionary<string, Nodes>();
        private Dictionary<string, Nodes> aStarUnvisitedNodes { get; set; } = new Dictionary<string, Nodes>();

        private KeyValuePair<string, Nodes> GetSmallestWeight(Dictionary<string, Nodes> allNodes)
        {

            KeyValuePair<string, Nodes> smallestWeighted = new KeyValuePair<string, Nodes>();

            if (allNodes.Count != 0)
            {
                //gets the firts indexed
                smallestWeighted = allNodes.ElementAt(0);

                //iterates through all of the Nodes
                foreach (KeyValuePair<string, Nodes> item in allNodes)
                {
                    //the weight represents the x and y values
                    if (item.Value.weight < smallestWeighted.Value.weight)
                    {
                        // the smallest is set as the current item
                        smallestWeighted = item;
                    }
                    else if ((item.Value.weight == smallestWeighted.Value.weight) && (item.Value.weightTo < smallestWeighted.Value.weightTo))
                    {
                        // the smallest is set as the current item
                        smallestWeighted = item;
                    }
                }
                
            }
            //it returns whatever the smallestItem keyvalue pair curerntly is from the iteration
            return smallestWeighted;


        }
        public Stack<Nodes> AStarStack(Nodes previous, Nodes Start)
        {
            Stack<Nodes> AStarPath = new Stack<Nodes>();

            if (previous != null)
            {
                //goes until it gets to the start
                while (previous.xLocation != Start.xLocation || previous.yLocation != Start.yLocation)
                {
                    //pushes them all onto a stack to be popped off
                    AStarPath.Push(previous);
                    
                    previous = previous.Parents;

                    //this prevents runtime errors
                    if (previous == null)
                    {
                        break;
                    }
                }
            }

            //returns the path to be used for the visual
            return AStarPath;
        }

        public Nodes AStarAlgorithm(Nodes start, Nodes end, Control.ControlCollection allControls, int speedOfAlgorithm, Maze currentMaze)
        {
            start.xLocation = start.constXLocation;
            start.yLocation = start.constYLocation;
            end.xLocation = end.constXLocation;
            end.yLocation = end.constYLocation;
            SetStartandEnd(start, end);
            AddNeighbours();
           
            
            string nodesStart = startX.ToString() + startY.ToString();
            
            aStarUnvisitedNodes.Add(nodesStart, start);

            //as it is has an unknown amount of iterations 
            while (true)
            {
                // This searches all the nodes and returns the smallest one based on the x and y 
                KeyValuePair<string, Nodes> currentNode = GetSmallestWeight(aStarUnvisitedNodes);
                if (currentNode.Value == null)
                {
                    return null;
                }

                aStarVisitedNodes.Add(currentNode.Key, currentNode.Value);
                aStarUnvisitedNodes.Remove(currentNode.Key);
                if (!(currentNode.Value.xLocation == startX && currentNode.Value.yLocation == startY) && (!currentNode.Value.isObstacle))
                {
                    if (currentNode.Value.BackColor != Color.Yellow && currentNode.Value.BackColor != Color.Red)
                    {                       
                            currentNode.Value.BackColor = Color.DarkBlue;
                            currentMaze.searchedNodes.Add(currentNode.Value);
                                               
                    }
                }

                foreach (KeyValuePair<int, int> XorY in nodesNeighbours)
                {
                    //sets the nextX and nextY as the next node to search
                    int nextX = currentNode.Value.xLocation + XorY.Key;
                    int nextY = currentNode.Value.yLocation + XorY.Value;
                    //these are prevent runtime errors
                    if (nextX > maxXlocation || nextX < 12)
                    {
                        continue;
                    }
                    else if (nextY > maxYlocation || nextY < 12)
                    {
                        continue;
                    }
                    // this represents the x and y weighting
                    string nextWeighting = nextX.ToString() + nextY.ToString();

                    if (nextX < 0 || nextY < 0 || nextX > maxXlocation || nextY > maxYlocation || aStarVisitedNodes.ContainsKey(nextWeighting))
                    {
                        continue;
                    }
                    Task.Delay(speedOfAlgorithm).Wait();

                    //if the node is unvisited
                    if (aStarUnvisitedNodes.ContainsKey(nextWeighting))
                    {

                        Nodes nextNode = aStarUnvisitedNodes[nextWeighting];

                        if (nextNode.xLocation == end.xLocation && nextNode.yLocation == end.yLocation)
                        {
                            return currentNode.Value;
                        }
                        //this is to prevent it from searching through an obstacle
                        if (!nextNode.isObstacle)
                        {
                            int from = Math.Abs(nextX - startX) + Math.Abs(nextY - startY);

                            nextNode.Location = new Point(nextX, nextY);
                            if (nextNode.BackColor != Color.Yellow && nextNode.BackColor != Color.Red)
                            {
                                //set the node as node that could be searched next
                                nextNode.BackColor = Color.LightBlue;
                                currentMaze.searchedNodes.Add(nextNode);
                            }

                            if (from > nextNode.weightFrom)
                            {
                                //this is to alter the new weights for the nextNode from the current node
                                nextNode.weightFrom = from;
                                nextNode.weight = nextNode.weightFrom + nextNode.weight;
                                //adding of the parents for shortest path at the end
                                nextNode.Parents = currentNode.Value;

                            }
                        }
                    }
                    else
                    {
                        Nodes nextNode = findPanelNode(nextX, nextY, allControls);
                        currentMaze.searchedNodes.Add(nextNode);
                        if (nextNode.xLocation == end.xLocation && nextNode.yLocation == end.yLocation)
                        {
                            return currentNode.Value;
                        }
                        if (!nextNode.isObstacle)
                        {
                            nextNode.weightFrom = Math.Abs(nextX - startX) + Math.Abs(nextY - startY);
                            nextNode.weightTo = Math.Abs(nextX - endX) + Math.Abs(nextY - endY);
                            nextNode.weight = nextNode.weightFrom + nextNode.weightTo;
                            nextNode.Parents = currentNode.Value;
                            nextNode.Location = new Point(nextX, nextY);
                            if (nextNode.BackColor != Color.Yellow && nextNode.BackColor != Color.Red)
                            {
                                nextNode.BackColor = Color.LightBlue;
                            }

                        }
                        else
                        {
                            nextNode.xLocation -= XorY.Key;
                            nextNode.yLocation -= XorY.Value;
                        }

                        aStarUnvisitedNodes.Add(nextWeighting, nextNode);
                    }

                }
            }

        }

    }
    
}
