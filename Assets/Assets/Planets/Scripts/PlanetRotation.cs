using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public GameObject Planet;
    public Vector3 RotationVector;

    void Update()
    {
        Planet.transform.Rotate(RotationVector * Time.deltaTime);
    }
}
