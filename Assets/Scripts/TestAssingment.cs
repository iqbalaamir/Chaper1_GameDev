using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAssingment : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("Awake is called");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update is called");
        if(Input.GetKeyDown(KeyCode.A)|| Input.GetMouseButtonDown(0))
        {
            Debug.Log(" pressed");
        }
        if (Input.GetKey(KeyCode.A)|| Input.GetMouseButton(0))
        {
            Debug.Log("Hola! A");
        }
        if (Input.GetKeyUp(KeyCode.A)  || Input.GetMouseButtonUp(0))
        {
            Debug.Log("released");
        }
    }
    
}
