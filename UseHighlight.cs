using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseHighlight : MonoBehaviour
{

    public GameObject highlight; // refers to child object called "highlight"
    public string useTag = "Use";

    void Awake()
    {
        highlight.SetActive(false); // turns highlight off so player cannot see it when he is not supposed too
    }

    private void OnTriggerEnter2D(Collider2D collision) // Triggers when player walks within using range
    {
        if (collision.CompareTag(useTag))
        {
            highlight.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision) // Triggers when player walks outside using range
    {
        if (collision.CompareTag(useTag))
        {
            highlight.SetActive(false);
        }
    }
}
