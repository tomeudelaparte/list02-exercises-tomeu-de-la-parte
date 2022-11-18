using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{
    public GameObject[] rows;

    private int columnsCount, rowsCount;

    private int x = 2, y = 2;

    void Start()
    {
        rowsCount = rows.Length;
        columnsCount = rows[0].transform.childCount;

        MovePlayer();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (y > 0)
            {
                y--;

                MovePlayer();
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (y < rowsCount-1)
            {
                y++;

                MovePlayer();
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            if (x > 0)
            {
                x--;

                MovePlayer();
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (x < columnsCount-1)
            {
                x++;

                MovePlayer();
            }
        }
    }

    private void MovePlayer()
    {
        transform.position = rows[y].transform.GetChild(x).transform.position;
    }
}
