using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStuff : MonoBehaviour
{
    // Make Current Scene a Singleton
    private static LoadStuff Instance;
    
    
    private bool isActiveDimension1;
    private bool isActiveDimension2;
    
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
        // Initialise variables as needed
        isActiveDimension1 = true;
        isActiveDimension1 = false;
        
        // Unload all scenes
        SceneManager.UnloadSceneAsync("Dimension01");
        SceneManager.UnloadSceneAsync("Dimension02");
        
        // setup for object lists
        goList = new List<GameObject>();
    }
    
    // Load up a temporary UI for testing
    void OnGUI()
    {
        if (GUI.Button(new Rect(20, 10, 150, 40), "Switch Dimensions"))
        {
            switchDimensions();
        }
        
        if (GUI.Button(new Rect(180, 10, 150, 40), "Reset to Base Scene"))
        {
            SceneManager.LoadSceneAsync("PrototypeLevel", LoadSceneMode.Single);
        }
    }
    
    private void switchDimensions()
    {
        if (isActiveDimension1)
        {
            isActiveDimension1 = false;
            isActiveDimension2 = true;
            SceneManager.LoadSceneAsync("Dimension01", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("Dimension02");
        }
        else
        {
            isActiveDimension1 = true;
            isActiveDimension2 = false;
            SceneManager.LoadSceneAsync("Dimension02", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("Dimension01");
        }
    }
    
    
  
    /// /////////////////////////////////////////////////////////////////////////////////////////////////////////

    
 
 
 
    // Inside class --

 
    /*
    void Update() {
        if(Input.GetKeyDown(KeyCode.I) {
            // This random position is for fun :D
            Vector3 rndPos = new Vector3(Random.Range(-20, 20), Random.Range(-20, 20), Random.Range(-20, 20));
     
            // Create a new GameObject from prefab and move to random position
            goList.Add((GameObject)Instanciate(prefab, rndPos, Quaternion.Identity);
        }
 
        if(Input.GetKeyDown(KeyCode.L)){
            Debug.Log(goList.Count);
            foreach(GameObject go in goList){
                Debug.Log(go.name);
            }
        }
    }
    */
    
    
}
