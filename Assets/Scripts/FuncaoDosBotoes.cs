using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FuncaoDosBotoes : MonoBehaviour
{

    public void Informacoes()
    {
        SceneManager.LoadScene("Info");
    }
    public void NivelFacil()
    {
        SceneManager.LoadScene("Facil");
    }

    public void NivelMedio()
    {
        SceneManager.LoadScene("Medio");
    }

    public void NivelDificil()
    {
        SceneManager.LoadScene("Dificil");
    }

    public void FecharJogo()
    {
        Application.Quit();

    }

    public void Voltar()
    {
        SceneManager.LoadScene("HomeGame");
    }
}

