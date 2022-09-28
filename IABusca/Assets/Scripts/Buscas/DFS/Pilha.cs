using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilha 
{
    private int size;
    private int top;
    private Node[] nodes;

    public Pilha(int size) 
    {
        this.size = size;
        nodes = new Node[this.size];
        top = -1;
    }

    public void StackUp(Node node) 
    {
        if (!IsFull())
        {
            nodes[++top] = node;
        }
        else { Debug.Log("A pilha está cheia"); }
    }
    public Node Unstack() 
    {
        if (!IsEmpty())
        {
            return nodes[top--];
        }
        else { Debug.Log("Pilha vazia"); return null; }
    }

    public Node getTop() 
    {
        return nodes[top];
    }
    private bool IsEmpty() 
    {
        return (top == -1);
    }

    private bool IsFull() 
    {
        return top == (size - 1);
    }
}
