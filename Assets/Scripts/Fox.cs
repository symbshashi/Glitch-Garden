using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        // Trigger the jump animation for the Fox regardless of the object it collides with
        GetComponent<Animator>().SetTrigger("jumpTrigger");
    }
}
