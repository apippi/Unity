using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateReal2 : MonoBehaviour
{
    public int cuanto = 10;

    public void UpdateFake()
    {
        int a = 0;
        for (int i = 0; i < cuanto; i++)
            a++;
    }
}
