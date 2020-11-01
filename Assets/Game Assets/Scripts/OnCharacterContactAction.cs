using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCharacterContactAction : MonoBehaviour
{
    [SerializeField] public bool displayText;
    [SerializeField] public GameObject canvasToDisplay;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (displayText)
        {
            canvasToDisplay.SetActive(true);
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (displayText)
        {
            canvasToDisplay.SetActive(false);
        }
    }
}
