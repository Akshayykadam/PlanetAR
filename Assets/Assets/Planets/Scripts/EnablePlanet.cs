using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnablePlanet : MonoBehaviour
{
    public GameObject[] planets;
    public TMP_Text text;

    private void OnEnable()
    {
        // Loop through each planet in the array
        foreach (var planet in planets)
        {
            // Check if the name of the current planet matches the target planet name
            if (planet.name == PlanetData.selectedPlanetName)
            {
                Debug.Log("planetName => 1" + PlanetData.selectedPlanetName);
                planet.SetActive(true);
                text.text = $"Planet {PlanetData.selectedPlanetName}";
            }
            else
            {
                planet.SetActive(false);
            }
        }
    }

    public void Onclick_BackButton()
    {
        SceneManager.LoadScene("HomeScreen");
    }
}
