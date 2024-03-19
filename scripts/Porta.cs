using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Porta : MonoBehaviour
{
    GameObject alvo;
    GameObject porta;
    public int numeroP;
    void Start()
    {
        alvo = GameObject.Find("Alvo (" + numeroP + ")");
        porta = GameObject.Find("Porta (" + numeroP + ")");
    }
    void Update()
    {
        if(alvo == null){
            Destroy(porta, 0.5f);
            Debug.Log("Aberta");
        }
    }
}
