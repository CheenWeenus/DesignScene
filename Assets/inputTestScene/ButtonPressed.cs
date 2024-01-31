using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPressed : MonoBehaviour
{
    public void OnPressed()
    {
        Image image = GetComponent<Image>();

        Debug.Log("Pressed");
    }
}
