using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{
    public GameObject[] rows;

    // Number of columns and rows
    private int columnsCount, rowsCount;

    // Player position
    private int columnX = 2, rowY = 2;

    void Start()
    {
        // Gets the number of rows
        rowsCount = rows.Length;

        // Gets the number of columns
        columnsCount = rows[0].transform.childCount;

        // Moves player to a default position
        MovePlayer();
    }

    void Update()
    {
        // If you press the up arrow
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // If y is greater than 0
            if (rowY > 0)
            {
                // Moves the player one row down
                rowY--;

                MovePlayer();
            }
        }

        // If you press the down arrow
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // If y is less than the number of rows minus 1
            if (rowY < rowsCount - 1)
            {
                // Moves the player one row up
                rowY++;

                MovePlayer();
            }
        }

        // If you press the left arrow
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // If x is greater than 0
            if (columnX > 0)
            {
                // Moves the player one column left
                columnX--;

                MovePlayer();
            }
        }

        // If you press the right arrow
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // If x is less than the number of columns minus 1
            if (columnX < columnsCount - 1)
            {
                // Moves the player one column right
                columnX++;

                MovePlayer();
            }
        }
    }

    // Moves the player to a position in x and y
    private void MovePlayer()
    {
        transform.position = rows[rowY].transform.GetChild(columnX).transform.position;
    }
}