using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnablePlanet : MonoBehaviour
{

    string saturnText = "Saturn, the ringed wonder of our solar system, is the second-largest planet after Jupiter. " +
                            "It's a gas giant, mostly hydrogen and helium gas, much like a giant beach ball in space!\n\n" +

                            "* Size: Huge! It's nine times wider than Earth, at 76,480 miles (120,536 kilometers) across.\n" +
                            "* Distance from the Sun: Far out! It's almost 10 times farther than Earth, taking nearly 30 years to orbit the Sun once!\n" +
                            "* Rings: Most famous feature! Amazing ring system made up of billions of icy and rocky chunks.\n" +
                            "* Moons: Over 80 moons! Some interesting ones are Titan with a thick atmosphere and Enceladus with watery jets.";

    string marsText = "Mars, the Red Planet, is our next-door neighbor in space! It's a much smaller world than Earth, only about half the width at 4,224 miles (6,800 kilometers) across.\n\n" +

                          "Like Earth, Mars has mountains, valleys, and even polar ice caps. But unlike Earth, Mars is very cold and dry. It has a very thin atmosphere that can't trap heat, so the surface temperature averages -85°F (-63°C).  Mars is also known for its reddish dust, which comes from iron oxide, or rust, in the Martian soil.";

    string earthText = "Earth, our amazing home, is a giant ball in space about 8,000 miles (12,742 km) wide! It spins and travels around the sun. It's the only planet with liquid water, essential for life as we know it. Earth has land with mountains and oceans, and a big air blanket to protect us!";

    string venusText = "Venus, the scorching sister planet, is Earth's closest neighbor. It's about the same size as Earth, but with a much hotter surface due to a thick atmosphere trapping heat.  Venus is shrouded in thick clouds and has volcanic activity.";

    string jupiterText = "Jupiter, the giant king of the planets, is a massive ball of gas and the largest planet in our solar system! It's about 11 times wider than Earth and has a strong gravity that pulls in many moons.";

    string mercuryText = "Mercury, the speedy planet, is the closest planet to the sun. It's the smallest planet in our solar system and has a rocky surface with big temperature swings between day and night.";

    string neptuneText = "Neptune, the distant blue giant, is the eighth planet from the sun. It's another gas giant, even farther out than Uranus. Neptune has strong winds and a Great Dark Spot, a giant storm system.";

    string uranusText = "Uranus, the icy giant, is the 7th planet, a distant & cold world! It's tilted on its side, causing its poles to experience long periods of sunlight or darkness. Made mostly of icy materials, Uranus has a blue atmosphere due to methane gas. It has faint rings and 28 moons, like Titania. Only Voyager 2 has visited this fascinating giant in 1986.";


    public GameObject[] planets;
    public TMP_Text PlanetNametext;
    public TMP_Text PlanetInfotext;

    private Dictionary<string, string> planetTexts = new Dictionary<string, string>();

    private void Awake()
    {
        InitializePlanetTexts();
    }

    private void OnEnable()
    {
        foreach (var planet in planets)
        {
            bool isActive = planet.name == PlanetData.selectedPlanetName;
            planet.SetActive(isActive);

            if (isActive)
            {
                PlanetNametext.text = $"Planet {PlanetData.selectedPlanetName}";
                PlanetInfotext.text = planetTexts.TryGetValue(PlanetData.selectedPlanetName, out string text) ? text : "No information available for this planet.";
                break;
            }
        }
    }

    private void InitializePlanetTexts()
    {
        planetTexts.Add("Earth", earthText);
        planetTexts.Add("Mars", marsText);
        planetTexts.Add("Saturn", saturnText);
        planetTexts.Add("Venus", venusText);
        planetTexts.Add("Jupiter", jupiterText);
        planetTexts.Add("Mercury", mercuryText);
        planetTexts.Add("Neptune", neptuneText);
        planetTexts.Add("Uranus", uranusText);
    }


    public void Onclick_BackButton()
    {
        SceneManager.LoadScene("HomeScreen");
    }
}
