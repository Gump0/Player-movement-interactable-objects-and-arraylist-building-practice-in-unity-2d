using System.Collections.Generic;
using UnityEngine;

public class UseObject : MonoBehaviour
{
    private List<GameObject> useableItems = new List<GameObject>(); // allows us to create an arraylist of objects that are assinged to "usableItems"
    public List<string> useableTags;

    public string useButtonName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!useableTags.Contains(collision.tag)) return;

        if (!useableItems.Contains(collision.gameObject))
        {
            useableItems.Add(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (useableItems.Contains(collision.gameObject))
        {
            useableItems.Remove(collision.gameObject);
        }
    }

    void Update()
    {
        if (Input.GetButtonDown(useButtonName))
        {
            foreach(GameObject item in useableItems)
            {
                item.SendMessage("OnUse");
            }
        }
    }
}
