using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise04 : MonoBehaviour
{
    public TextMeshProUGUI buttonOption01, buttonOption02, turnsText;
    public TextMeshProUGUI successesText, mistakesText;
    public GameObject gamePanel, gameOverPanel;

    private int successes = 0, mistakes = 0;

    private List<int> optionsClicked = new List<int>();

    private int randomIndex = 0;

    private List<List<List<string>>> options = new List<List<List<string>>>();
    private void Start()
    {
        gamePanel.SetActive(true);
        gameOverPanel.SetActive(false);

        AddAnswers();
        ShowAnswers();

        turnsText.text = "Turns: " + (options.Count - optionsClicked.Count).ToString();
    }

    private void AddAnswers()
    {
        List<List<string>> option = new List<List<string>>();

        option.Add(new List<string> { "Hippopotamus", "true" });
        option.Add(new List<string> { "Giraffe", "false" });

        options.Add(option);

        option = new List<List<string>>();

        option.Add(new List<string> { "Cat", "true" });
        option.Add(new List<string> { "Dog", "false" });

        options.Add(option);

        option = new List<List<string>>();

        option.Add(new List<string> { "Shin-chan", "true" });
        option.Add(new List<string> { "Doraemon", "false" });

        options.Add(option);

        option = new List<List<string>>();

        option.Add(new List<string> { "Windows", "true" });
        option.Add(new List<string> { "Macintosh", "false" });

        options.Add(option);

        option = new List<List<string>>();

        option.Add(new List<string> { "Videogames", "true" });
        option.Add(new List<string> { "Series", "false" });

        options.Add(option);

        option = new List<List<string>>();

        option.Add(new List<string> { "Walther White", "true" });
        option.Add(new List<string> { "Walther Blanco", "false" });

        options.Add(option);

        option = new List<List<string>>();

        option.Add(new List<string> { "Heat", "true" });
        option.Add(new List<string> { "Cold", "false" });

        options.Add(option);

        option = new List<List<string>>();

        option.Add(new List<string> { "YouTube", "true" });
        option.Add(new List<string> { "Twitch", "false" });

        options.Add(option);

        option = new List<List<string>>();

        option.Add(new List<string> { "Shrek", "true" });
        option.Add(new List<string> { "Kung Fu Panda", "false" });

        options.Add(option);

        option = new List<List<string>>();

        option.Add(new List<string> { "Car", "true" });
        option.Add(new List<string> { "Motorbike", "false" });

        options.Add(option);
    }


    private void ShowAnswers()
    {
        if (optionsClicked.Count < options.Count)
        {
            randomIndex = Random.Range(0, 10);

            if (!optionsClicked.Contains(randomIndex))
            {

                int randomPosition = Random.Range(0, 2);

                if (randomPosition == 0)
                {
                    buttonOption01.text = options[randomIndex][0][0];
                    buttonOption02.text = options[randomIndex][1][0];
                }
                else
                {
                    buttonOption01.text = options[randomIndex][1][0];
                    buttonOption02.text = options[randomIndex][0][0];
                }
            }
            else
            {
                ShowAnswers();
            }
        }
    }

    public void CheckAnswer(TextMeshProUGUI buttonText)
    {
        if (optionsClicked.Count < options.Count)
        {
            if (buttonText.text == options[randomIndex][0][0])
            {
                if (options[randomIndex][0][1] == "true")
                {
                    successes++;
                }
                else
                {
                    mistakes++;
                }
            }

            if (buttonText.text == options[randomIndex][1][0])
            {
                if (options[randomIndex][1][1] == "true")
                {
                    successes++;
                }
                else
                {
                    mistakes++;
                }
            }

            optionsClicked.Add(randomIndex);
            turnsText.text = "Turns: " + (options.Count - optionsClicked.Count).ToString();

            ShowAnswers();
        }

        if (optionsClicked.Count == options.Count)
        {
            gamePanel.SetActive(false);
            gameOverPanel.SetActive(true);

            successesText.text = "Successes: " + successes.ToString();
            mistakesText.text = "Mistakes: " + mistakes.ToString();
        }
    }
}
