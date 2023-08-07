using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string text1;
    public float float1;
    public GameObject gameObject1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 10; i++)
        {
            Debug.Log("Test");
        }

        for(int i = 0;i < 10;i++)
        {
            Debug.Log("Test2");
        }
    }
}
