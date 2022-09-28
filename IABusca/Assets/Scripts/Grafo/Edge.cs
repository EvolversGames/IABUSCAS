using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Edge : MonoBehaviour
{
    public Node node;
    private int distance;


    public Edge(Node node)
    {
        this.node = node;
    }

    public Node getNode() 
    {
        return node;
    }

    public void setNode(Node node) 
    {
        this.node = node;
    }
}
