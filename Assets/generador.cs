using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generador : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myPrefab;
    public GameObject myPrefab2;
    public int totalObjetos = 500;
    public bool conUpdate = true;
    private Action[] lista;

    void Start()
    {
        if (conUpdate)
        {
            for (int i = 0; i < totalObjetos; i++)
                Instantiate(myPrefab);
            return;
        }
        lista = new Action[totalObjetos];
        for (int i = 0; i < totalObjetos; i++)
            lista[i] = Instantiate(myPrefab2).GetComponent<UpdateReal2>().UpdateFake;
    }
    void Update()
    {
        if (conUpdate)
            return;
        foreach (Action ur2 in lista) {
            ur2();
        }
    }

}
