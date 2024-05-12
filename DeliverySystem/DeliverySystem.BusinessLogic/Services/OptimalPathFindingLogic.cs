using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Services
{
    public class OptimalPathFindingLogic
    {
        private class Node
        {
            public int Vertex { get; set; }
            public Node[] ChildNodes { get; set; }
            public bool Selected { get; set; }
        }

        private readonly double[,] _adjacencyMatrix;
        private readonly IEnumerable<int> _vertices;
        private readonly IList<double> _importanceRates;
        private readonly bool _minImporance;

        public OptimalPathFindingLogic(IEnumerable<int> vertices,
            double[,] matrix,
            IList<double> importanceRates,
            bool minImporance)
        {
            _vertices = vertices;
            _adjacencyMatrix = matrix;
            _importanceRates = importanceRates;
            _minImporance = minImporance;
        }


        public IEnumerable<int> Solve(out double cost, out double importanceRateCost)
        {
            var startVertex = _vertices.First();
            var set = new HashSet<int>(_vertices);
            set.Remove(startVertex);

            var root = new Node();
            IList<int> route;
            if (_minImporance)
            {
                importanceRateCost = GetMinimumCostRouteWithImportanceRate(startVertex, set, root, 0);
                route = TraverseTree(root, startVertex).ToList();
                route.Add(startVertex);
                var timeCost = 0.0;
                for (int i = 1; i < route.Count; i++)
                {
                    timeCost += _adjacencyMatrix[route[i - 1], route[i]];
                }
                cost = timeCost;
            }
            else
            {
                cost = GetMinimumCostRoute(startVertex, set, root);
                route = TraverseTree(root, startVertex).ToList();
                route.Add(startVertex);
                var importanceTotal = 0.0;
                var prevoiusTime = 0.0;
                for (int i = 1; i < route.Count; i++)
                {
                    var totalTime = prevoiusTime + _adjacencyMatrix[route[i - 1], route[i]];
                    if (i + 1 == route.Count)
                        importanceTotal += _adjacencyMatrix[route[i - 1], route[i]];
                    else
                        importanceTotal += totalTime * _importanceRates[route[i]];
                    prevoiusTime = totalTime;
                }
                importanceRateCost = importanceTotal;
            }

            return route;
        }

        private double GetMinimumCostRoute(int startVertex, HashSet<int> set, Node root)
        {
            if (!set.Any())
            {
                return _adjacencyMatrix[startVertex, 0];
            }

            double minCostTotal = double.MaxValue;
            int i = 0;
            int selectedIdx = i;
            root.ChildNodes = new Node[set.Count()];

            foreach (var destinationVertex in set)
            {
                root.ChildNodes[i] = new Node { Vertex = destinationVertex };

                double currentVertexCost = _adjacencyMatrix[startVertex, destinationVertex];

                var newSet = new HashSet<int>(set);
                newSet.Remove(destinationVertex);
                double costFromHere = GetMinimumCostRoute(destinationVertex, newSet, root.ChildNodes[i]);
                double newC = currentVertexCost + costFromHere;

                if (minCostTotal > newC)
                {
                    minCostTotal = newC;
                    selectedIdx = i;
                }

                i++;
            }

            root.ChildNodes[selectedIdx].Selected = true;

            return minCostTotal;
        }

        private double GetMinimumCostRouteWithImportanceRate(int startVertex, HashSet<int> set, Node root, double previousCost)
        {
            if (!set.Any())
            {
                return _adjacencyMatrix[startVertex, 0];
            }

            double minCostTotal = double.MaxValue;
            int i = 0;
            int selectedIdx = i;
            root.ChildNodes = new Node[set.Count()];

            foreach (var destinationVertex in set)
            {
                root.ChildNodes[i] = new Node { Vertex = destinationVertex };

                double currentVertexCost = _adjacencyMatrix[startVertex, destinationVertex] + previousCost;
                double importanceRateCost = currentVertexCost * _importanceRates[destinationVertex];

                var newSet = new HashSet<int>(set);
                newSet.Remove(destinationVertex);
                double costFromHere = GetMinimumCostRouteWithImportanceRate(destinationVertex, newSet, root.ChildNodes[i], currentVertexCost);
                double newC = importanceRateCost + costFromHere;

                if (minCostTotal > newC)
                {
                    minCostTotal = newC;
                    selectedIdx = i;
                }

                i++;
            }

            root.ChildNodes[selectedIdx].Selected = true;

            return minCostTotal;
        }

        private IEnumerable<int> TraverseTree(Node root, int startint)
        {
            var q = new Queue<int>();
            q.Enqueue(startint);
            TraverseTreeUtil(root, q);
            return q;
        }

        private void TraverseTreeUtil(Node root, Queue<int> vertices)
        {
            if (root.ChildNodes == null)
            {
                return;
            }

            foreach (var child in root.ChildNodes)
            {
                if (child.Selected)
                {
                    vertices.Enqueue(child.Vertex);
                    TraverseTreeUtil(child, vertices);
                }
            }
        }
    }
}
