using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Увеличивает силу прыжка до 10
        other.GetComponent<Jump>().jumpStrength = 10;
    }
    private void OnTriggerExit(Collider other)
    {
        // Уменьшает силу прыжка до 2
        other.GetComponent<Jump>().jumpStrength = 2;
    }
}
