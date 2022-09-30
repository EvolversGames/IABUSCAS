using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VetorOrdenado 
{

    private Node[] nodes;
    private int numberElements;

    public VetorOrdenado(int size) 
    {
        nodes = new Node[size];
        numberElements = 0;
    }

    public Node getFirstElement() 
    {
        return nodes[0];
    }
    public void Inserir(Node node) 
    {
        int position;
        for (position = 0; position < numberElements; position++)
        {
            if (nodes[position].distanceTarget > node.distanceTarget) 
            {
                break;   
            }
        }

        for (int i = numberElements; i > position; i--)
        {
            nodes[i] = nodes[i - 1];
        }

        nodes[position] = node;
        numberElements++;
    }

    public void Mostrar() 
    {
        for (int i = 0; i < numberElements; i++)
        {
            Debug.Log("Adjacentes: " + nodes[i].nameNode + " -- " + nodes[i].distanceTarget);
        }
    }
}
