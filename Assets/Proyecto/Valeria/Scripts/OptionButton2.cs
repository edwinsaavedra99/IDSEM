using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//indica que se require un boton y una imagen
[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public class OptionButton2 : MonoBehaviour
{
    private Text m_text = null;
    private Button m_button = null;
    private Image m_imagen = null;
    private Color m_originalColor = Color.black;

    public Option2 Option2
    {
        get; set;
    }

    private void Awake()
    {
        m_button = GetComponent<Button>();
        m_imagen = GetComponent<Image>();
        m_text = transform.GetChild(0).GetComponent<Text>();
        m_originalColor = m_imagen.color;
    }
    //notificar que opcion esta solucionando el jugador
    //para usar algun efecto usar este callback
    public void Construct(Option2 option2)
    {
        m_text.text = option2.text;
        m_button.onClick.RemoveAllListeners();
        m_button.enabled = true;
        m_imagen.color = m_originalColor;
        Option2 = option2;
        m_button.interactable = false;
    }
    public void SetColor(Color c)
    {
        m_button.enabled = false;
        m_imagen.color = c;
    }
}
