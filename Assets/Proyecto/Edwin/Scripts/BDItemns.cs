using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BDItemns : MonoBehaviour
{
    public List<Item> itemnscategoria1;
    public List<Item> itemnscategoria2;
    public List<Item> itemnscategoria3;
    public List<Item> itemnscategoria4;
    public static List<Item> items;
    //probabilidades
    /**
     * Nivel 1 
     * categoria 1 - 65 %
     * categoria 2 - 20 %
     * categoria 3 - 10 %
     * categoria 4 - 5  % 
     * Nivel 2
     * categoria 1 - 25 %
     * categoria 2 - 50 %
     * categoria 3 - 15 %
     * categoria 4 - 10 % 
     * Nivel 3
     * categoria 1 - 10 %
     * categoria 2 - 15 %
     * categoria 3 - 45 %
     * categoria 4 - 30 % 
     * Nivel 4
     * categoria 1 - 5  %
     * categoria 2 - 10 %
     * categoria 3 - 30 %
     * categoria 4 - 55 % 
     * */

    public static BDItemns Instance { get; private set; }
    private void Awake()
    {
        /*if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }*/
        Instance = this;
    }

    void Start()
    {
        items = new List<Item>();
        items = itemnscategoria1.Concat(itemnscategoria2).ToList().Concat(itemnscategoria3).ToList().Concat(itemnscategoria4).ToList();
        
    }


    public List<Item> getItemsnAll()
    {
        return items;
    }

    public List<Item> getData(int nivel)
    {
        List<Item> aux = new List<Item>();
        for(int i = 0; i < 3; i++)
        {
            if (nivel == 1)
            {
                //categoria 1 - 65 %
                //categoria 2 - 20 %
                //categoria 3 - 10 %
                //categoria 4 - 5 %
                int random = Random.Range(0, 101);
                if (random <= 5)
                {
                    aux.Add(itemnscategoria4[Random.Range(0, itemnscategoria4.Count)]);
                }
                else if (random > 5 && random <= 15)
                {
                    aux.Add(itemnscategoria3[Random.Range(0, itemnscategoria3.Count)]);
                }
                else if (random > 15 && random <= 35)
                {
                    aux.Add(itemnscategoria2[Random.Range(0, itemnscategoria2.Count)]);
                }
                else if (random > 35 && random <= 100)
                {
                    aux.Add(itemnscategoria1[Random.Range(0, itemnscategoria1.Count)]);
                }
            }
            else if (nivel == 2)
            {
                //categoria 1 - 25 %
                //categoria 2 - 50 %
                //categoria 3 - 15 %
                //categoria 4 - 10 %
                int random = Random.Range(0, 101);
                if (random <= 10)
                {
                    aux.Add(itemnscategoria4[Random.Range(0, itemnscategoria4.Count)]);
                }
                else if (random > 10 && random <= 25)
                {
                    aux.Add(itemnscategoria3[Random.Range(0, itemnscategoria3.Count)]);
                }
                else if (random > 25 && random <= 75)
                {
                    aux.Add(itemnscategoria2[Random.Range(0, itemnscategoria2.Count)]);
                }
                else if (random > 75 && random <= 100)
                {
                    aux.Add(itemnscategoria1[Random.Range(0, itemnscategoria1.Count)]);
                }
            }
            else if (nivel == 3)
            {
                //categoria 1 - 10 %
                //categoria 2 - 15 %
                //categoria 3 - 45 %
                //categoria 4 - 30 %
                int random = Random.Range(0, 101);
                if (random <= 30)
                {
                    aux.Add(itemnscategoria4[Random.Range(0, itemnscategoria4.Count)]);
                }
                else if (random > 30 && random <= 75)
                {
                    aux.Add(itemnscategoria3[Random.Range(0, itemnscategoria3.Count)]);
                }
                else if (random > 75 && random <= 90)
                {
                    aux.Add(itemnscategoria2[Random.Range(0, itemnscategoria2.Count)]);
                }
                else if (random > 90 && random <= 100)
                {
                    aux.Add(itemnscategoria1[Random.Range(0, itemnscategoria1.Count)]);
                }
            }
            else if (nivel == 4)
            {
                //categoria 1 - 5 %
                //categoria 2 - 10 %
                //categoria 3 - 30 %
                //categoria 4 - 55 %
                int random = Random.Range(0, 101);
                if (random <= 55)
                {
                    aux.Add(itemnscategoria4[Random.Range(0, itemnscategoria4.Count)]);
                }
                else if (random > 55 && random <= 85)
                {
                    aux.Add(itemnscategoria3[Random.Range(0, itemnscategoria3.Count)]);
                }
                else if (random > 85 && random <= 95)
                {
                    aux.Add(itemnscategoria2[Random.Range(0, itemnscategoria2.Count)]);
                }
                else if (random > 95 && random <= 100)
                {
                    aux.Add(itemnscategoria1[Random.Range(0, itemnscategoria1.Count)]);
                }
            }
        }
        return aux;        
    }
   
}
