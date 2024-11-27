using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class player : MonoBehaviour
{
    public TMP_InputField inputField_word;
    public TextMeshProUGUI numberone_vis;
    public TextMeshProUGUI numbertwo_vis;

    public int numberone;
    public float numbertwo;
    public string word;

    // Start is called before the first frame update
    void Start()
    {
        load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void load()
    {
        Data data = SaveManager.LoadData();
        if (data != null)
        {
            numberone = data.numberone;
            numbertwo = data.numbertwo;
            word = data.word;

            inputField_word.text = word;
            numberone_vis.text = numberone.ToString();
            numbertwo_vis.text = numbertwo.ToString();
        }
        else
        {
            numbertwo = 0;
            numberone = 0;
            word = "";
            numberone_vis.text = "0";
            numbertwo_vis.text = "0";
        }
    }

    public void save()
    {
        SaveManager.SaveData(this);
    }

    public void change_numberone (int change)
    {
        numberone += change;
        numberone_vis.text = numberone.ToString();
    }

    public void change_numbertwo (float change)
    {
        numbertwo += change;
        numbertwo = Mathf.Round(numbertwo * 10f) / 10f;
        numbertwo_vis.text = numbertwo.ToString();
    }

    public void change_word ()
    {
        string change = inputField_word.text;
        Debug.Log(change);
        word = change;
    }
}
