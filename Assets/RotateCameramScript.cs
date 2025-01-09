using UnityEngine;

public class RotateCameramScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(-0.3f, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0.3f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -0.3f, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0.3f, 0);
        }
    }
}
