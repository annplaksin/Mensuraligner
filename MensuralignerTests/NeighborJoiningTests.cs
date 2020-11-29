using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mensuraligner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mensuraligner.Tests
{
  [TestClass()]
  public class NeighborJoiningTests
  {
    decimal[,] matrix = { 
            { 0m, 22m, 39m, 39m, 41m }, 
            { 22m, 0m, 41m, 41m, 43m }, 
            { 39m, 41m, 0m, 18m, 20m }, 
            { 39m, 41m, 18m, 0m, 10m }, 
            { 41m, 43m, 20m, 10m, 0m } };

    /*decimal[,] matrix = {
        { 0m, 176m, 50m, 244m},
        { 176m, 0m, 149m, 314m},
        { 50m, 149m, 0m, 213m},
        { 244m, 314m, 213m, 0m } };*/


        Dictionary<int, string> labels = new Dictionary<int, string>()
      {
        { 0, "A" },
        { 1, "B" },
        { 2, "C" },
        { 3, "D" },
        { 4, "E" }
      };

    [TestCleanup()]
    public void CleanUp()
    {
      if (File.Exists("NJ.txt"))
      {
        File.Delete("NJ.txt");
      }
    }

    [TestMethod()]
    public void NJ_countEdges()
    {
      NeighborJoining test = new NeighborJoining(matrix, labels);
      int exp = 7;

      int actual = test.NodesAndEdges.Count;

      Assert.AreEqual(exp, actual);
    }

    [TestMethod()]
    public void NJ_outputExists()
    {
      NeighborJoining test = new NeighborJoining(matrix, labels);

      System.IO.File.WriteAllText(@"NJ.txt", test.NewickTree);

      Assert.AreEqual(File.Exists("NJ.txt"), true);
    }

    [TestMethod()]
    public void NJ_Zeros()
    {
      decimal[,] zeros = { { 0m, 0m, 0m }, { 0m, 0m, 0m }, { 0m, 0m, 0m } };
      Dictionary<int, string> zero_labels = new Dictionary<int, string>()
      {
        { 0, "A" },
        { 1, "B" },
        { 2, "C" }
      };

      NeighborJoining zero = new NeighborJoining(zeros, zero_labels);


      System.IO.File.WriteAllText(@"NJ.txt", zero.NewickTree);

      Assert.AreEqual(File.Exists("NJ.txt"), true);
    }
  }
}