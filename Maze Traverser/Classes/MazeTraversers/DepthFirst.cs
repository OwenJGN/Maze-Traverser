using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Prototype
{

    public class DepthFirst : Traversers
    {
        private Stack<Nodes> DFSStack { get; set; } = new Stack<Nodes>();

        public Stack<Nodes> DFSStackVisual(Nodes previous, Nodes Start)
        {
            Stack<Nodes> DFSStack = new Stack<Nodes>();

            //checks to se if the previous node is valid
            if (previous != null)
            {
                //will go until it gets to the start
                while (previous.xLocation != Start.xLocation || previous.yLocation != Start.yLocation)
                {
                    //pushes the previous node onto the stack and mak the previous the parent of that
                    DFSStack.Push(previous);
                    previous = previous.Parents;
                }

            }
            
            //returns the stack to be poped and shown to the user
            return DFSStack;
        }

        public Nodes DepthFirstSearch(Nodes start, Nodes end, ControlCollection allControls, Form mainForm, int speedOfAlgorithm, Maze currentMaze)
        {
            
            visitedNodes.Add(start);
            //pushes the start node onto the stack
            DFSStack.Push(start);
            SetStartandEnd(start, end);
            AddNeighbours();

            //goes until it is empty
            while (DFSStack.Count != 0)
            {
                Nodes currentNode = DFSStack.Pop();

                foreach (KeyValuePair<int, int> XorY in nodesNeighbours)
                {
                    int nextX = currentNode.xLocation + XorY.Key;
                    int nextY = currentNode.yLocation + XorY.Value;

                    // to make it doesnt run into any runtime erros of out of bounds
                    if (nextX > maxXlocation || nextX < 12)
                    {
                        continue;
                    }
                    else if (nextY > maxYlocation || nextY < 12)
                    {
                        continue;
                    }

                    //finds the nextNode control on the form
                    Nodes nextNode = findPanelNode(nextX, nextY, allControls);
                    //if it is an obstacle then it will go to the next node
                    if (nextNode.isObstacle)
                    {
                        continue;
                    }
                    //will return if it gets to the end
                    if (nextNode.xLocation == endX && nextNode.yLocation == endY)
                    {
                        return currentNode;
                    }
                    //if the noed has been visited then it be set to dark blue to reprenst searched node
                    if (visitedNodes.Contains(nextNode))
                    {
                        if (nextNode.Location != start.Location)
                        {
                            nextNode.BackColor = Color.DarkBlue;
                        }
                        
                        continue;
                    }
                    //adds the currentNode as the nextNode parent
                    nextNode.Parents = currentNode;
                    Task.Delay(speedOfAlgorithm).Wait();
                    nextNode.Location = new Point(nextX, nextY);
                    //pushes the nextNode onto th stack to be searched
                    DFSStack.Push(nextNode);
                    //to represent a noed that could be searched
                    if (nextNode.Location != start.Location)
                    { 
                    nextNode.BackColor = Color.LightBlue;
                    }                    
                    currentMaze.searchedNodes.Add(nextNode);
                    mainForm.Controls.Add(nextNode);
                    //to keep track of the nodes that have already been searched
                    visitedNodes.Add(nextNode);
                    continue;

                }
                
            }
            return null;
        }
    }
}
