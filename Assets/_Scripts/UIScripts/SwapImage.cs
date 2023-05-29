using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapImage : MonoBehaviour
{
    public Image startImage;
    public Sprite replacementImage;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{gameObject.name} : OnTriggerEnter()");
        Swap();
        Destroy(gameObject);
    }

    public void Swap()
    {
        startImage.sprite = replacementImage;
    }
}
