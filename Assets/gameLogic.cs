using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameLogic : MonoBehaviour {

    public SpriteRenderer t00;
    public SpriteRenderer t01;
    public SpriteRenderer t02;
    public SpriteRenderer t10;
    public SpriteRenderer t11;
    public SpriteRenderer t12;
    public SpriteRenderer t20;
    public SpriteRenderer t21;
    public SpriteRenderer t22;


    static int rows = 3;
    static int columns = 3;

    static bool flag = false;
    static int btn = 0;

    static SpriteRenderer[,] actGrid = new SpriteRenderer[rows, columns];

    // Use this for initialization
    void Start () {

        actGrid[0, 0] = t00;
        actGrid[0, 1] = t01;
        actGrid[0, 2] = t02;
        actGrid[1, 0] = t10;
        actGrid[1, 1] = t11;
        actGrid[1, 2] = t12;
        actGrid[2, 0] = t20;
        actGrid[2, 1] = t21;
        actGrid[2, 2] = t22;

        reset();
    }

	
	// Update is called once per frame
	void Update () {
        clearMatches();
        replaceTiles();

        if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            if (flag)
            {
                if(btn == 4)
                {
                    swap(actGrid[2, 0], actGrid[1, 0]);
                    flag = false;
                }
                else if(btn == 2)
                {
                    swap(actGrid[2, 0], actGrid[2, 1]);
                    flag = false;
                }
                else
                {
                    flag = false;
                    btn = 0;
                }
            }
            else
            {
                flag = true;
                btn = 1;
            }
        }

        if (Input.GetKeyUp(KeyCode.Keypad2))
        {
            if (flag)
            {
                if (btn == 1)
                {
                    swap(actGrid[2, 1], actGrid[2, 0]);
                    flag = false;
                }
                else if (btn == 5)
                {
                    swap(actGrid[2, 1], actGrid[1, 1]);
                    flag = false;
                }
                else if (btn == 3)
                {
                    swap(actGrid[2, 1], actGrid[2, 2]);
                    flag = false;
                }
                else
                {
                    flag = false;
                    btn = 0;
                }
            }
            else
            {
                flag = true;
                btn = 2;
            }
        }

        if (Input.GetKeyUp(KeyCode.Keypad3))
        {
            if (flag)
            {
                if (btn == 2)
                {
                    swap(actGrid[2, 2], actGrid[2, 1]);
                    flag = false;
                }
                else if (btn == 6)
                {
                    swap(actGrid[2, 2], actGrid[1, 2]);
                    flag = false;
                }
                else
                {
                    flag = false;
                    btn = 0;
                }
            }
            else
            {
                flag = true;
                btn = 3;
            }
        }

        if (Input.GetKeyUp(KeyCode.Keypad4))
        {
            if (flag)
            {
                if (btn == 1)
                {
                    swap(actGrid[1,0], actGrid[2, 0]);
                    flag = false;
                }
                else if (btn == 5)
                {
                    swap(actGrid[1,0], actGrid[1, 1]);
                    flag = false;
                }
                else if (btn == 7)
                {
                    swap(actGrid[1,0], actGrid[0,0]);
                    flag = false;
                }
                else
                {
                    flag = false;
                    btn = 0;
                }
            }
            else
            {
                flag = true;
                btn = 4;
            }
        }

        if (Input.GetKeyUp(KeyCode.Keypad5))
        {
            if(flag)
            {
                if (btn == 4)
                {
                    swap(actGrid[1, 1], actGrid[1, 0]);
                    flag = false;
                }
                else if (btn == 2)
                {
                    swap(actGrid[1, 1], actGrid[2, 1]);
                    flag = false;
                }
                else if (btn == 6)
                {
                    swap(actGrid[1, 1], actGrid[1, 2]);
                    flag = false;
                }
                else if (btn == 8)
                {
                    swap(actGrid[1, 1], actGrid[0, 1]);
                    flag = false;
                }
                else
                {
                    flag = false;
                    btn = 0;
                }
            }
            else
            {
                flag = true;
                btn = 5;
            }
        }

        if (Input.GetKeyUp(KeyCode.Keypad6))
        {
            if (flag)
            {
                if (btn == 3)
                {
                    swap(actGrid[1,2], actGrid[2, 2]);
                    flag = false;
                }
                else if (btn == 5)
                {
                    swap(actGrid[1,2], actGrid[1, 1]);
                    flag = false;
                }
                else if (btn == 9)
                {
                    swap(actGrid[1,2], actGrid[0,2]);
                    flag = false;
                }
                else
                {
                    flag = false;
                    btn = 0;
                }
            }
            else
            {
                flag = true;
                btn = 6;
            }
        }

        if (Input.GetKeyUp(KeyCode.Keypad7))
        {
            if (flag)
            {
                if (btn == 4)
                {
                    swap(actGrid[0,0], actGrid[1, 0]);
                    flag = false;
                }
                else if (btn == 8)
                {
                    swap(actGrid[0,0], actGrid[0,1]);
                    flag = false;
                }
                else
                {
                    flag = false;
                    btn = 0;
                }
            }
            else
            {
                flag = true;
                btn = 7;
            }
        }

        if (Input.GetKeyUp(KeyCode.Keypad8))
        {
            if (flag)
            {
                if (btn == 7)
                {
                    swap(actGrid[0,1], actGrid[0, 0]);
                    flag = false;
                }
                else if (btn == 5)
                {
                    swap(actGrid[0,1], actGrid[1, 1]);
                    flag = false;
                }
                else if (btn == 9)
                {
                    swap(actGrid[0,1], actGrid[0, 2]);
                    flag = false;
                }
                else
                {
                    flag = false;
                    btn = 0;
                }
            }
            else
            {
                flag = true;
                btn = 8;
            }
        }

        if (Input.GetKeyUp(KeyCode.Keypad9))
        {
            if (flag)
            {
                if (btn == 6)
                {
                    swap(actGrid[0,2], actGrid[1,2]);
                    flag = false;
                }
                else if (btn == 8)
                {
                    swap(actGrid[0,2], actGrid[0, 1]);
                    flag = false;
                }
                else
                {
                    flag = false;
                    btn = 0;
                }
            }
            else
            {
                flag = true;
                btn = 9;
            }
        }

        if (Input.GetKeyUp(KeyCode.Keypad0))
        {
            reset();
        }
    }

    public static void clearMatches()
    {

        bool[,] clr = new bool[rows, columns];
        for(int i = 0; i < rows; i++)
        {
            if(actGrid[i, 0].color == actGrid[i, 1].color && actGrid[i, 0].color == actGrid[i,2].color)
            {
                clr[i, 0] = true;
                clr[i, 1] = true;
                clr[i, 2] = true;
            }
        }

        for (int i = 0; i < columns; i++)
        {
            if (actGrid[0, i].color == actGrid[1, i].color && actGrid[0, i].color == actGrid[2, i].color)
            {
                clr[0, i] = true;
                clr[1, i] = true;
                clr[2, i] = true;
            }
        }

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
                if (clr[i, j])
                    actGrid[i, j].color = Color.black;
    }

    public static void replaceTiles()
    {
        for (int i = rows - 1; i >= 0; i--)
            for (int j = columns - 1; j >= 0; j--)
                if (actGrid[i, j].color == Color.black)
                    replaceTile(i, j);
    }

    public static void replaceTile(int row, int column)
    {
        if (row == 0)
        {
            randColor(actGrid[row, column]);
            return;
        }

        if (actGrid[row-1, column].color == Color.black)
        {
            replaceTile(row - 1, column);
            swap(actGrid[row, column], actGrid[row - 1, column]);
            replaceTile(row - 1, column);
        }
        else if (actGrid[row - 1, column].color != Color.black)
        {
            swap(actGrid[row, column], actGrid[row - 1, column]);
            replaceTile(row - 1, column);
        }
    }

    public static void swap(SpriteRenderer a, SpriteRenderer b)
    {
        Color tmp = a.color;
        a.color = b.color;
        b.color = tmp;
    }

    public static void reset()
    {
        flag = false;
        btn = 0;

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
            {
                randColor(actGrid[i, j]);
            }
    }

    public static void randColor(SpriteRenderer tile)
    {
        int rnd = Random.Range(0, 5);
        switch (rnd)
        {
            case (0): tile.color = Color.red; break;
            case (1): tile.color = Color.blue; break;
            case (2): tile.color = Color.green; break;
            case (3): tile.color = Color.yellow; break;
            case (4): tile.color = Color.magenta; break;
            default: break;
        }
    }
}
