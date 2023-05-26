using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager Instance;

    private void Awake()
    {
        if (Instance) // is there already an Instance assigned?
        {
            Destroy(this);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(this);
    }


    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
