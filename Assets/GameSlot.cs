using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSlot : MonoBehaviour
{
    public Transform mark, mark2, mark3, mark4, mark5, mark6, mark7, mark8, mark9;
    public GameObject[] symbols;
    public Transform[] killChild;

    

    public PlayerScore pl;
    private void Awake()
    {
        pl = GetComponent<PlayerScore>();
    }
    public void RandomSlot()
    {
        
        for (int i = 0; i < killChild.Length; i++)
        {
            if(killChild[i].childCount > 0)
            DestroyImmediate(killChild[i].GetChild(0).gameObject);
        }
        int a = Random.Range(0, symbols.Length);
        int b = Random.Range(0, symbols.Length);
        int c = Random.Range(0, symbols.Length);
        int d = Random.Range(0, symbols.Length);
        int e = Random.Range(0, symbols.Length);
        int f = Random.Range(0, symbols.Length);
        int g = Random.Range(0, symbols.Length);
        int h = Random.Range(0, symbols.Length);
        int k = Random.Range(0, symbols.Length);



        //mark1
        Instantiate(symbols[a], mark.transform.position, Quaternion.identity ,GameObject.FindGameObjectWithTag("tag").transform);
        //mark2
        Instantiate(symbols[b], mark2.transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("tag2").transform);
        //mark3
        Instantiate(symbols[c], mark3.transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("tag3").transform);
        //mark4
        Instantiate(symbols[d], mark4.transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("tag4").transform);
        //mark5
        Instantiate(symbols[e], mark5.transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("tag5").transform);
        //mark6
        Instantiate(symbols[f], mark6.transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("tag6").transform);
        //mark7
        Instantiate(symbols[g], mark7.transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("tag7").transform);
        //mark8
        Instantiate(symbols[h], mark8.transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("tag8").transform);
        //mark9
        Instantiate(symbols[k], mark9.transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("tag9").transform);

        //Cherry
        //a
        if (a == 0 && b == 0 && c == 0)
        {
            pl.PlusScore(4);
        }
        if(a == 0 && b == 0)
        {
            pl.PlusScore(1);
        }
        if (a == 0)
        {
            pl.PlusScore(2);
        }

        //b
        
        if(b == 0 && c == 0)
        {
            pl.PlusScore(1);
        }
        if (b == 0)
        {
            pl.PlusScore(2);
        }
        //c
        if (c == 0)
        {
            pl.PlusScore(2);
        }

        //d
        if (d == 0 && e == 0 && f == 0)
        {
            pl.PlusScore(4);
        }
        if (d == 0 && e == 0)
        {
            pl.PlusScore(1);
        }
        if (d == 0)
        {
            pl.PlusScore(2);
        }


        //e
        if (e == 0 && f == 0)
        {
            pl.PlusScore(1);
        }
        if (e == 0)
        {
            pl.PlusScore(2);
        }
        
        //f
        if(f == 0)
        {
            pl.PlusScore(2);
        }

        //g
        if (g == 0 && h == 0 && k == 0)
        {
            pl.PlusScore(4);
        }
        if (g == 0 && h == 0)
        {
            pl.PlusScore(1);
        }
        if (g == 0)
        {
            pl.PlusScore(2);
        }


        //h
        if (h == 0 && k == 0)
        {
            pl.PlusScore(1);
        }
        if (h == 0)
        {
            pl.PlusScore(2);
        }
        
        //k
        if(k == 0)
        {
            pl.PlusScore(2);
        }
       
     
        //Choco
        if(a == 1 && b == 1 && c == 1)
        {
            pl.PlusScore(100);
        }
        if (d == 1 && e == 1 && f == 1)
        {
            pl.PlusScore(100);
        }
        if (g == 1 && h == 1 && k == 1)
        {
            pl.PlusScore(100);
        }

        //Globe
        if (a == 2 && b == 2 && c == 2)
        {
            pl.PlusScore(500);
        }
        if (d == 2 && e == 2 && f == 2)
        {
            pl.PlusScore(500);
        }
        if (g == 2 && h == 2 && k == 2)
        {
            pl.PlusScore(500);
        }

        //orange
        if (a == 3 && b == 3 && c == 3)
        {
            pl.PlusScore(15);
        }
        if (d == 3 && e == 3 && f == 3)
        {
            pl.PlusScore(15);
        }
        if (g == 3 && h == 3 && k == 3)
        {
            pl.PlusScore(15);
        }

        //pumps
        if (a == 4 && b == 4 && c == 4)
        {
            pl.PlusScore(50);
        }
        if (d == 4 && e == 4 && f == 4)
        {
            pl.PlusScore(50);
        }
        if (g == 4 && h == 4 && k == 4)
        {
            pl.PlusScore(50);
        }

        //bell 
        //orange
        if (a == 5 && b == 5 && c == 5)
        {
            pl.PlusScore(20);
        }
        if (d == 5 && e == 5 && f == 5)
        {
            pl.PlusScore(20);
        }
        if (g == 5 && h == 5 && k == 5)
        {
            pl.PlusScore(20);
        }
    }
}
