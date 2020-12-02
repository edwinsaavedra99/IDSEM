using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScene : MonoBehaviour
{
    public static SplashScene Instance;

    // Start is called before the first frame update
    void Start()
    {
        Application.LoadLevel("Inicio");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }
}
