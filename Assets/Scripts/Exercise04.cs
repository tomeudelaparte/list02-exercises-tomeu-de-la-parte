using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise04 : MonoBehaviour
{
    public TextMeshProUGUI buttonOption01, buttonOption02, turnsText;
    public TextMeshProUGUI successesText, mistakesText;
    public GameObject gamePanel, gameOverPanel;

    private List<List<List<string>>> globalOptions = new List<List<List<string>>>();

    private List<int> optionsClicked = new List<int>();

    private int successes = 0, mistakes = 0;

    private int randomIndex = 0;

    private void Start()
    {
        // Displays the game panel and hides the final panel
        gamePanel.SetActive(true);
        gameOverPanel.SetActive(false);

        // Adds the options and displays them on the screen
        AddOptions();
        ShowGroupOptions();

        // Gets the number of turns according to number of "questions"
        turnsText.text = "Turns: " + (globalOptions.Count - optionsClicked.Count).ToString();
    }

    // Adds the options
    private void AddOptions()
    {
        AddGroupToGlobal("Hippopotamus", "true", "Giraffe", "false");
        AddGroupToGlobal("Cat", "true", "Dog", "false");
        AddGroupToGlobal("Shin-chan", "true", "Doraemon", "false");
        AddGroupToGlobal("Windows", "true", "Macintosh", "false");
        AddGroupToGlobal("Videogames", "true", "Series", "false");
        AddGroupToGlobal("Walther White", "true", "Walther Blanco", "false");
        AddGroupToGlobal("Heat", "true", "Cold", "false");
        AddGroupToGlobal("YouTube", "true", "Twitch", "false");
        AddGroupToGlobal("Shrek", "true", "Kung Fu Panda", "false");
        AddGroupToGlobal("Car", "true", "Motorbike", "false");
    }

    // Adds the group options to the global list
    private void AddGroupToGlobal(string option01, string option01Bool, string option02, string option02Bool)
    {
        // Creates a list containing lists of strings
        List<List<string>> optionsGroup = new List<List<string>>();

        // Add two options to the options group as lists of strings
        optionsGroup.Add(new List<string> { option01, option01Bool });
        optionsGroup.Add(new List<string> { option02, option02Bool });

        // Adds the option group to the global list
        globalOptions.Add(optionsGroup);
    }


    private void ShowGroupOptions()
    {
        // If the number of "questions" answered is less than the number of "questions" asked
        if (optionsClicked.Count < globalOptions.Count)
        {
            // Gets a random index among the number of groups of options
            randomIndex = Random.Range(0, globalOptions.Count);

            // If the answered "questions" do not contain the new question
            if (!optionsClicked.Contains(randomIndex))
            {
                // Gets a random position for displaying the options between the two buttons
                int randomPosition = Random.Range(0, 2);

                if (randomPosition == 0)
                {
                    buttonOption01.text = globalOptions[randomIndex][0][0];
                    buttonOption02.text = globalOptions[randomIndex][1][0];
                }
                else
                {
                    buttonOption01.text = globalOptions[randomIndex][1][0];
                    buttonOption02.text = globalOptions[randomIndex][0][0];
                }
            }
            else
            {
                // Displays the following group of options
                ShowGroupOptions();
            }
        }
    }

    // Check the selected option
    public void CheckSelectedOption(TextMeshProUGUI buttonText)
    {
        // If the number of "questions" answered is less than the number of "questions" asked
        if (optionsClicked.Count < globalOptions.Count)
        {
            // If the text of the button is equal to Option 01
            if (buttonText.text == globalOptions[randomIndex][0][0])
            {
                // If the selected Option 01 is True
                if (globalOptions[randomIndex][0][1] == "true")
                {
                    // Adds +1 to the number of successes
                    successes++;
                }
                else
                {
                    // Adds +1 to the number of mistakes
                    mistakes++;
                }
            }

            // If the text of the button is equal to Option 02
            if (buttonText.text == globalOptions[randomIndex][1][0])
            {
                // If the selected Option 02 is True
                if (globalOptions[randomIndex][1][1] == "true")
                {
                    // Adds +1 to the number of successes
                    successes++;
                }
                else
                {
                    // Adds +1 to the number of mistakes
                    mistakes++;
                }
            }

            // Adds the "question" to the list of answered questions
            optionsClicked.Add(randomIndex);

            // Update the number of turns by subtracting the total number of "questions" by the number of "questions" answered
            turnsText.text = "Turns: " + (globalOptions.Count - optionsClicked.Count).ToString();

            // Displays the following group of options
            ShowGroupOptions();
        }

        // If the number of answered "questions" is equal to the total number of "questions"
        if (optionsClicked.Count == globalOptions.Count)
        {
            // Hides the game panel and displays the final panel
            gamePanel.SetActive(false);
            gameOverPanel.SetActive(true);

            // Update text number of successes and mistakes
            successesText.text = "Successes: " + successes.ToString();
            mistakesText.text = "Mistakes: " + mistakes.ToString();
        }
    }
}
