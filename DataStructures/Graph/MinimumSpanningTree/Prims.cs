using DataStructures.Heap;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graph.MinimumSpanningTree
{
    public class Prims<T, TW>
        where T:IComparable
        where TW:IComparable
    {
        public List<MSTEdge<T, TW>> FindMinimumSpanningTree(IGraph<T> graph)
        {
            var edges = new List<MSTEdge<T, TW>>();

            dfs(graph,
                graph.ReferenceVertex,
                new Heap.BinaryHeap<MSTEdge<T, TW>>(Shared.SortDirection.Ascending),
                new HashSet<T>(), edges);

            return edges;
        }

        private void dfs(IGraph<T> graph, 
            IGraphVertex<T> currentVertex, 
            BinaryHeap<MSTEdge<T, TW>> spNeighbours, 
            HashSet<T> spVertices, 
            List<MSTEdge<T, TW>> spEdges)
        {
            while (true)
            {
                //kenarlara dikkat
                foreach (var edge in currentVertex.Edges)
                {
                    // min-heap
                    var e = new MSTEdge<T, TW>(currentVertex.Key,
                        edge.TargetVertexKey, 
                        edge.Weight<TW>());
                    spNeighbours.Add(e);
                }

                //min edge  : ağırlık anlamında en düşük değere sahip kenar
                var minEdge = spNeighbours.DeleteMinMax();

                // var olan kenarları atla
                while (spVertices.Contains(minEdge.Source) 
                    && spVertices.Contains(minEdge.Destination))
                {
                    minEdge = spNeighbours.DeleteMinMax();
                    if (spNeighbours.Count == 0)
                        return;
                }

                // eklenen vertex takip et
                if (!spVertices.Contains(minEdge.Source))
                {
                    spVertices.Add(minEdge.Source);
                }

                spVertices.Add(minEdge.Destination);
                spEdges.Add(minEdge);

                currentVertex = graph.GetVertex(minEdge.Destination);
            }
        }
    }
}
