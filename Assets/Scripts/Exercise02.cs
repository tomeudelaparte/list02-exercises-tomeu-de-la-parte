using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise02 : MonoBehaviour
{
    // Seconds
    [SerializeField] private float timerSeconds = 10f;

    // Total fill amount
    private float totalFillAmount = 1f;

    void Start()
    {
        // Starts the timer
        StartCoroutine(Timer());
    }

    // Timer function
    private IEnumerator Timer()
    {
        // For each second
        for (int i = 0; i <= timerSeconds - 1; i++)
        {
            // Waits a second
            yield return new WaitForSeconds(1f);

            // Updates the fill amount by subtracting the total amount divided by the seconds.
            GetComponent<Image>().fillAmount = GetComponent<Image>().fillAmount - (totalFillAmount / timerSeconds);
        }
    }
}