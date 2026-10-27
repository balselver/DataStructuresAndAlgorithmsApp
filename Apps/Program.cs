using CustomTypes;
using DataStructures.LinkedList.DoublyLinkedList;
using DataStructures.LinkedList.SinglyLinkedList;
using DataStructures.Stack;
using DataStructures.Tree.BinaryTree;
using DataStructures.Tree.BST;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }

        private static void CustomTypeSortingAlgorithmsApp()
        {
            //sıralama algoritmaları - Special type

            var arr = new Student[]
              {
                    new Student(15,"Ayşe",2.40),
                    new Student(16,"Sema",3.90),
                    new Student(17,"Eren",2.50),
                    new Student(18,"Fatma",2.65),
                    new Student(19,"Omer",3.10),
                    new Student(20,"Filiz",1.45),
                    new Student(21,"Mete",3.80),
                    new Student(22,"Merve",2.20),
                    new Student(23,"Semih",2.80)
              };


            DataStructures.SortingAlgorithms.InsertionSort.Sort<Student>(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------");

            DataStructures.SortingAlgorithms.InsertionSort.Sort<Student>(arr,
                DataStructures.Shared.SortDirection.Descending);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        private static void CustomTypeMaxHeapAndMinHeapApp()
        {
            var arr = new Student[]
               {
                    new Student(15,"Ayşe",2.40),
                    new Student(16,"Sema",3.90),
                    new Student(17,"Eren",2.50),
                    new Student(18,"Fatma",2.65),
                    new Student(19,"Omer",3.10),
                    new Student(20,"Filiz",1.45),
                    new Student(21,"Mete",3.80),
                    new Student(22,"Merve",2.20),
                    new Student(23,"Semih",2.80)
               };
            Console.WriteLine("Minheap-------");
            var heap = new DataStructures
                .Heap
                .MinHeap<Student>(arr);
            foreach (var item in heap)
            {
                Console.WriteLine(heap.DeleteMinMax());
            }

            Console.WriteLine("MaXHeap-------");
            var maxHeap = new DataStructures
                .Heap
                .BinaryHeap<Student>(DataStructures.Shared.SortDirection.Descending, arr);
            foreach (var item in maxHeap)
            {
                Console.WriteLine(maxHeap.DeleteMinMax());
            }
        }
        private static void CustomTypeBSTApp()
        {
            var arr = new Student[]
               {
                    new Student(15,"Ayşe",2.40),
                    new Student(16,"Sema",3.90),
                    new Student(17,"Eren",2.50),
                    new Student(18,"Fatma",2.65),
                    new Student(19,"Omer",3.10),
                    new Student(20,"Filiz",1.45),
                    new Student(21,"Mete",3.80),
                    new Student(22,"Merve",2.20),
                    new Student(23,"Semih",2.80)
               };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");
            var bst = new DataStructures
                .Tree
                .BST
                .BST<Student>(arr);

            foreach (var item in bst)
            {
                Console.WriteLine(item);
            }
        }
        private static void CustomTypeSinglyLinkedListApp()
        {
            var arr = new Student[]
               {
                    new Student(15,"Ayşe",2.40),
                    new Student(16,"Sema",3.90),
                    new Student(17,"Eren",2.50),
                    new Student(18,"Fatma",2.65),
                    new Student(19,"Omer",3.10),
                    new Student(20,"Filiz",1.45),
                    new Student(21,"Mete",3.80),
                    new Student(22,"Merve",2.20),
                    new Student(23,"Semih",2.80)
               };

            var linkedList = new DataStructures
                .LinkedList
                .SinglyLinkedList
                .SinglyLinkedList<Student>(arr);

            linkedList.AddAfter(linkedList.Head, new Student(99, "Yiğit", 4.00));

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
        private static void CustomTypeArrayApp()
        {
            var arr = new Student[]
                {
                    new Student(15,"Ayşe",2.40),
                    new Student(16,"Sema",3.90),
                    new Student(17,"Eren",2.50),
                    new Student(18,"Fatma",2.65),
                    new Student(19,"Omer",3.10),
                    new Student(20,"Filiz",1.45),
                    new Student(21,"Mete",3.80),
                    new Student(22,"Merve",2.20),
                    new Student(23,"Semih",2.80)
                };


            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------");

            var newArr = new DataStructures
                .Array
                .Array<Student>(arr);

            newArr.Add(new Student(24, "Mustafa", 3.90));

            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }
        }
        private static void CustomTypeApp01()
        {
            var student1 = new Student(20, "Çalışkan Sema", 3.40);

            var student = new Student()
            {
                Id = 10,
                Name = " Eren ",
                GPA = 1.30
            };

            Console.WriteLine(student);
        }
        private static void HeapSortAlgorithmsApp()
        {
            var array = new sbyte[] { 16, 23, 44, 12, 55, 40, 6 };

            Console.WriteLine("Sırasız dizi: ");
            foreach (var item in array)
            {
                Console.Write($"{item,-5}");
            }
            Console.WriteLine();

            var heap = new DataStructures.Heap.MinHeap<sbyte>(array);

            Console.WriteLine("Sıralı dizi: ");
            foreach (var item in heap)
            {
                Console.Write($"{heap.DeleteMinMax(),-5}");
            }
            Console.WriteLine();
        }
        private static void MergeSortAlgorithmApp()
        {
            var array = new sbyte[] { 16, 23, 44, 12, 55, 40, 6 };

            Console.WriteLine("Sırasız dizi: ");
            foreach (var item in array)
            {
                Console.Write($"{item,-5}");
            }
            Console.WriteLine();

            DataStructures.SortingAlgorithms.MergeSort.Sort<sbyte>(array);

            Console.WriteLine("Sıralı dizi: ");
            foreach (var item in array)
            {
                Console.Write($"{item,-5}");
            }
            Console.WriteLine();
        }
        private static void QuickSortAlgorithmApp()
        {
            var array = new int[] { 16, 23, 44, 12, 55, 40, 6 };

            Console.WriteLine("Sırasız dizi: ");
            foreach (var item in array)
            {
                Console.Write($"{item,-5}");
            }
            Console.WriteLine();

            DataStructures.SortingAlgorithms.QuickSort.Sort<int>(array);
            Console.WriteLine("Sıralı dizi: ");
            foreach (var item in array)
            {
                Console.Write($"{item,-5}");
            }
            Console.WriteLine();
        }
        private static void InsertionSortAlgorithmApp()
        {
            var array = new int[] { 16, 23, 44, 12, 55, 40, 6 };

            Console.WriteLine("Sırasız dizi: ");
            foreach (var item in array)
            {
                Console.Write($"{item,-5}");
            }
            Console.WriteLine();

            DataStructures.SortingAlgorithms.InsertionSort.Sort<int>(array,
                DataStructures.Shared.SortDirection.Descending);

            Console.WriteLine("Sıralı dizi: ");
            foreach (var item in array)
            {
                Console.Write($"{item,-5}");
            }
            Console.WriteLine();

            DataStructures.SortingAlgorithms.InsertionSort.Sort<int>(array);
            Console.WriteLine("Sıralı dizi: ");
            foreach (var item in array)
            {
                Console.Write($"{item,-5}");
            }
            Console.WriteLine();
        }
        private static void BubbleSortAlgorithmsApp()
        {
            var array = new int[] { 16, 23, 44, 12, 55, 40, 6 };

            Console.WriteLine("Sırasız dizi: ");
            foreach (var item in array)
            {
                Console.Write($"{item,-5}");
            }
            Console.WriteLine();

            DataStructures.SortingAlgorithms.BubbleSort.Sort<int>(array);

            Console.WriteLine("sıralı dizi : ");
            foreach (var item in array)
            {
                Console.Write($"{item,-5}");
            }
        }
        private static void SelectionSortAlgorithmsApp()
        {
            var array = new int[] { 16, 23, 44, 12, 55, 40, 6 };

            Console.WriteLine("Sırasız dizi: ");
            foreach (var item in array)
                Console.WriteLine($"{item,-5}");

            Console.WriteLine();

            DataStructures.SortingAlgorithms.SelectionSort.Sort<int>(array,
                DataStructures.Shared.SortDirection.Descending);

            Console.WriteLine("Sıralı dizi: ");
            foreach (var item in array)
                Console.WriteLine($"{item,-5}");
        }
        private static void MinimumSpanningTreeKruksalAlgorithmApp()
        {
            var graph = new DataStructures
                .Graph
                .AdjancencySet
                .WeightedGraph<int, int>();

            for (int i = 0; i < 12; i++)
                graph.AddVertex(i);

            graph.AddEdge(0, 1, 4);
            graph.AddEdge(0, 7, 8);
            graph.AddEdge(1, 7, 11);
            graph.AddEdge(7, 8, 7);
            graph.AddEdge(1, 2, 8);
            graph.AddEdge(7, 6, 1);
            graph.AddEdge(2, 8, 2);
            graph.AddEdge(8, 6, 6);
            graph.AddEdge(6, 5, 2);
            graph.AddEdge(2, 5, 4);
            graph.AddEdge(2, 3, 7);
            graph.AddEdge(3, 5, 14);
            graph.AddEdge(3, 4, 9);
            graph.AddEdge(5, 4, 10);

            var algorithm = new DataStructures
                .Graph
                .MinimumSpanningTree
                .Kruskals<int, int>();

            algorithm.FindMinimumSpanningTree(graph)
                .ForEach(edge => Console.WriteLine(edge));
        }
        private static void MİnimumSpanningTreePrimsApp()
        {
            var graph = new DataStructures
                .Graph
                .AdjancencySet
                .WeightedGraph<int, int>();

            for (int i = 0; i < 12; i++)
                graph.AddVertex(i);

            graph.AddEdge(0, 1, 4);
            graph.AddEdge(0, 7, 8);
            graph.AddEdge(1, 7, 11);
            graph.AddEdge(7, 8, 7);
            graph.AddEdge(1, 2, 8);
            graph.AddEdge(7, 6, 1);
            graph.AddEdge(2, 8, 2);
            graph.AddEdge(8, 6, 6);
            graph.AddEdge(6, 5, 2);
            graph.AddEdge(2, 5, 4);
            graph.AddEdge(2, 3, 7);
            graph.AddEdge(3, 5, 14);
            graph.AddEdge(3, 4, 9);
            graph.AddEdge(5, 4, 10);

            var algorithm = new DataStructures
                .Graph
                .MinimumSpanningTree
                .Prims<int, int>();

            algorithm.FindMinimumSpanningTree(graph)
                .ForEach(edge => Console.WriteLine(edge));
        }
        private static void BFSSearchAlgorithmApp()
        {
            var graph = new DataStructures
                .Graph
                .AdjancencySet
                .Graph<int>();

            for (int i = 0; i < 12; i++)
                graph.AddVertex(i);

            graph.AddEdge(0, 1);
            graph.AddEdge(1, 4);
            graph.AddEdge(0, 4);
            graph.AddEdge(0, 2);
            graph.AddEdge(2, 5);
            graph.AddEdge(2, 10);
            graph.AddEdge(10, 11);
            graph.AddEdge(11, 9);
            graph.AddEdge(2, 9);
            graph.AddEdge(5, 7);
            graph.AddEdge(7, 8);
            graph.AddEdge(5, 8);
            graph.AddEdge(5, 6);

            var algortithm = new DataStructures
                .Graph
                .Search
                .BreadthFirst<int>();

            Console.WriteLine(algortithm.Find(graph, 23) ? "Yes." : "No !");
        }
        private static void DFSSearchAlgorithmApp()
        {
            var graph = new DataStructures
                .Graph
                .AdjancencySet
                .Graph<int>();

            for (int i = 0; i <= 11; i++)
                graph.AddVertex(i);

            graph.AddEdge(0, 1);
            graph.AddEdge(1, 4);
            graph.AddEdge(0, 4);
            graph.AddEdge(0, 2);
            graph.AddEdge(2, 5);
            graph.AddEdge(2, 10);
            graph.AddEdge(10, 11);
            graph.AddEdge(11, 9);
            graph.AddEdge(2, 9);
            graph.AddEdge(5, 7);
            graph.AddEdge(7, 8);
            graph.AddEdge(5, 8);
            graph.AddEdge(5, 6);

            var algoritm = new DataStructures
                .Graph
                .Search
                .DepthFirst<int>();

            Console.WriteLine("{0}", algoritm.Find(graph, 5)
                ? "Yes." : "No !");
        }
        private static void WeightedDiGraphApp()
        {
            var graph = new DataStructures
                .Graph
                .AdjancencySet
                .WeightedDiGraph<char, int>(new char[] { 'A', 'B', 'C', 'D', 'E' });

            Console.WriteLine($"Number of vertex in this graph : {graph.Count}");

            graph.AddEdge('A', 'C', 12);
            graph.AddEdge('A', 'D', 60);
            graph.AddEdge('B', 'A', 10);
            graph.AddEdge('C', 'D', 32);
            graph.AddEdge('C', 'B', 20);
            graph.AddEdge('E', 'A', 7);

            Console.WriteLine("Is an edge between A and B ? : {0}",
                graph.HasEdge('A', 'B') ? "Yes." : "No !");

            Console.WriteLine("Is an edge between B and A ? : {0}",
                graph.HasEdge('B', 'A') ? "Yes." : "No !");

            foreach (var vertexKey in graph)
            {
                Console.WriteLine(vertexKey);
                foreach (char key in graph.GetVertex(vertexKey))
                {
                    var nodeU = graph.GetVertex(vertexKey);
                    var nodev = graph.GetVertex(key);
                    var w = nodeU.GetEdge(nodev).Weight<int>();

                    Console.WriteLine($"   {vertexKey} -" +
                        $"   ({w}) -" +
                        $"   {key} ");
                }
            }
        }
        private static void DiGraphApp()
        {
            var graph = new DataStructures
                .Graph
                .AdjancencySet
                .DiGraph<char>(new char[] { 'A', 'B', 'C', 'D', 'E' });

            graph.AddEdge('B', 'A');
            graph.AddEdge('A', 'D');
            graph.AddEdge('D', 'E');
            graph.AddEdge('C', 'D');
            graph.AddEdge('C', 'E');
            graph.AddEdge('C', 'A');
            graph.AddEdge('C', 'B');

            graph.RemoveVertex('C');

            Console.WriteLine("ıs there an edge between A and B ? {0} ",
                graph.HasEdge('A', 'B') ? "Yes." : "No!");

            Console.WriteLine("ıs there an edge between B and A ? {0} ",
                graph.HasEdge('B', 'A') ? "Yes." : "No!");

            foreach (var key in graph)
            {
                Console.WriteLine(key);
                foreach (char item in graph.GetVertex(key))
                {
                    Console.WriteLine($"   {item}");
                }
            }

            Console.WriteLine($"Number of vertex in graph : {graph.Count}");
        }
        private static void WeightedGraphApp()
        {
            var graph = new DataStructures
                .Graph
                .AdjancencySet
                .WeightedGraph<char, double>
                (new char[] { 'A', 'B', 'C', 'D' });

            graph.AddEdge('A', 'B', 1.2);
            graph.AddEdge('A', 'D', 2.3);
            graph.AddEdge('D', 'C', 5.5);


            Console.WriteLine("Is there an edge between A and B ? {0}",
                graph.HasEdge('A', 'B') ? "Yes." : "No!");

            Console.WriteLine("Is there an edge between B and A ? {0}",
                graph.HasEdge('B', 'A') ? "Yes." : "No!");

            foreach (char vertex in graph)
            {
                Console.WriteLine(vertex);
                foreach (char key in graph.GetVertex(vertex))//düğümlerin ilişkili olduğu düğümleri verir
                {
                    var node = graph.GetVertex(key);
                    Console.WriteLine($" {vertex}-- " +
                        //ağırlık bilgisi burada verildi
                        $"{node.GetEdge(graph.GetVertex(vertex)).Weight<double>()}" +
                        $" --{key}");
                }
            }

            Console.WriteLine($"Number of vertex in graph : {graph.Count}");
        }
        private static void NormalGraphApp()
        {
            var graph = new DataStructures
                .Graph
                .AdjancencySet
                .Graph<char>(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' });

            graph.AddEdge('A', 'B');
            graph.AddEdge('A', 'D');
            graph.AddEdge('C', 'D');
            graph.AddEdge('C', 'E');
            graph.AddEdge('D', 'E');
            graph.AddEdge('E', 'F');
            graph.AddEdge('F', 'G');

            Console.WriteLine("Is there an edge between A and B ? {0}",
                graph.HasEdge('A', 'B') ? "Yes" : "No");

            Console.WriteLine("Is there an edge between A and B ? {0}",
                graph.HasEdge('B', 'A') ? "Yes" : "No");

            Console.WriteLine("Is there an edge between B and D ? {0}",
                graph.HasEdge('B', 'D') ? "Yes" : "No");

            Console.WriteLine("Is there an edge between D and B ? {0}",
                graph.HasEdge('D', 'B') ? "Yes" : "No");

            foreach (var key in graph)
            {
                Console.WriteLine(key);

                foreach (var vertex in graph.GetVertex(key).Edges)
                {
                    Console.WriteLine("   {0} ", vertex);
                }

            }
            Console.WriteLine($"\nNumber of vretex in graph : {graph.Count}");
        }
        private static void DisjointSetApp()
        {
            var disjointSet = new DataStructures
                .Set
                .DisjointSet<int>(new int[] { 0, 1, 2, 3, 4, 5, 6 });

            disjointSet.Union(5, 6);
            disjointSet.Union(1, 2);
            disjointSet.Union(0, 2);

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Find({i}) = {disjointSet.FindSet(i)}");
            }
        }
        private static void BİnaryHeapMAaxHeapMinHeap()
        {
            //Asendinf = MİnHeap
            //Descending = MaxHeap

            var heap = new
                DataStructures
                .Heap
                .BinaryHeap<int>(DataStructures.Shared.SortDirection.Ascending,
                new int[] { 54, 45, 36, 27, 29, 18, 21, 99 });

            foreach (var item in heap)
            {
                Console.Write(item + "  ");
            }
        }
        private static void BinaryHeapMaxHeapApp()
        {
            var heap = new DataStructures
                .Heap
                .MaxHeap<int>(new int[] { 54, 45, 36, 27, 29, 18, 21, 11, 99 });

            Console.WriteLine($" {heap.DeleteMinMax()} : has been removed ");
            Console.WriteLine($" {heap.DeleteMinMax()} : has been removed ");
            Console.WriteLine($" {heap.DeleteMinMax()} : has been removed ");


            foreach (var item in heap)
            {
                Console.Write(item + "  ");
            }
        }
        private static void BinaryHeapMinHeapApp()
        {
            var heap = new DataStructures
                .Heap
                .MinHeap<int>(new int[] { 4, 1, 10, 8, 7, 5, 9, 3, 2 });

            Console.WriteLine(heap.DeleteMinMax() + " Has been removed");
            Console.WriteLine(heap.DeleteMinMax() + " Has been removed");
            Console.WriteLine(heap.DeleteMinMax() + " Has been removed");
            Console.WriteLine(heap.DeleteMinMax() + " Has been removed");
            Console.WriteLine(heap.DeleteMinMax() + " Has been removed");

            foreach (var item in heap)
            {
                Console.WriteLine(item);
            }
        }
        private static void BinaryTreeGetEnumerator()
        {
            var bst =
                new BST<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });
            foreach (var node in bst)
            {
                Console.Write(node);
            }
        }
        private static void BinaryTreePathsApp()
        {
            var bst = new BST<int>(new int[] { 23, 16, 45, 3, 22, 37, 99, 100 });
            bst.Remove(bst.Root, 22);
            new BinaryTree<int>().PrintPaths(bst.Root);
        }
        private static void BinaryTreeNumberOfLeafsApp()
        {
            var bst =
                new BST<int>
                (new int[] { 23, 16, 45, 3, 22, 37, 99 });

            bst.Remove(bst.Root, 3); //3 yaprağını sil
            bst.Remove(bst.Root, 99); //99 yaprağını sil


            //yaprak sayısının hesaplanması
            Console.WriteLine($"Number of Leafs : " +
                $"{BinaryTree<int>.NumberOfLeafs(bst.Root)}");

            Console.WriteLine($"Number of full node : " +
                $"{BinaryTree<int>.NumberOfFullNodes(bst.Root)}");

            Console.WriteLine($"Number of half node : " +
                $"{BinaryTree<int>.NumberOfHalfNode(bst.Root)}");
        }
        private static void BinaryTreeDeepestApp()
        {
            var bt = new DataStructures
                .Tree
                .BinaryTree
                .BinaryTree<char>();

            bt.Root = new Node<char>('F');
            bt.Root.Left = new Node<char>('A');
            bt.Root.Right = new Node<char>('T');
            bt.Root.Left.Left = new Node<char>('D');

            var list = bt.LevelOrderNonRecursiveTraversal(bt.Root);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine($"Deepest Node   : {bt.DeepestNode(bt.Root)}");
            Console.WriteLine($"Deepest Node   : {bt.DeepestNode()}");
            Console.WriteLine($"Max Depth Node   : {BinaryTree<char>.MaxDepth(bt.Root)}");
        }
        private static void BinaryTreeMaxDepthApp()
        {
            var bst = new DataStructures
                .Tree
                .BST
                .BST<byte>(new byte[] { 60, 40, 70, 20, 45, 65, 85, 90 });

            var list = new DataStructures
                .Tree.BinaryTree.BinaryTree<byte>()
                .InOrder(bst.Root);

            foreach (var node in list)
            {
                Console.Write($"{node,-3} ");
            }
            Console.WriteLine();

            Console.WriteLine($"Min        : {bst.FindMin(bst.Root)}");
            Console.WriteLine($"Max        : {bst.FindMax(bst.Root)}");
            Console.WriteLine($"Depth      : " +
                $"{DataStructures.Tree.BinaryTree.BinaryTree<byte>.MaxDepth(bst.Root)}");
        }
        private static void BİnaryTreeRemoveApp()
        {
            var BST = new
                BST<int>(new List<int>()
                { 60,40,70,20,45,65,85 });
            var bt = new BinaryTree<int>();

            bt.InOrder(BST.Root)
               .ForEach(node => Console.Write($"{node,-3} "));

            BST.Remove(BST.Root, 20);
            BST.Remove(BST.Root, 40);
            BST.Remove(BST.Root, 60);

            bt.ClearList();

            Console.WriteLine();
            bt.InOrder(BST.Root)
                .ForEach(node => Console.Write($"{node,-3} "));
        }
        private static void BinaryTreeApp()
        {
            var BST = new
                BST<int>(new int[]
                { 23, 16, 45, 3, 22, 37, 99 });

            var bt = new BinaryTree<int>();
            /*bt.PreOrder(BST.Root)
                .ForEach(node => Console.Write($"{node,-3} "));

            Console.WriteLine();
            bt.PreOrderNonRecursiveTraversal(BST.Root)
                .ForEach(node => Console.Write($"{node,-3} "));
            */
            Console.WriteLine("\nlevel order traversal\n");

            bt.LevelOrderNonRecursiveTraversal(BST.Root)
                .ForEach(node => Console.Write($"{node,-3} "));
            /*
            bt.InOrder(BST.Root)
                .ForEach(node => Console.Write($"{node,-3} "));

            Console.WriteLine();
            bt.InOrderNonRecursiveTraversal(BST.Root)
                .ForEach(node => Console.Write($"{node,-3} "));           

            bt.ClearList(); //nesne oluşturularak metotlar çağırıldığı için bu metotşa listenin temizlenmesi gerekir.
            */

            /*
            bt.ClearList();

            bt.PostOrder(BST.Root)
                .ForEach(node => Console.Write($"{node,-3} "));
            */
            Console.WriteLine();
            Console.WriteLine($"Minimum Value : {BST.FindMin(BST.Root.Right)}");
            Console.WriteLine($"Maximum Value : {BST.FindMax(BST.Root.Left)}");

            var keyNode = BST.Find(BST.Root, 20);
            if (keyNode != null)
                Console.WriteLine($"" +
                $"{keyNode.Value} -" +
                $" Left : {keyNode.Left.Value} - " +
                $"Right : {keyNode.Right.Value}");
        }
        private static void QueueApp01()
        {
            var numbers = new int[] { 10, 20, 30 };
            var q1 = new DataStructures.Queue.Queue<int>();
            var q2 = new DataStructures
                .Queue
                .Queue<int>(DataStructures.Queue.QueueType.LinkedList);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
                q1.EnQueue(number);
                q2.EnQueue(number);
            }
            Console.WriteLine($"q1 count : {q1.Count}");
            Console.WriteLine($"q2 count : {q2.Count}");

            Console.WriteLine($"{q1.DeQueue()} has been removed from q1");
            Console.WriteLine($"{q2.DeQueue()} has been removed from q2");

            Console.WriteLine($"q1 peek : {q1.Peek()}");
            Console.WriteLine($"q2 peek : {q2.Peek()}");
        }
        private static void StackApp01()
        {
            var charset = new char[] { 'a', 'b', 'c', 'd', 'e' };
            var stack1 = new DataStructures.Stack.Stack<char>();
            var stack2 = new DataStructures.Stack.Stack<char>(StackType.LinkedList);

            foreach (var c in charset)
            {
                Console.WriteLine(c);
                stack1.Push(c);
                stack2.Push(c);
            }


            Console.WriteLine("\npeek");
            Console.WriteLine($"Stack 1 : {stack1.Peek()}");
            Console.WriteLine($"Stack 2 : {stack2.Peek()}");

            Console.WriteLine("\ncount");
            Console.WriteLine($"Stack 1 : {stack1.Count}");
            Console.WriteLine($"Stack 2 : {stack2.Count}");

            Console.WriteLine("\npop");
            Console.WriteLine($"Stack 1 : {stack1.Pop()} has been removed");
            Console.WriteLine($"Stack 2 : {stack2.Pop()} has been removed");
        }
        private static void DoublyLinkedListApp03()
        {
            var list = new DoublyLinkedList<int>(new int[] { 23, 44, 55, 61 });
            list.Remove(55);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        private static void DoublyLinkedListApp02()
        {
            var list = new DoublyLinkedList<char>(new List<char>() { 'a', 'b', 'c', 'x', 'y' });

            Console.WriteLine($"{list.RemoveFirst()} has been removed from list");
            Console.WriteLine($"{list.RemoveLast()} has been removed from the list");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        private static void DoublyLinkedListApp01()
        {
            var list = new DoublyLinkedList<int>();
            list.AddFirst(12);
            list.AddFirst(23);
            //23 12
            list.AddLast(44);
            list.AddLast(55);
            //23 12 44 55
            list.AddAfter(list.Head.Next,
                new DoublyLinkedListNode<int>(13));
            //23 12 13 44 55

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        private static void SinglyLinkedListApp05()
        {
            var list = new SinglyLinkedList<int>(new int[] { 23, 44, 32, 55 });
            list.Remove(32);
            /*list.Remove(55);
            list.Remove(44);
            list.Remove(23);*/
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        private static void SinglyLinkedListApp04()
        {
            var rnd = new Random();
            var initial = Enumerable.Range(1, 5).OrderBy(x => rnd.Next()).ToList();
            var list = new SinglyLinkedList<int>(initial);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveFirst();
            list.RemoveFirst();

            Console.WriteLine($"{list.RemoveLast()} has been removed ");


            foreach (var item in list)
            {
                Console.Write(item);
            }
        }
        private static void SinglyLinkedListApp03()
        {
            // Language Integrated Query - LINQ
            var rnd = new Random();
            var initial = Enumerable.Range(1, 10).OrderBy(x => rnd.Next()).ToList();
            var linkedList = new SinglyLinkedList<int>(initial);

            var q = from item in linkedList
                    where item % 2 == 1
                    select item;
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            linkedList.Where(x => x > 5)
                .ToList()
                .ForEach(x => Console.Write(x + " "));
        }
        private static void SinglyLinkedListApp02()
        {
            var arr = new char[] { 'a', 'b', 'c' };
            var list = new List<char>(arr);
            var clinkedList = new LinkedList<char>(arr);
            list.AddRange(new char[] { 'd', 'e', });

            var linkedList = new SinglyLinkedList<char>(list);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            var charset = new List<char>(linkedList);
            foreach (var item in charset)
            {
                Console.Write(item);
            }
        }
        private static void SinglyLinkedListApp01()
        {
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            //3 2 1 baştan ekleme yapar O(1)

            linkedList.AddLast(4);
            linkedList.AddLast(5);
            //3 2 1 4 5 o(n)

            linkedList.AddAfter(linkedList.Head.Next, 32);
            linkedList.AddAfter(linkedList.Head.Next.Next, 33);
            //3 2 32 33 1 4 5 

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            var list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }       

    }
}
