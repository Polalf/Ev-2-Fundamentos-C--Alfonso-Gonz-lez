using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData 
{
 
    public int enemigosEliminados;
    public int objRecogidos;

    public GameData()
    {
        enemigosEliminados = 0;
        objRecogidos = 0;
    }
}
