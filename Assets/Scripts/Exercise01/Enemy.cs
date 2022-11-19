using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // When the mouse is over the GameObject
    private void OnMouseOver()
    {
        // If you press the left click
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Destroys this GameObject
            Destroy(gameObject);
        }
    }
}
