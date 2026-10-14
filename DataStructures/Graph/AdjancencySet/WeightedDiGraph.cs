using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Graph.AdjancencySet
{
    public class WeightedDiGraph<T, TW> : IDiGraph<T>
        where TW : IComparable
    {
        private Dictionary<T, weightedDiGraphVertex<T, TW>> vertices;

        public IDiGraphVertex<T> ReferenceVertex => vertices[this.First()];

        public IEnumerable<IDiGraphVertex<T>> VerticesAsEnumerable =>
            vertices.Select(x => x.Value);

        public bool isWeightedGraph => true;

        public int Count => vertices.Count;

        IGraphVertex<T> IGraph<T>.ReferenceVertex => 
            vertices[this.First()] as IGraphVertex<T>;

        IEnumerable<IGraphVertex<T>> IGraph<T>.VerticesAsEnumerable =>
           vertices.Select(x => x.Value);

        public WeightedDiGraph()
        {
            vertices = new Dictionary<T, weightedDiGraphVertex<T, TW>>();
        }

        public WeightedDiGraph(IEnumerable<T> collection)
        {
            vertices = new Dictionary<T, weightedDiGraphVertex<T, TW>>();
            foreach (var item in collection)
            {
                AddVertex(item);
            }
        }
        public void AddVertex(T key)
        {
            if (key == null)
                throw new ArgumentNullException();

            var newVertex = new weightedDiGraphVertex<T, TW>(key);
            vertices.Add(key, newVertex);
        }

        IGraph<T> IGraph<T>.Clone()
        {
            return Clone();
        }
        public WeightedDiGraph<T, TW> Clone()
        {
            var graph = new DataStructures
               .Graph
               .AdjancencySet
               .WeightedDiGraph<T, TW>(); // default ctor ile vercises ifadesi newlendi
            foreach (var vertex in vertices)
                graph.AddVertex(vertex.Key);

            foreach (var vertex in vertices)
            {
                foreach (var node in vertex.Value.OutEdges)
                    graph.AddEdge(vertex.Value.Key, node.Key.Key, node.Value);

            }
            return graph; //bu dönüş deepcopydir. tamamen yeni nesnedir
        }
        public bool ContainsVertex(T key)
        {
            return vertices.ContainsKey(key);
        }
        public IEnumerable<T> Edges(T key)
        {
            if (key == null)
                throw new ArgumentNullException();
            return vertices[key].OutEdges.Select(x => x.Key.Key);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return vertices.Select(x => x.Key).GetEnumerator();
        }
        public IDiGraphVertex<T> GetVertex(T key)
        {
            return vertices[key];
        }
        public void RemoveEdge(T source, T dest)
        {
            if (source == null || dest == null)
                throw new ArgumentNullException();

            if (!vertices.ContainsKey(source) || !vertices.ContainsKey(dest))
                throw new ArgumentException("source or destination vertex is not int this graph.");

            if (!vertices[source].OutEdges.ContainsKey(vertices[dest]) ||
                !vertices[dest].InEdges.ContainsKey(vertices[source]))
                throw new Exception("The edge does not exists.");

            vertices[source].OutEdges.Remove(vertices[dest]);
            vertices[dest].InEdges.Remove(vertices[source]);
        }
        public void AddEdge(T source, T dest, TW Weight)
        {
            if (source == null || dest == null)
                throw new ArgumentNullException();

            if (!vertices.ContainsKey(source) || !vertices.ContainsKey(dest))
                throw new ArgumentException("source or destination vertex is not int this graph.");

            if (vertices[source].OutEdges.ContainsKey(vertices[dest]) ||
                vertices[dest].InEdges.ContainsKey(vertices[source]))
                throw new Exception("The edge has been already define");

            vertices[source].OutEdges.Add(vertices[dest], Weight);//A dan B ye
            vertices[dest].InEdges.Add(vertices[source], Weight);//B den A ya
            //vertices[source] ile elde edilen graph vertex ifadesi
        }
        public void RemoveVertex(T key)
        {
            if (key == null)
                throw new ArgumentNullException();

            if (!vertices.ContainsKey(key))
                throw new ArgumentNullException("The vertex is not in this graph");

            foreach (var vertex in vertices[key].InEdges)
                vertex.Key.InEdges.Remove(vertices[key]);

            foreach (var vertex in vertices[key].OutEdges)
                vertex.Key.OutEdges.Remove(vertices[key]);

            vertices.Remove(key);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        IGraphVertex<T> IGraph<T>.GetVertex(T key)
        {
            return vertices[key];
        }

        public bool HasEdge(T source, T dest)
        {

            if (source == null || dest == null)
                throw new ArgumentNullException();

            if (!vertices.ContainsKey(source) || !vertices.ContainsKey(dest))
                throw new ArgumentException("source or destination vertex is not int this graph.");

            return vertices[source].OutEdges.ContainsKey(vertices[dest])//A dan B ye
                && vertices[dest].InEdges.ContainsKey(vertices[source]);//B den A ya
        }

        private class weightedDiGraphVertex<T, TW> : IDiGraphVertex<T>
            where TW : IComparable
        {
            public Dictionary<weightedDiGraphVertex<T, TW>, TW> OutEdges { get; }
            public Dictionary<weightedDiGraphVertex<T, TW>, TW> InEdges { get; }

            IEnumerable<IDiEdge<T>> IDiGraphVertex<T>.OutEdges =>
                OutEdges.Select(x => new DiEdge<T, TW>(x.Key, x.Value));

            IEnumerable<IDiEdge<T>> IDiGraphVertex<T>.InEdges =>
                InEdges.Select(x => new DiEdge<T, TW>(x.Key, x.Value));


            public int OutEdgesCount => OutEdges.Count;

            public int InEdgeCount => InEdges.Count;

            public T Key { get; set; }

            public weightedDiGraphVertex(T key)
            {
                this.Key = key;
                OutEdges = new Dictionary<weightedDiGraphVertex<T, TW>, TW>();
                InEdges = new Dictionary<weightedDiGraphVertex<T, TW>, TW>();
            }

            public IEnumerable<IEdge<T>> Edges =>
                OutEdges.Select(x => new Edge<T, TW>(x.Key, x.Value));

            public IEdge<T> GetEdge(IGraphVertex<T> targetVertex)
            {
                var node = targetVertex as weightedDiGraphVertex<T, TW>;
                return new Edge<T, TW>(targetVertex, OutEdges[node]);
            }

            public IEnumerator<T> GetEnumerator()
            {
                return OutEdges.Select(x => x.Key.Key).GetEnumerator();
            }

            public IDiEdge<T> GetOutEdge(IDiGraphVertex<T> targetVertex)
            {
                var node = targetVertex as weightedDiGraphVertex<T, TW>;
                return new DiEdge<T, TW>(targetVertex, OutEdges[node]);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

    }
}
