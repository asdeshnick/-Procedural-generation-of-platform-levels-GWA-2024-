using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Tilemaps;
using System.Collections.Generic;


public class gener : MonoBehaviour
{
    private System.Random _random;
    public Tilemap tilemap;
    public TileBase[] tiles;

    public int jump_sp = 5;
    public int platformCount = 800;
    public int x_2 = 1;
    public int y_2 =  -1;
    public int x2 = 3;
    public int y2 = 2;
    public int x3 = 0;
    public int y3 = 0;
    public int x4 = 0;
    public int y4 = 0;
    int[] numbers = { };
    // int maxNumber = numbers[0];

    List<int> list = new List<int> {2, 4, 6, 8};

    private void Start()
    {
        _random = new System.Random(546.GetHashCode());
        GenerateObjects();
    }

    private void GenerateObjects()
    {
        x3 = x2;
        y3 = y2;
        for (int j = 0; j < platformCount; j++)
        {
            for (int i = 0; i < jump_sp; i++)
            {
                int next = _random.Next(-1,2);

                if (next == 1)
                {
                    y2 = y2 + 1;
                }
                if (next == 0)
                {
                    x2 = x2 + 1;
                }
                if (next == -1)
                {
                    y2 = y2 - 1;
                }
                x2 = x2 + 1;

                if (list.Contains(j))
                {
                    y2 = y2 + 1;
                }
                SetTile(x2, y2);
            }

            if (list.Contains(j))
            {
                int next2 = _random.Next(1,3);

                for (int iter = 0; iter != 2; iter++)
                {
                    if (next2 == 1)
                    {
                    y3 = y3 + 1;
                    }
                    if (next2 == 2)
                    {
                    x3 = x3 + 1;
                    }

                    if (x2 == x3);
                    {
                        x3 = x3 + 1;
                    }
                    // x3 = x3 - 2;
                    // y3 = y3 + 1;
                     SetTile(x3, y3);
                }
            
                SetTile(x2, y2);
            }
                    
                

            for (int iter_2 = 0; iter_2 != 3; iter_2++)
            {
                int next4 = _random.Next(1,3);
                if (next4 == 1)
                {
                y4 = y4 - 1;
                }
                if (next4 == 2)
                {
                x4 = x4 - 1;
                }
                // y4 = y4 - 1;
                x4 = x4 + 3;
                SetTile(x4, y4);

            }
        

            SetTile(x2, y2);


            Debug.Log(x2 + " " + y2);
            Debug.Log(x_2 + " " + y_2);
        
        }
    }

    // private void max_num(y2)
    // {
    //     for (int i = 1; i < numbers.Length; i++)
    //     {
    //         if (numbers[i] > maxNumber)
    //         {
    //             maxNumber = numbers[i];
    //         }

    //     }
    //     Debug.Log(maxNumber);
    // }


    private void SetTile(int x, int y)
    {
        TileBase tile = tiles[_random.Next(0, tiles.Length)];
        tilemap.SetTile(new Vector3Int(x, y, 0), tiles[0]);
    }
}


