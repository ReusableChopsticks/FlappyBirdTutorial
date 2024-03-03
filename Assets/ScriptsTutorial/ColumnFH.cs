using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnFH : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<BirdFH>() != null)
        {
            GameControlFH.instance.BirdScored();
        }
    }
}
