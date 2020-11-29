using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensuraligner
{
  /// <summary>
  /// Class to perform a Neighbor-Joining from a distance matrix, according Studier/Keppler 1988
  /// </summary>
  public class NeighborJoining
  {
    /// <summary>
    /// Matrix with start distances
    /// </summary>
    public decimal[,] StartMatrix { get; private set; }

    /// <summary>
    /// Matrix with actual tree distances
    /// </summary>
    public decimal[,] TreeMatrix { get; private set; }

    /// <summary>
    /// Array index to taxa label
    /// </summary>
    public Dictionary<int,string> StartLabels { get; private set; }

    /// <summary>
    /// List of Nodes and connecting edges
    /// </summary>
    public List<Tuple<string,decimal,string>> NodesAndEdges { get; private set; }

    /// <summary>
    /// Result as bifurcating tree
    /// </summary>
    public BifiTree NJtree { get; private set; }

    /// <summary>
    /// Final tree result in Newick format
    /// </summary>
    public string NewickTree { get; private set; }

    /// <summary>
    /// Get the shortest non-zero edge
    /// </summary>
    public decimal MinEdge { get; private set; }

    #region Member
    // Termination marker
    private bool terminator = false;
    // Level of node in tree
    private int level = 0;
    // List of trees
    private List<BifiTree> Nodes;
    #endregion

    #region Constructor
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="_startMatrix">Symmetric distance matrix</param>
    /// <param name="_labels">Dictionary with labels of the distance matrix</param>
    public NeighborJoining(decimal[,] _startMatrix, Dictionary<int,string> _labels)
    {
      //Check for symmetrical distances
      if (_startMatrix.GetLength(0) != _startMatrix.GetLength(1))
      {
        throw new Exception("Matrix needs to be symmetric!");
      }

      //Check for existing labels
      //Check for unique labels
      List<string> lstLabels = new List<string>();
      for (int count = 0; count < _labels.Count; count++)
      {
        string strLabel;
        if (_labels.TryGetValue(count, out strLabel))
        {
          // Check for unique
          if (lstLabels.Contains(strLabel))
          {
            throw new Exception($"Label {strLabel} is not unique!");
          }
          else
          {
            lstLabels.Add(strLabel);
          }
        }
        else
        {
          throw new Exception($"Label for index {count} is missing!");
        }
      }

      //Set properties
      StartMatrix = _startMatrix;
      StartLabels = _labels;

      NodesAndEdges = new List<Tuple<string,decimal,string>>();

      // Set node levels to 0
      Dictionary<int, int> initNodeLevels = new Dictionary<int, int>();
      foreach (int nodeIndex in StartLabels.Keys)
      {
        initNodeLevels.Add(nodeIndex, level);
      }

      //Create leaf nodes for every label
      Nodes = new List<BifiTree>();

      foreach (string node in StartLabels.Values)
      {
        Nodes.Add(new BifiTree(node));
      }

      //Init neighbor joining with start matrix
      NeighborJoiningController(StartMatrix, StartLabels, initNodeLevels);

    }
    #endregion

    /// <summary>
    /// Controls neighbor-joining sub-steps
    /// </summary>
    private void NeighborJoiningController(decimal[,] _distMatrix, Dictionary<int, string> _labels, Dictionary<int,int> _nodeLevels)
    {
      //Terminate or proceed?
      if (_distMatrix.GetLength(0) > 2) 
      {
        //Get average distances
        Dictionary<int, decimal> averages = GetAverageDistances(_distMatrix);

        //Get intermediate matrix
        decimal[,] intermediate = SubtractAverageDistance(averages, _distMatrix);

        //Choose neigbors by minimal value in intermediate matrix
        List<Tuple<int, int>> minimals = GetMinimalsFromMatrix(intermediate);
        Tuple<int, int> neighbors = ChooseNeighbors(minimals, _nodeLevels);

        //Define new node
        string newNode = _labels[neighbors.Item1] + _labels[neighbors.Item2];

        //Joining neighbors
        //Calculate distance from OldA to New and add to Tuple list
        decimal d_oldA_new = (_distMatrix[neighbors.Item1, neighbors.Item2] + averages[neighbors.Item1] - averages[neighbors.Item2]) / 2;
        NodesAndEdges.Add(Tuple.Create(_labels[neighbors.Item1], d_oldA_new, newNode));

        //Calcutate distance from OldB to New and add to Tuple list
        decimal d_oldB_new = _distMatrix[neighbors.Item1, neighbors.Item2] - d_oldA_new;
        NodesAndEdges.Add(Tuple.Create(_labels[neighbors.Item2], d_oldB_new, newNode));

        //Add children to tree
        Nodes.Add(BifiTree.GetBifiTree(newNode, Nodes.SingleOrDefault(a => a.Label == _labels[neighbors.Item1]), d_oldA_new, 
          Nodes.SingleOrDefault(a => a.Label == _labels[neighbors.Item2]), d_oldB_new));

        //Delete children from node list
        Nodes.Remove(Nodes.SingleOrDefault(a => a.Label == _labels[neighbors.Item1]));
        Nodes.Remove(Nodes.SingleOrDefault(a => a.Label == _labels[neighbors.Item2]));

        //Reduce labels
        Dictionary<int, string> reducedLabels = new Dictionary<int, string>();
        Dictionary<int, int> reducedLevels = new Dictionary<int, int>();
        for (int count = 0; count <= _labels.Count - 1; count++)
        {
          if (count == neighbors.Item1)
          {
            reducedLabels.Add(reducedLabels.Count, newNode);
            // When cluster is added, increment level counter
            level++;
            reducedLevels.Add(reducedLevels.Count, level);
            
          }
          else if (count == neighbors.Item2)
          {
            continue;
          }
          else
          {
            reducedLabels.Add(reducedLabels.Count, _labels[count]);
            reducedLevels.Add(reducedLevels.Count, _nodeLevels[count]);
          }
        }

        Dictionary<string, int> dicIndex2Label = new Dictionary<string, int>();
        foreach (KeyValuePair<int, string> kvPairAktuell in _labels)
        {
          dicIndex2Label.Add(kvPairAktuell.Value, kvPairAktuell.Key);
        }

        //Reduce matrix
        decimal[,] reducedMatrix = new decimal[_distMatrix.GetLength(0) - 1, _distMatrix.GetLength(1) - 1];
        for (int i = 0; i < reducedMatrix.GetLength(0); i++)
        {
          for (int j = 0; j < reducedMatrix.GetLength(1); j++)
          {
            if (i == j)
            {
              reducedMatrix[i, j] = 0;
            }
            else if (reducedLabels[i] == newNode)
            {
              decimal dist_new1_j = _distMatrix[neighbors.Item1, dicIndex2Label[reducedLabels[j]]];
              decimal dist_new2_j = _distMatrix[neighbors.Item2, dicIndex2Label[reducedLabels[j]]];
              decimal dist_new1_new2 = _distMatrix[neighbors.Item1, neighbors.Item2];

              reducedMatrix[i, j] = (dist_new1_j + dist_new2_j - dist_new1_new2) / 2;
            }
            else if (reducedLabels[j] == newNode)
            {
              decimal dist_i_new1 = _distMatrix[dicIndex2Label[reducedLabels[i]], neighbors.Item1];
              decimal dist_i_new2 = _distMatrix[dicIndex2Label[reducedLabels[i]], neighbors.Item2];
              decimal dist_new1_new2 = _distMatrix[neighbors.Item1, neighbors.Item2];

              reducedMatrix[i, j] = (dist_i_new1 + dist_i_new2 - dist_new1_new2) / 2;
            } 
            else
            {
              reducedMatrix[i, j] = _distMatrix[dicIndex2Label[reducedLabels[i]], dicIndex2Label[reducedLabels[j]]];
            }
          }
        }


        //Call myself again
        NeighborJoiningController(reducedMatrix, reducedLabels, reducedLevels);
      }

      // If matrix is reduced to two elements
      if(terminator == false)
      {
        // Add last Triple to NodesAndEdges
        if (_distMatrix[0, 0] == 0 && _distMatrix[1, 1] == 0 && _distMatrix[0, 1] == _distMatrix[1, 0])
        {
          //Create last edge
          NodesAndEdges.Add(Tuple.Create(_labels[0], _distMatrix[0, 1], _labels[1]));

          /*  The smallest possible unrooted tree has 3 edges. 
           *  Therefore, the imaginary root node neccesary for the Newick string has three children.
           *  Because this can't be done with a strictly bifurcating tree, 
           *  the last edge between two BifiTrees needs to be drawn here!
           */

          string newickA = Nodes.SingleOrDefault(a => a.Label == _labels[0]).GetNewickString();
          string newickB = Nodes.SingleOrDefault(a => a.Label == _labels[1]).GetNewickString();

          // The brackets of one of the trees need to be deleted
          newickA = newickA.Substring(1, newickA.Length - 2);
          // To the other tree with brackets the last distance needs to be appended
          newickB = newickB + ":" + _distMatrix[0, 1].ToString("0.#####", CultureInfo.CreateSpecificCulture("en-GB"));

          NewickTree = "(" + newickA + "," + newickB + ");";

          BifiTree root = BifiTree.GetBifiTree("root",
              Nodes.SingleOrDefault(a => a.Label == _labels[0]), 0m,
               Nodes.SingleOrDefault(a => a.Label == _labels[1]), _distMatrix[0, 1]);

          BuildTreeMatrix(root);
          MinEdge = this.NodesAndEdges.Min(item => Math.Abs(item.Item2));

        }

        // Still needs to be written to .txt
        // This should be done via UI...

        terminator = true;
      }

    }

    #region Clustering sub-steps
    /// <summary>
    /// Caltulate average distance per taxon
    /// </summary>
    /// <param name="_matrix">Any distance matrix</param>
    /// <returns>Average distances for each array index</returns>
    private Dictionary<int,decimal> GetAverageDistances(decimal[,] _matrix)
    {
      Dictionary<int, decimal> averages = new Dictionary<int, decimal>();

      for (int i = 0; i < _matrix.GetLength(0); i++)
      {
        decimal sumPerTaxon = 0;

        for (int j = 0; j < _matrix.GetLength(1); j++)
        {
          sumPerTaxon += _matrix[i, j];
        }

        averages.Add(i, sumPerTaxon / (_matrix.GetLength(0) - 2));
      }

      return averages;
    }

    /// <summary>
    /// Calculate intermediate matrix
    /// </summary>
    /// <param name="_averages">Average distance of taxon</param>
    /// <param name="_distMatrix">Distance matrix</param>
    /// <returns>intermediate matrix with aberages subtraced from distances</returns>
    private decimal[,] SubtractAverageDistance(Dictionary<int, decimal> _averages, decimal[,] _distMatrix)
    {
      decimal[,] intermediate = new decimal[_distMatrix.GetLength(0), _distMatrix.GetLength(1)];

      for (int i = 0; i < _distMatrix.GetLength(0); i++)
      {
        for (int j = 0; j < _distMatrix.GetLength(1); j++)
        {
          // Subtract averages only at non-identicals
          if(i == j)
          {
            intermediate[i, j] = 0;
          }
          else
          {
            intermediate[i, j] = _distMatrix[i, j] - (_averages[i] + _averages[j]);
          }
        }
      }

      return intermediate;
    }

    /// <summary>
    /// Check minimals and choose tupel to join
    /// </summary>
    /// <param name="_minimals">List of positions of minimal values from matrix</param>
    /// <param name="_levels">Dictionary of current node levels</param>
    /// <returns>Index numbers of nodes to join</returns>
    private Tuple<int,int> ChooseNeighbors(List<Tuple<int, int>> _minimals, Dictionary<int,int> _levels)
    {
      // Check if number of minimals are even (array needs to be symmetrical)
      if (_minimals.Count % 2 == 0)
      {
        // If there are only two tuples, check for symmetry
        if (_minimals.Count == 2)
        {
          if (_minimals[0].Item1 == _minimals[1].Item2 && _minimals[1].Item1 == _minimals[0].Item2)
          {
            return _minimals[0];
          }
          else
          {
            throw new Exception("Minimals are not symmetrical!");
          }
        }
        // If there are more, take the first most outer nodes after checking for the existence of a symmetric tuple....
        else
        {
          // Check for symmetry
          for (int intIndex = 0; intIndex < _minimals.Count; intIndex++)
          {
            // Check if an tuple with switched coordinates exists
            Tuple<int, int> checkTuple = Tuple.Create(_minimals[intIndex].Item2, _minimals[intIndex].Item1);
            if (_minimals.Contains(checkTuple) == false)
            {
              // BOOOOM!
              throw new Exception("Minimals are really not symmetrical!");
            }
          }

          // Remove symetric Tuples in _minimals
          for (int intIndex = _minimals.Count - 1; intIndex >= 0; intIndex--)
          {
            // Check if an tuple with switched coordinates exists
            Tuple<int, int> checkTuple = Tuple.Create(_minimals[intIndex].Item2, _minimals[intIndex].Item1);
            if (_minimals.Contains(checkTuple))
            {
              // Remove this tuple
              _minimals.RemoveAt(intIndex);
            }
          }

          Dictionary<Tuple<int, int>, int> dicMinimals = new Dictionary<Tuple<int, int>, int>();
          foreach (var minAktuell in _minimals)
          {
            dicMinimals.Add(minAktuell, _levels[minAktuell.Item1] + _levels[minAktuell.Item2]);
          }
          var sortedMinimals = dicMinimals.OrderBy(item => item.Value);

          // Build a tuple with switched values to check if a symetrical tuple exists
          return sortedMinimals.ToArray()[0].Key;
        }
      }
      else
      {
        throw new Exception("Number of minimals are not even!");
      }
    }

    /// <summary>
    /// Gets minimal values of matrix
    /// </summary>
    /// <param name="_matrix">Matrix array</param>
    /// <returns>List of matrix positions for lowest value</returns>
    private List<Tuple<int,int>> GetMinimalsFromMatrix(decimal[,] _matrix)
    {
      // Just for safety, diagonal values should be ignored completely

      // Put every matrix position and its value in a dictionary
      Dictionary<Tuple<int, int>, decimal> dictPos2Value = new Dictionary<Tuple<int, int>, decimal>();
      for (int i = 0; i < _matrix.GetLength(0); i++)
      {
        for (int j = 0; j < _matrix.GetLength(1); j++)
        {
          // Ignore the diagonal zeros here!
          if (i != j)
          {
            dictPos2Value.Add(Tuple.Create(i, j), _matrix[i, j]);
          }
        }
      }

      // Get minimum value
      decimal min = dictPos2Value.Values.Min();

      List<Tuple<int, int>> minimals = new List<Tuple<int, int>>();

      foreach (KeyValuePair<Tuple<int, int>, decimal> pair in dictPos2Value)
      {
        if (pair.Value == min)
        {
          minimals.Add(pair.Key);
        }
      }

      return minimals;
    }
    #endregion

    #region Evaluate tree
    /// <summary>
    /// Calculates a matrix of the summed edge distances
    /// <paramref name="_rootedTree">Tree with dummy root</paramref>
    /// </summary>
    private void BuildTreeMatrix(BifiTree _rootedTree)
    {
      // Initalize tree matrix
      decimal[,] treeMatrix = new decimal[StartMatrix.GetLength(0), StartMatrix.GetLength(1)];

      // Then iterate through matrix, get the labels and look in the rootedTree for the distances
      // Sum them up and write the value in the treeMatrix
      for (int i = 0; i < treeMatrix.GetLength(0); i++)
      {
        for (int j = 0; j < treeMatrix.GetLength(1); j++)
        {
          // Get labels for this matrix entry
          string x_label = StartLabels[i];
          string y_label = StartLabels[j];

          if (i == j)
          {
            treeMatrix[i, j] = 0;
          }
          else
          {
            List<BifiTree> treeX = new List<BifiTree>(), treeY = new List<BifiTree>();
            _rootedTree.GetWay(x_label, treeX);
            _rootedTree.GetWay(y_label, treeY);

            // Reverse the order of the list
            treeX.Reverse();
            treeY.Reverse();
            // Search through the List till we found the minimal root node
            while (treeX.Count > 1 && treeY.Count > 1 && treeX[1] == treeY[1])
            {
              treeX.RemoveAt(0);
              treeY.RemoveAt(0);
            }

            decimal dist = 0m;
            // Calculate backwarts int List X
            for (int intX = treeX.Count - 1; intX >= 1; intX--)
            {
              dist += (treeX[intX - 1].Left == treeX[intX] ? treeX[intX - 1].LeftBranch : treeX[intX - 1].RightBranch).Value;
            }
            // And frontwarts in List Y
            for (int intY = 0; intY < treeY.Count - 1; intY++)
            {
              dist += (treeY[intY].Left == treeY[intY + 1] ? treeY[intY].LeftBranch : treeY[intY].RightBranch).Value;
            }

            treeMatrix[i, j] = dist;
          }

          
        }

      }

      TreeMatrix = treeMatrix;
    }
    #endregion
    }
}
