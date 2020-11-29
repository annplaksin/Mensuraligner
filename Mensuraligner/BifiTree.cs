using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensuraligner
{
  /// <summary>
  /// Left child or right child?
  /// </summary>
  public enum LeftRight
  {
    /// <summary>
    /// Left!
    /// </summary>
    Left = 1,
    /// <summary>
    /// Right!
    /// </summary>
    Right = 2
  }
  /// <summary>
  /// Bifurcating tree with branch lengths
  /// </summary>
  public class BifiTree
  {
    /// <summary>
    /// Label of node
    /// </summary>
    public string Label { get; private set; }

    /// <summary>
    /// Left child node
    /// </summary>
    public BifiTree Left { get; private set; }

    /// <summary>
    /// Branch length to left child
    /// </summary>
    public decimal? LeftBranch { get; private set; } = null;

    /// <summary>
    /// Right child node
    /// </summary>
    public BifiTree Right { get; private set; }

    /// <summary>
    /// Branch length to right child
    /// </summary>
    public decimal? RightBranch { get; private set; } = null;

    /// <summary>
    /// Constructor with label of node
    /// </summary>
    /// <param name="_label">Label of node</param>
    public BifiTree(string _label)
    {
      Label = _label;
    }

    /// <summary>
    /// Method to create a tree with one child
    /// </summary>
    public static BifiTree GetBifiTree(string _label, BifiTree _child, decimal _branch, LeftRight _leftRight)
    {
      BifiTree treeReturn = new BifiTree(_label);

      if (_leftRight == LeftRight.Left)
      {
        treeReturn.SetLeft(_child, _branch);
      }
      else
      {
        treeReturn.SetRight(_child, _branch);
      }

      return treeReturn;
    }

    /// <summary>
    /// Method to create a tree with two children
    /// </summary>
    public static BifiTree GetBifiTree(string _label, BifiTree _left, decimal _leftBranch, BifiTree _right, decimal _rightBranch)
    {
      BifiTree treeReturn = new BifiTree(_label);

      treeReturn.SetLeft(_left, _leftBranch);
      treeReturn.SetRight(_right, _rightBranch);

      return treeReturn;
    }

    /// <summary>
    /// Set left child with branch length
    /// </summary>
    /// <param name="_left">Left child</param>
    /// <param name="_leftBranch">Branch length to left child</param>
    public void SetLeft(BifiTree _left, decimal _leftBranch)
    {
      Left = _left;
      LeftBranch = _leftBranch;
    }

    /// <summary>
    /// Set right child with branch length
    /// </summary>
    /// <param name="_right">Right child</param>
    /// <param name="_rightBranch">Branch length to right child</param>
    public void SetRight(BifiTree _right, decimal _rightBranch)
    {
      Right = _right;
      RightBranch = _rightBranch;
    }


    /// <summary>
    /// Gets the tree in newick format by post order traversion
    /// </summary>
    public string GetNewickString(decimal? _branchLength = null)
    {
      //PostOrder traversion to build newick string
      StringBuilder strBuilderNewick = new StringBuilder();
      // Append the children
      if (this.Left != null && this.Right != null)
      {
        strBuilderNewick.Append("(");
        strBuilderNewick.Append(this.Left.GetNewickString(this.LeftBranch));
        strBuilderNewick.Append(",");
        strBuilderNewick.Append(this.Right.GetNewickString(this.RightBranch));
        strBuilderNewick.Append(")");
      }
      else
      {
        strBuilderNewick.Append(this.Label);
      }

      // Append the current Data if we got a branchlength
      // Remember, branch length could be 0 and still should be added; omit only if there is no child!
      if (_branchLength != null)
      {
        strBuilderNewick.Append(":");
        strBuilderNewick.Append(_branchLength.Value.ToString("0.#####", CultureInfo.CreateSpecificCulture("en-GB")));
      }

      return strBuilderNewick.ToString();
    }

    /// <summary>
    /// Returns a list of trees on the way to node with label
    /// </summary>
    /// <param name="_label">Searched label</param>
    /// <param name="_treeList">The treelist!</param>
    /// <returns>true if we found a node with the label, false if not</returns>
    public bool GetWay(string _label, List<BifiTree> _treeList)
    {
      // Pre-order traversal
      
      // Process node itself
      if(this.Left == null && this.Right == null)
      {
        if(this.Label == _label)
        {
          _treeList.Add(this);
          return true;
        }
      }
      // Node itself is not the one to look for...
      

      // First go left...
      if (this.Left != null)
      {
        if (Left.GetWay(_label, _treeList))
        {
          _treeList.Add(this);
          return true;
        }
      }

      // Then go right...
      if (this.Right != null)
      {
        if (Right.GetWay(_label, _treeList))
        {
          _treeList.Add(this);
          return true;
        }
      }

      return false;
      
    }

  }
}
