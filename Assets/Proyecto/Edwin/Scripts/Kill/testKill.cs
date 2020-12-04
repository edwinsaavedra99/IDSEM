using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testKill : MonoBehaviour
{
    // Start is called before the first frame update

    private BDItemns bD;
    private List<Item> items;
    void Start()
    {

        bD = BDItemns.Instance;
        items = bD.getData();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
