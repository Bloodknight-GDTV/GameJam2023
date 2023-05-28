using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class LoadStuff : MonoBehaviour
{
    // Make Current Scene a Singleton
    private static LoadStuff Instance;
    

    
    // For saving and loading objects
    public GameObject prefab;
    List<GameObject> goList;

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
        
        
        // setup for object lists
        goList = new List<GameObject>();
    }

    
    
    
    

    // Load up a temporary UI for testing
    void OnGUI()
    {
        // if (GUI.Button(new Rect(20, 10, 150, 40), "Switch Dimensions"))
        // {
        //     switchDimensions();
        // }
        //
        // if (GUI.Button(new Rect(180, 10, 150, 40), "Reset to Base Scene"))
        // {
        //     SceneManager.LoadSceneAsync("PrototypeLevel", LoadSceneMode.Single);
        // }
    }
    
    
  
/*

    if(Input.GetKeyDown(KeyCode.I)) {
        // Create a new GameObject from prefab and move to position
        Vector3 position = new Vector3(0, 0, 0);
        goList.Add((gameObject));
        Instantiate(prefab, position, Quaternion.identity);
    }
    
    
    // List gameObjects in collection
    if(Input.GetKeyDown(KeyCode.L)){
        Debug.Log(goList.Count);
        foreach(GameObject go in goList){
            Debug.Log(go.name);
        }
    }

*/
    
    
}
