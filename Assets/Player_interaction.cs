using System;
using UnityEngine;

public class Player_interaction : MonoBehaviour
{
    [SerializeField] GameObject textPrompt;
    [SerializeField] public float[] inventory;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Potion Crate Trigger"))
        {
            textPrompt.SetActive(true);
            Debug.Log(inventory);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Potion Crate Trigger"))
        {
            textPrompt.SetActive(false);
        }
    }

    void Start()
    {
        inventory[1] = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
