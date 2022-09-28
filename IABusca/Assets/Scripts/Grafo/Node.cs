using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public string nameNode;
    public bool isVisited;
    public List<Edge> edges;
    public SpriteRenderer spriteRenderer;
    public Color color;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public Node(string nameNode) 
    {
        this.nameNode   = nameNode;
        isVisited       = false;
       
    }



    public void AddEdges(Edge edge)
    {
        edges.Add(edge);
    }

    public List<Edge> getEdges()
    {
        return edges;
    }

    public void ChangeColor() 
    {
        color = Color.red;
        spriteRenderer.color = color;
    }
}
