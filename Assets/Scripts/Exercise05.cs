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

    // Chinese horoscope animals images
    public Sprite[] horoscopeImage;

    private int horoscopeIndex;

    private void Start()
    {
        // Hide default test image and text
        horoscopeText.gameObject.SetActive(false);
        horoscopeSprite.gameObject.SetActive(false);
    }

    // Chinese horoscope animals text
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

    // Check your Chinese horoscope
    public void CheckHoroscope()
    {
        // Check that the input is not empty but it's quite basic. It's better to use regex.
        if (birthdate.text != null || birthdate.text != "")
        {
            // Displays the image and text of the animal
            horoscopeText.gameObject.SetActive(true);
            horoscopeSprite.gameObject.SetActive(true);

            // Calculate your horoscope index according to your birth date
            horoscopeIndex = int.Parse(birthdate.text) % 12;

            // Gets the text according to the result
            horoscopeText.text = animals[horoscopeIndex];

            // Gets the image according to the result
            horoscopeSprite.sprite = horoscopeImage[horoscopeIndex];
        }
    }
}