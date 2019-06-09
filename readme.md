# Prueba de Rendimiento en Unity 5 (2019)

El objetivo es saber si tiene más rendimiento usar Update() y dejar que el Unity haga el trabajo o bien tener un controlador central 
que llame a un metodo UpdateFake() haciendo que el propio Unity no use su Update.

Primero he generado dos scripts idénticos que hacen un bucle y dentro una simple suma, el nùmero de iteraciones viene dado por el valor
de la variable expuesta "cuanto"

Los scripts son UpdateReal y UpdateReal2 siendo el primero el que se lanza con Update() y el segundo contiene UpdateFake()

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


En la escena he puesto un canvas con un texto, el texto tiene asociada una rutina que pone los fps actuales.

En dicho canvas he incluido un script que es el responsable de generar los objetos según el número pedido.

El control de si la ejecución se hace para testar Update() o para UpdateFake(), se realiza mediante un boolean expuesto, "conUpdate"

Si es true se deja que se generan los objetos con Update() sino que se generan los objetos con UpdateFake() y se genera una lista que 
cuando sea el update del canvas se llama al updateFake de todos los elementos.

El numero de objetos es controlado por la variable "totalObjetos"

Para optimizar al maximo he guardado en un Array y no usando List y he guardado directamente la función y no el objeto.

Se puede juegar con las combinaciones  "cuanto" en los updateReal y con el de "totalObjetos" para usar más o menos objetos y que estos 
sean más lentos o rápidos.

## Resultado

El resultado no ha sido muy relevante, teniendo en cuante que casi no hay consumo en lo que hacen necsitamos muchísimos objetos 
20.000 o 30.000 para que se empiece a notar la diferencia.

Es por ello que para un uso normal de unas pocas de decenas no hay diferencia perceptible.

Gonzalo.
