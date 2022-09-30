using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grafo : MonoBehaviour
{
    //Grafo contem nodes
    public Node[] nodes;
    public int sizeNodes;
    public DFS dFS;

    public Gulosa gulosa;

    public VetorOrdenado vetorOrdenado;
    // Start is called before the first frame update
    void Awake()
    {
        sizeNodes = transform.childCount;
  
        nodes = new Node[sizeNodes];
    }

    private void Start()
    {
        SetNode();
        // vetorOrdenado = new VetorOrdenado(nodes.Length);
        //dFS.InizializarDFS(nodes[0], nodes[3], sizeNodes);
        //dFS.Search();

        gulosa.Search(nodes[0]);

    }

    void SetNode() 
    {
        for (int i = 0; i < sizeNodes; i++)
        {
           
            nodes[i] = transform.GetChild(i).GetComponent<Node>();
        }
    }

    private void InserirVetor() 
    {
        for (int i = 0; i < sizeNodes; i++)
        {
            vetorOrdenado.Inserir(nodes[i]);
        }
    }
  
}
