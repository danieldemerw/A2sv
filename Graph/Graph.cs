using System;
using System.Collections.Generic;

class Graph{
	private int V;
	private List<int>[] adj;
	Graph(int v){
		V=v;
		adj= new List<int>[ v ];
		for (int i = 0;i < v; ++i)
			adj[i] = new List<int>();
	}
	void AddEdge(int v,int w)
	{
		adj[v].Add(w);
	}
	void DFSUtil(int v,bool[] visited)
	{
		visited [v]=true;
		Console.Write(v+"");

		List<int> vList = adj[V];
		foreach(var n in vList){
			if(!visited[n])
				DFSUtil(n,visited);
		}
	}
	void DFS(int v)
	{
		bool[] visited = new bool[V];
		DFSUtil(v,visited);
	}
	public static void Main(String [] args)
	{
		Graph g = new Graph(4);
		g.AddEdge(0,1);
		g.AddEdge(0,2);
		g.AddEdge(1,2);
		g.AddEdge(2,0);
		g.AddEdge(2,3);
		g.AddEdge(3,3);
		
		Console.WriteLine("following is Depth first Traversal");
		g.DFS(2);
		Console.ReadKey();
	}
}
// this code is contriuted by sheshbazzar
