using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pasarNombre : MonoBehaviour
{
    private GameObject nombre1;
    public void Start()
    {
        nombre1 = GameObject.FindGameObjectWithTag("nombre1");
        nombre1.GetComponent<Text>().text = PlayerPrefs.GetString("nombre1");
    }

    
    
}
