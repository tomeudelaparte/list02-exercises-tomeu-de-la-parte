using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise02 : MonoBehaviour
{
    [SerializeField] private float timerSeconds = 10f;

    private float fillAmount = 1f;

    void Start()
    {
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        for (int i = 0; i <= timerSeconds - 1; i++)
        {
            yield return new WaitForSeconds(1f);

            GetComponent<Image>().fillAmount = GetComponent<Image>().fillAmount - (fillAmount / timerSeconds);
        }
    }
}
