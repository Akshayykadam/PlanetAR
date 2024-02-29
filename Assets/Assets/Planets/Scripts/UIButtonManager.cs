using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonManager : MonoBehaviour
{
    private void Start()
    {
        Application.targetFrameRate = 120;
    }

    public void LoadPlanetSceneAndSetPlanetName(string planetName)
    {
        PlanetData.selectedPlanetName = planetName;
        SceneManager.LoadScene("PlanetScene");
    }
}
