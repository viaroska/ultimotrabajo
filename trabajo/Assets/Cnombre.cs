using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cnombre : MonoBehaviour
{
    private GameObject Nombre1;


    private void Start()
    {
        Nombre1 = GameObject.FindGameObjectWithTag("Nombre1");
        Nombre1.GetComponent<Text>().text = PlayerPrefs.GetString("Nombre1");
    }
}

