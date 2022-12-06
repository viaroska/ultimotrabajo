using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Nombre : MonoBehaviour
{
    public InputField InputText;

    public Text TextoNombre;
    public Image Luz;
    public GameObject BotonAceptar;

    public void Awake()
    {
        Luz.color = Color.red;
    }

    public void Update()
    {
        if (TextoNombre.text.Length < 4)
        {
            Luz.color = Color.red;
            BotonAceptar.SetActive(false);
        }

        if (TextoNombre.text.Length >= 4)
        {
            Luz.color = Color.green;
            BotonAceptar.SetActive(true);
        }
    }

    public void aceptar()
    {
        PlayerPrefs.SetString("nombre1", InputText.text);
        SceneManager.LoadScene("SampleScene");
    }
}
