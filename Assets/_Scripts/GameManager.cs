using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public ManaBar manaBar;
    
    [SerializeField] TMP_Text gameMessagesText;
    [SerializeField] TMP_Text manaPoolText;
    
    [SerializeField] float cooldownTime = 10.0f;
    [SerializeField] float cooldownRemaining = 0f;
    
    // Dimension switching Variables
    private bool isActiveDimension1;
    private bool isActiveDimension2;
    
    int spellCost = 20;
    
    
        
    
    
    int manaPool = 0;
    public int minManaPool = 0;
    public int maxManaPool = 100;
    
    public static int FakeManaPool = 50;

    private void Awake()
    {
        if (Instance) // is there already an Instance assigned?
        {
            Destroy(this);
            return;
        }
        
        //manaBar.SetMinMana(minManaPool);

        Instance = this;
        DontDestroyOnLoad(this);
        Debug.Log("GameManager Instance; Awake()");
    }

    // **************************************
    //                  Start
    // **************************************
    private void Start()
    {
        // Initial dimension setup
        isActiveDimension1 = true;
        isActiveDimension1 = false;
        
        // initial loading of dimensions, this should just load dimension 1
        // unless of course you derped out and forgot to set the dimensions correctly
        //switchDimensions();
        
        // load all starting scenes
        SceneManager.LoadSceneAsync("Dimension01", LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync("PlayGUIScene", LoadSceneMode.Additive);
        
        manaBar.SetMana(manaPool);
        manaPoolText.text = manaPool.ToString();
        
        //StartCoroutine(FadeTextToInvisible(2.5f, gameMessagesText));
        
        Debug.Log("GameManager Instance; Start()");
    }

    // **************************************
    //                  Update
    // **************************************
    private void Update()
    {
        manaBar.SetMana(manaPool);
        manaPoolText.text = manaPool.ToString();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (manaPool >= spellCost)
            {
                switchDimensions();
            }
            else
            {
                gameMessagesText.text = "Not enough Mana to switch dimensions";
            }
            
        }
        
        RemoveLastMessage();
        
        

    }
    
    
    //**********************************************************************************
    // Custom functions
    //**********************************************************************************

    void RemoveLastMessage()
    {
        cooldownRemaining -= Time.deltaTime;
        if (cooldownRemaining <=0)
        {
            gameMessagesText.text = "";
            cooldownRemaining = cooldownTime;
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
        
        manaPool -= spellCost;
    }
    
    // 
    public void AddMana(int mana)
    {
        manaPool += mana;
        Debug.Log($"{mana} Mana was added to players ManaPool; total {manaPool};");
    }
}
