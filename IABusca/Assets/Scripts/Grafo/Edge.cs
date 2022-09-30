using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Edge : MonoBehaviour
{
    public Node node;
    public int distance;
    private int distanceStar=0;
    public Edge(Node node)
    {
        this.node = node;
    }

    public int GetDistanceAStar() 
    {
        return distanceStar = distance + node.distanceTarget;
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
