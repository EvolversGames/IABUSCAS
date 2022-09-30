using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gulosa : MonoBehaviour
{
    private VetorOrdenado vetorOrdenado;
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
            vetorOrdenado = new VetorOrdenado(nodeCurrent.getEdges().Count);

            foreach (Edge edge in nodeCurrent.getEdges())
            {
                if (!edge.node.isVisited) 
                {
                    edge.node.isVisited = true;
                    vetorOrdenado.Inserir(edge.node);
                }
            }

            vetorOrdenado.Mostrar();

            if (vetorOrdenado.getFirstElement() != null) 
            {
                Search(vetorOrdenado.getFirstElement()); //recursivo
            }
           
        }
    }

   
}
