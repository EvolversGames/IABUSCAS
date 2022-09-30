using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AStar : MonoBehaviour
{
    private VetorOrdenadoAdjacente vetorOrdenado;
    public Node nodeTarget;
    private bool isTarget;


    public void Search(Node nodeCurrent)
    {
        Debug.Log("Atual: " + nodeCurrent.nameNode);
        nodeCurrent.isVisited = true;
        if (nodeCurrent == nodeTarget)
        {
            Debug.Log("Encontrou");
            isTarget = true;
        }
        else
        {
            vetorOrdenado = new VetorOrdenadoAdjacente(nodeCurrent.getEdges().Count);

            foreach (Edge edge in nodeCurrent.getEdges())
            {
                if (!edge.node.isVisited)
                {
                    edge.node.isVisited = true;
                    vetorOrdenado.Inserir(edge);
                }
            }

            vetorOrdenado.Mostrar();
            Search(vetorOrdenado.getFirstElement()); //recursivo
            

        }
    }
}
