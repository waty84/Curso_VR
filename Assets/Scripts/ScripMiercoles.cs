using UnityEngine;

public class ScripMiercoles : MonoBehaviour
{
    private float edad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (edad > 18f)
            Debug.Log("hola");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
