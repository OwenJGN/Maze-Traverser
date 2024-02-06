using System;
using System.Collections.Generic;
using System.Data.SQLite; 
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NEA_Prototype
{
    public partial class frmMazeTraverser : Form
    {
        private Nodes startNode = new Nodes();
        private Nodes endNode = new Nodes();
        private Nodes selectedNode = new Nodes();
        private Random rng = new Random();
        private bool multipleEnd = false;
        private bool startSelected = false;
        private bool endSelected = false;
        public string[,] mazeMatrix = new string[33, 45];
        private Maze formMaze = new Maze();
        public const string Database_Connection_String = "..\\..\\Data\\MTDatabase.db";
        public User currentUser = new User();
        private List<Nodes> startAndEnds = new List<Nodes>();

        public frmMazeTraverser()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmUserLogin Login = new frmUserLogin();
            Login.Show();
            cbxSpeedOfSearch.SelectedIndex = 1;            
        }

        public void showUserDetails(User current)
        {
            Dictionary<string, int> mazeAndUserID = new Dictionary<string, int>();
            
            currentUser = current;
            using (SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + Database_Connection_String))
            {
                dbConnection.Open();
                SQLiteCommand com = new SQLiteCommand("SELECT ID, AccessLevel FROM LoginDetails WHERE Username = @Username", dbConnection);               
                com.Parameters.AddWithValue("@Username", current.Username);

                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        current.UserID = reader.GetInt32(0);
                        current.AccessLevel  = reader.GetString(1);
                    }
                }

                if (current.AccessLevel != "Club Member")
                {
                    SQLiteCommand com2 = new SQLiteCommand("SELECT ID, MazeID FROM SavedMazes", dbConnection);
                    com = com2;
                }
                else
                {
                    SQLiteCommand com2 = new SQLiteCommand("SELECT ID, MazeID FROM SavedMazes WHERE ID = @ID", dbConnection);
                    com2.Parameters.AddWithValue("@ID", current.UserID);
                    com = com2;
                }
                
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mazeAndUserID.Add(reader.GetString(1), reader.GetInt32(0));
                        
                    }
                }

                dbConnection.Close();
            }
            string combinedMazeIDandID;
            foreach (KeyValuePair<string, int> currentMaze in mazeAndUserID)
            {
                combinedMazeIDandID = currentMaze.Key.ToString() + " ID:" + currentMaze.Value.ToString();
                cbxUsersFiles.Items.Add(combinedMazeIDandID);
            }
            lblCurrentID.Text = current.UserID.ToString();
            lblCurrentUsername.Text = current.Username;
            lblCurrentAL.Text = current.AccessLevel;

        }

        /// <summary>
        /// Editing and visual of the maze
        /// </summary>
        
        public void btnMazeGen_Click(object sender, EventArgs e)
        {
            formMaze.ClearHighlightedNodes(Controls, formMaze);
            formMaze.ClearAllNodes(Controls, formMaze);
            RandomMaze();
        }

        public void RandomMaze()
        {
            //this sets the rows and column as random nodes or obstacles 
            for (int i = 0; i < 45; i++)
            {
                for (int j = 0; j < 33; j++)
                {
                    //this is the random number used for the getting of either a white or grey panel
                    int randomNumber = rng.Next(0, 7);

                    if (randomNumber == 0 || randomNumber == 1)
                    {
                        mazeMatrix[j, i] = "g";

                    }
                    else
                    {
                        mazeMatrix[j, i] = "w";
                    }
                }
            }
            GenerateMaze();
        }

        private void GenerateMaze()
        {
            formMaze.ClearAllNodes(Controls, formMaze);
            formMaze.ClearHighlightedNodes(Controls, formMaze);
            cbxAlgorithm.Enabled = true;
            btnSelectEnd.Enabled = true;
            btnSelectStart.Enabled = true;

            Random rng = new Random();
            int ID = 1;
            //the nested for loop is for the colums and rows
            for (int i = 0; i < 45; i++)
            {
                for (int j = 0; j < 33; j++)
                {
                    //instantiates a new node object
                    Nodes c = new Nodes();
                    if (mazeMatrix[j, i] == "g")
                    {
                        c.BackColor = Color.DimGray;
                        c.isObstacle = true;
                    }
                    else if (mazeMatrix[j, i] == "w")
                    {
                        //gives the node a random weight
                        int RNGdistance = rng.Next(0, 10);
                        c.cost = RNGdistance;
                        c.constCost = RNGdistance;
                        c.BackColor = Color.White;
                    }
                    //creates the location on the form and the properties that it has
                    c.xLocation = (i * c.Height) + 12; c.constXLocation = c.xLocation;
                    c.yLocation = (j * c.Width) + 12; c.constYLocation = c.yLocation;                                      
                    c.Location = new Point(c.xLocation, c.yLocation);
                    c.MouseClick += M_Click;
                    c.nodeID = ID;
                    formMaze.allMazeNodes.Add(c);
                    ID++;

                    Controls.Add(c);
                }
            }
           
        }
       
       
        private void M_Click(object sender, MouseEventArgs e)
        {
            selectedNode.BorderStyle = BorderStyle.FixedSingle;
            selectedNode = (Nodes)sender;

            int i = (selectedNode.xLocation / selectedNode.Height);
            int j = (selectedNode.yLocation / selectedNode.Width);
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (selectedNode.isOverlappingSorE(selectedNode))
                    {
                        if (startSelected && !endSelected)
                        {
                            startNode = selectedNode;
                            selectedNode.selectingStart(startNode);
                            btnSelectStart.Enabled = false;
                            btnSelectStart.BackColor = Color.YellowGreen;
                            startAndEnds.Add(startNode);
                            startSelected = false;
                        }
                        else if (endSelected && !startSelected)
                        {
                            endNode = selectedNode;
                            int RNGdistance = rng.Next(0, 10);
                            selectedNode.selectingEnd(endNode, RNGdistance);
                            btnSelectEnd.Enabled = false;
                            btnSelectEnd.BackColor = Color.Red;
                            startAndEnds.Add(endNode);
                            selectedNode.BackColor = Color.Red;
                            endSelected = false;
                        }
                        else if (multipleEnd && formMaze.nextEnd.Count < 10)
                        {
                            int RNGdistance = rng.Next(0, 10);
                            formMaze.nextEnd.Enqueue(selectedNode);
                            selectedNode.BackColor = Color.Red;
                            selectedNode.selectingEnd(selectedNode, RNGdistance);
                            startAndEnds.Add(selectedNode);
                            btnMultipleEnds.BackColor = Color.Red;
                            Label label = new Label
                            {
                                Text = formMaze.nextEnd.Count.ToString(),
                            };
                            selectedNode.Controls.Add(label);
                        }
                        if (selectedNode.BackColor == Color.DimGray)
                        {
                            mazeMatrix[j, i] = "w";
                            int RNGdistance = rng.Next(0, 10);
                            selectedNode.changeToNode(selectedNode, RNGdistance);
                        }
                        else if (selectedNode.BackColor == Color.White)
                        {
                            mazeMatrix[j, i] = "g";
                            selectedNode.changeToObstacle(selectedNode);
                        }
                        
                    }
                    break;                
            }
            selectedNode.BorderStyle = BorderStyle.Fixed3D;
            lblCurrentNodeID.Text = selectedNode.nodeID.ToString();
            lblCurrentLocation.Text = selectedNode.Location.ToString();
            lblCurrentWeight.Text = selectedNode.constCost.ToString();
            pnlSelectedPanel.BackColor = selectedNode.BackColor;



        }

        /// <summary>
        /// Form controls changes
        /// </summary>

        private void btnSelectStart_Click(object sender, EventArgs e)
        {
            btnSelectStart.BackColor = Color.Gray;
            btnSelectEnd.BackColor = Color.Red;
            startSelected = true;
            endSelected = false;

         
        }

        private void btnSelectEnd_Click(object sender, EventArgs e)
        {
            btnSelectEnd.BackColor = Color.Gray;
            btnSelectStart.BackColor = Color.YellowGreen;
            startSelected = false;
            endSelected = true;
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            formMaze.ClearHighlightedNodes(Controls, formMaze);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveInDatabase();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            bool validFile = ValidateFile();
            lblFileAccess.Text = "";
            int ID = 0;
            if (validFile)
            {
                using (SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + Database_Connection_String))
                {
                    dbConnection.Open();
                    SQLiteCommand com = new SQLiteCommand("SELECT ID FROM SavedMazes WHERE MazeID = @MazeID", dbConnection);
                    com.Parameters.AddWithValue("@MazeID", txtFileName.Text.ToString());

                    using (SQLiteDataReader reader = com.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            ID = reader.GetInt32(0);

                        }
                    }
                    dbConnection.Close();
                }
                if (lblCurrentAL.Text.ToString() != "Club Member" || ID.ToString() == lblCurrentID.Text.ToString())
                {
                    using (StreamReader sr = new StreamReader(txtFileName.Text + ".txt"))
                    {
                        for (int i = 0; i < 33; i++)
                        {
                            string data = sr.ReadLine();
                            string[] values = data.Split(',');
                            for (int j = 0; j < 45; j++)
                            {
                                mazeMatrix[i, j] = values[j];
                            }

                        }
                    }
                    GenerateMaze();
                }
                else
                {
                    lblFileAccess.Text = "You do not have access";                    
                }
                
            }
            else
            {
                lblFileAccess.Text = "Invalid File name";
            }
        }       

        private void cbxAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAlgorithm = cbxAlgorithm.SelectedItem.ToString();
            lblCurrentAlgorithm.Text = selectedAlgorithm;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            int algorithm = cbxAlgorithm.SelectedIndex;
            lblTimeTaken.Text = "";
            if (algorithm == -1)
            {
                MessageBox.Show("Please select a algorithm", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            int speedOfAlgorithm = cbxSpeedOfSearch.SelectedIndex * 15;
            
            if (btnSelectStart.Enabled == false && btnSelectEnd.Enabled == false)
            {
                lblPathPossible.Text = "";                
                formMaze.ClearHighlightedNodes(Controls, formMaze);
                switch (algorithm)
                {
                    case 0:
                        DijkstrasGenerate(speedOfAlgorithm);                    
                        break;
                    case 1:
                        speedOfAlgorithm *= 2;
                        AStarGenerate(speedOfAlgorithm);
                        break;
                    case 2:                        
                        BreadthGenerate(speedOfAlgorithm);
                        break;
                    case 3:
                        speedOfAlgorithm *= 2;
                        DepthGenerate(speedOfAlgorithm);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please select a start", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       

        /// <summary>
        /// Generation of the paths
        /// </summary>

        private void AStarGenerate(int speed)
        {
            
            AStar aStar = new AStar();
            aStar.mazeTimer = aStar.timerStart();
            if (formMaze.nextEnd.Count != 0)
            {
                endNode = formMaze.nextEnd.Dequeue();
                btnSearch.Enabled = false;
            }
            Nodes previousNode = aStar.AStarAlgorithm(startNode, endNode, Controls, speed, formMaze);                       
            Stack<Nodes> AStarPath = aStar.AStarStack(previousNode, startNode);
            if (AStarPath.Count != 0 || previousNode == startNode)
            {
                while (AStarPath.Count > 0)
                {
                    Nodes currentNode = AStarPath.Pop();
                    if (currentNode.BackColor != Color.Red)
                    {                        
                        currentNode.BackColor = Color.Yellow;
                        formMaze.searchedNodes.Add(currentNode);
                    }

                }

                if (formMaze.nextEnd.Count != 0)
                {
                    startNode = endNode;
                    AStarGenerate(speed);
                }
                double timeRecorded = aStar.timerEnd(aStar);
                lblTimeTaken.Text = timeRecorded.ToString() + "s";
            }
            else
            {
                lblPathPossible.Text = "PATH NOT POSSIBLE";
            }
            
            
        }

        private void DijkstrasGenerate(int speed)
        {
            Dijkstras dijkAlgorithm = new Dijkstras();
            dijkAlgorithm.mazeTimer = dijkAlgorithm.timerStart();
            Nodes previousNode = dijkAlgorithm.DijkstrasAlgorithm(startNode, endNode, Controls, this, speed, formMaze);
            Queue<Nodes> DijksPath = dijkAlgorithm.DijkstrasPath(previousNode, startNode);
            if (DijksPath.Count != 0)
            {
                while (DijksPath.Count > 0 || previousNode == startNode)
                {
                    Nodes currentNode = DijksPath.Dequeue();
                    currentNode.BackColor = Color.Yellow;
                    formMaze.searchedNodes.Add(currentNode);
                }

                double timeRecorded = dijkAlgorithm.timerEnd(dijkAlgorithm);
                lblTimeTaken.Text = timeRecorded.ToString() + "s";
            }
            else
            {
                lblPathPossible.Text = "PATH NOT POSSIBLE";
            }
        }

        private void BreadthGenerate(int speed)
        {
            BreadthFirst BFS = new BreadthFirst();
            BFS.mazeTimer = BFS.timerStart();
            Nodes previousNode = BFS.BreadthFirstSearch(startNode, endNode, Controls, this, speed, formMaze);
            Queue<Nodes> BreadthPath = BFS.BreadthSearch(previousNode, startNode);
            if (BreadthPath.Count != 0)
            {
                
                while (BreadthPath.Count > 0 || previousNode == startNode)
                {
                    Nodes currentNode = BreadthPath.Dequeue();
                    currentNode.BackColor = Color.Yellow;
                }

                double timeRecorded = BFS.timerEnd(BFS);
                lblTimeTaken.Text = timeRecorded.ToString() + "s";
            }
            else
            {
                lblPathPossible.Text = "PATH NOT POSSIBLE";
            }
            

        }

        private void DepthGenerate(int speed)
        {
            DepthFirst DFS = new DepthFirst();
            DFS.mazeTimer = DFS.timerStart();
            Nodes previousNode = DFS.DepthFirstSearch(startNode, endNode, Controls, this, speed, formMaze);
            Stack<Nodes> DFSStack = DFS.DFSStackVisual(previousNode, startNode);

            if (DFSStack.Count != 0 || previousNode == startNode)
            {
                while (DFSStack.Count > 0)
                {
                    Nodes currentNode = DFSStack.Pop();
                    currentNode.BackColor = Color.Yellow;
                }

                double timeRecorded = DFS.timerEnd(DFS);
                lblTimeTaken.Text = timeRecorded.ToString() + "s";
            }
            else
            {
                lblPathPossible.Text = "PATH NOT POSSIBLE";
            }

        }
        /// <summary>
        /// The saving and loading of mazes
        /// </summary>

        private bool ValidateFile()
        {
            if (txtFileName.Text.ToString() != "")
            {                
                try
                {
                    if (txtFileName.Text.Contains(".txt"))
                    {
                        StreamReader sr = new StreamReader(txtFileName.Text);
                    }
                    else
                    {
                        StreamReader sr = new StreamReader(txtFileName.Text + ".txt");
                    }
                    return true;
                }
                catch (Exception)
                {                   
                    return false;
                }

            }
            return false;
        }

        private void SaveInDatabase()
        {
            lblFileAccess.Text = "";
            bool isTaken = currentUser.IsMazeTaken(txtFileName.Text.ToString());
            if (!isTaken)
            {
                using (SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + Database_Connection_String))
                {
                    dbConnection.Open();
                    SQLiteCommand com = new SQLiteCommand("INSERT INTO SavedMazes (ID, MazeID, AccessLevel) VALUES (@ID, @MazeID, @AccessLevel);", dbConnection);
                    com.Parameters.AddWithValue("@ID", currentUser.UserID);
                    com.Parameters.AddWithValue("@MazeID", txtFileName.Text.ToString());
                    com.Parameters.AddWithValue("@AccessLevel", currentUser.AccessLevel);
                    com.ExecuteReader();
                    dbConnection.Close();
                }
                SaveTextfile();
            }
            else 
            {
                lblFileAccess.Text = "Invalid file name";
            }
        }

        private void SaveTextfile()
        {
            //writes the data into a text file with the user name
            using (StreamWriter sw = new StreamWriter(txtFileName.Text + ".txt"))
            {
                //represents the columns and rows
                for (int i = 0; i < 33; i++)
                {
                    for (int j = 0; j < 45; j++)
                    {
                        sw.Write(mazeMatrix[i, j] + "");
                        //this makes it a csv file
                        sw.Write(",");
                    }
                    sw.WriteLine();
                }
            }
        }

        private void btnResetSandE_Click(object sender, EventArgs e)
        {
            formMaze.ResetStartAndEnd(startAndEnds);          
            btnSelectStart.Enabled = true;
            btnSelectEnd.Enabled = true;
            btnMultipleEnds.Enabled = true;
            btnSelectStart.BackColor = Color.YellowGreen;
            btnSelectEnd.BackColor = Color.Red;
            btnSearch.Enabled = true;
            btnMultipleEnds.BackColor = Color.Red;
            multipleEnd = false;
            startSelected = false;
            endSelected = false;
            cbxAlgorithm.Enabled = true;
            formMaze.nextEnd.Clear();

        }

        private void btnMultipleEnds_Click(object sender, EventArgs e)
        {
            btnMultipleEnds.BackColor = Color.Gray;
            endNode.BackColor = Color.White;            
            cbxAlgorithm.Enabled = false;
            cbxAlgorithm.SelectedIndex = 1;
            multipleEnd = true;
            startSelected = false;
            endSelected = false;
            btnSelectEnd.Enabled = false;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            frmEditAccount editAccount = new frmEditAccount(lblCurrentUsername.Text.ToString());
            editAccount.Show();
        }

        private void btnChangeWeight_Click(object sender, EventArgs e)
        {
            lblInvalidWeight.Text = "";
            if (int.TryParse(txtNewWeight.Text.ToString(), out int weight))
            {
                if (weight <= 0 || weight > 2147483646)
                {
                    lblInvalidWeight.Text = "Invalid Number";
                }
                else if(selectedNode.BackColor != Color.DimGray)
                {
                    selectedNode.constCost = weight;
                    lblCurrentWeight.Text = weight.ToString();
                    txtNewWeight.Clear();
                }
            }
            else
            {
                lblInvalidWeight.Text = "Enter a number";
            }
           
           
        }

        private void cbxUsersFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMazeID = cbxUsersFiles.SelectedItem.ToString();
            int charLocation = selectedMazeID.IndexOf(" ", StringComparison.Ordinal);
            selectedMazeID = selectedMazeID.Substring(0, charLocation);
            txtFileName.Text = selectedMazeID;
        }
    }
}
