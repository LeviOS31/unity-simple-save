using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data
{
    public int numberone;
    public float numbertwo;
    public string word;

    public Data(player playerfile)
    {
        numberone = playerfile.numberone;
        numbertwo = playerfile.numbertwo;
        word = playerfile.word;
    }
}
