using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject Imagen1, Imagen2, Imagen3, Imagen4, im1, im2, im3, im4;
    public AudioSource source;
    public AudioClip correct;
    public AudioClip incorrect;
    public int count=0;

    Vector2 Imagen1InitialPos, Imagen2InitialPos, Imagen3InitialPos, Imagen4InitialPos;

    public void Start()
    {
        Imagen1InitialPos = Imagen1.transform.position;
        Imagen2InitialPos = Imagen2.transform.position;
        Imagen3InitialPos = Imagen3.transform.position;
        Imagen4InitialPos = Imagen4.transform.position;
    }

    public void dragImagen1()
    {
        Imagen1.transform.position = Input.mousePosition;

    }
    public void dragImagen2()
    {
        Imagen2.transform.position = Input.mousePosition;

    }
    public void dragImagen3()
    {
        Imagen3.transform.position = Input.mousePosition;

    }
    public void dragImagen4()
    {
        Imagen4.transform.position = Input.mousePosition;
    }

    public void dropImagen1()
    {
        float Distance = Vector3.Distance(Imagen1.transform.position, im1.transform.position);
        if (Distance<40)
        {
            Imagen1.transform.position = im1.transform.position;
            source.clip = correct;
            source.Play();
            count++;
        }
        else
        {
            Imagen1.transform.position = Imagen1InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void dropImagen2()
    {
        float Distance = Vector3.Distance(Imagen2.transform.position, im2.transform.position);
        if (Distance < 50)
        {
            Imagen2.transform.position = im2.transform.position;
            source.clip = correct;
            source.Play();
            count++;
        }
        else
        {
            Imagen2.transform.position = Imagen2InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void dropImagen3()
    {
        float Distance = Vector3.Distance(Imagen3.transform.position, im3.transform.position);
        if (Distance < 50)
        {
            Imagen3.transform.position = im3.transform.position;
            source.clip = correct;
            source.Play();
            count++;
        }
        else
        {
            Imagen3.transform.position = Imagen3InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void dropImagen4()
    {
        float Distance = Vector3.Distance(Imagen4.transform.position, im4.transform.position);
        if (Distance < 50)
        {
            Imagen4.transform.position = im4.transform.position;
            source.clip = correct;
            source.Play();
            count++;
        }
        else
        {
            Imagen4.transform.position = Imagen4InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

}
