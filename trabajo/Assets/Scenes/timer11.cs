using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class timer11 : MonoBehaviour
{
    public float timer = 0;
    public Text textoTimer;
    public TextMeshProUGUI textoTimerpro;
    // Update is called once per frame
    void Update()
    {
        timer-= Time.deltaTime;
        textoTimer.text = "" + timer.ToString("f1");
        textoTimerpro.text = "" + timer.ToString("f1");
        if (timer<=0)
        {
             print("GAME OVER ");
            SceneManager.LoadScene("SampleScene 1");
        }
    }

    
}
