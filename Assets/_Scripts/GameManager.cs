using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    int manaPool = 0;

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
    
    // 
    public void AddMana(int mana)
    {
        manaPool += mana;
        Debug.Log($"{mana} Mana was added to players ManaPool; total {manaPool};");
    }
}
