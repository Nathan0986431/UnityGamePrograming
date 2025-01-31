using UnityEngine;

public class Drbug : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("this runs once");
    }

    // Update is called once per frame
    void Update()
    {
        counter = ++;
        Debug.Log(counter)
    }
}
