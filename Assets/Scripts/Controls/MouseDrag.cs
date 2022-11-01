using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{

    private void OnMouseDrag()
    {
        Debug.Log("Dragged " + this.gameObject.name);
    }
}
