using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MouseHover : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;
    private void OnMouseOver()
    {
        nameText.text = "Name: " + this.gameObject.name;
    }

    private void OnMouseExit()
    {
        nameText.text = " ";
    }
}
