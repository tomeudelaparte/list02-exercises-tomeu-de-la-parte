using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise05 : MonoBehaviour
{
    public TMP_InputField birthdate;
    public TextMeshProUGUI horoscopeText;
    public Image horoscopeSprite;
    public Sprite[] horoscopeImage;

    private int horoscopeIndex;

    private void Start()
    {
        horoscopeText.gameObject.SetActive(false);
        horoscopeSprite.gameObject.SetActive(false);
    }

    private string[] animals = {
        "Monkey",
        "Rooster",
        "Dog",
        "Pig",
        "Rat",
        "Ox",
        "Tiger",
        "Rabbit",
        "Dragon",
        "Snake",
        "Horse",
        "Goat",
    };

    public void CheckHoroscope()
    {
        if (birthdate.text != null || birthdate.text != "")
        {
            horoscopeText.gameObject.SetActive(true);
            horoscopeSprite.gameObject.SetActive(true);

            horoscopeIndex = int.Parse(birthdate.text) % 12;

            horoscopeText.text = animals[horoscopeIndex];

            horoscopeSprite.sprite = horoscopeImage[horoscopeIndex];
        }
    }
}
