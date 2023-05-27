using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMagicOrb : MonoBehaviour
{
    FP_PlayerMovement player;
    [SerializeField] int manaValue = 1;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Trigger triggered by {other};");
        
        OrbCollected();
    }

    
    void OrbCollected()
    {
        GameManager.Instance.AddMana(manaValue);
        Destroy(gameObject);
    }
}
