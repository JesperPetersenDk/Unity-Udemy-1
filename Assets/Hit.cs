using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        print("DEAD");
        Destroy(gameObject);
    }
}
