using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class DFS: MonoBehaviour
{
    private Pilha pilha;
    private Node nodeStart;
    private Node nodeEnd;
    private bool isEnd;



    public void InizializarDFS(Node nodeStart, Node nodeEnd, int size) 
    {
        this.nodeStart = nodeStart;
        this.nodeStart.isVisited = true;
        this.nodeEnd = nodeEnd;
        this.isEnd = false;
        pilha = new Pilha(size);
        pilha.StackUp(this.nodeStart);
    }

    public void Search() 
    {
        Node topNode = pilha.getTop();
        Debug.Log("Topo: " + topNode.nameNode);

        if (topNode == nodeEnd)
        {
            isEnd = true;
        }
        else
        {

            foreach (Edge edge in topNode.getEdges())
            {
                if (!isEnd)
                {
                    Debug.Log("Verificando se já vistado" + edge.getNode().nameNode);
                    if (!edge.getNode().isVisited)
                    {
                        edge.getNode().ChangeColor();
                        edge.getNode().isVisited = true;
                        pilha.StackUp(edge.getNode());
                        Search();
              
                    }
                }
            }
        }
        Debug.Log("Desempilhou: " + pilha.Unstack().nameNode);
    }


}
