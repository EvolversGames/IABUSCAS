using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VetorOrdenadoAdjacente 
{
    private Edge[] edges;
    private int numberElements;

    public VetorOrdenadoAdjacente(int size)
    {
        edges = new Edge[size];
        numberElements = 0;
    }

    public Node getFirstElement()
    {
        return edges[0].node;
    }
    public void Inserir(Edge edge)
    {
        int position;
        for (position = 0; position < numberElements; position++)
        {
            if (edges[position].GetDistanceAStar() > edge.GetDistanceAStar())
            {
                break;
            }
        }

        for (int i = numberElements; i > position; i--)
        {
            edges[i] = edges[i - 1];
        }

        edges[position] = edge;
        numberElements++;
    }

    public void Mostrar()
    {
        for (int i = 0; i < numberElements; i++)
        {
            Debug.Log("Adjacentes: " + edges[i].node.nameNode + " -- " + edges[i].GetDistanceAStar());
        }
    }
}
