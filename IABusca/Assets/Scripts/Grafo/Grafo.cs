using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grafo : MonoBehaviour
{
    //Grafo contem nodes
    public Node[] nodes;
    public int sizeNodes;
    public DFS dFS;
    // Start is called before the first frame update
    void Awake()
    {
        sizeNodes = transform.childCount;
  
        nodes = new Node[sizeNodes];
    }

    private void Start()
    {
        SetNode();
        dFS.InizializarDFS(nodes[0], nodes[3], sizeNodes);
        dFS.Search();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 
    void SetNode() 
    {
        for (int i = 0; i < sizeNodes; i++)
        {
           
            nodes[i] = transform.GetChild(i).GetComponent<Node>();
        }
    }

    //void EmpilharNodes() 
    //{
    //    for (int i = 0; i < sizeNodes; i++)
    //    {
    //        pilha.StackUp(nodes[i]);
    //    }
    //    Show();
    //}

    //void UnStack() 
    //{
    //    pilha.Unstack();
    //    Show();
    //}

    //void Show() 
    //{
    //    Debug.Log(pilha.getTop().nameNode);
    //}
}
