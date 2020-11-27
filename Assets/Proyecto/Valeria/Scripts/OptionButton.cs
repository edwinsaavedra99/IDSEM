using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//indica que se require un boton y una imagen
[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public class OptionButton : MonoBehaviour
{
    private Text m_text = null;
    private Button m_button = null;
    private Image m_imagen = null;
    private Color m_originalColor = Color.black;

    public Option Option
    {
        get;set;
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
    public void Construct(Option option,Action<OptionButton> callback)
    {
        m_text.text = option.text;
        m_button.onClick.RemoveAllListeners();
        m_button.enabled = true;
        m_imagen.color = m_originalColor;
        Option = option;
        m_button.onClick.AddListener(
            delegate
            {
                callback(this);
            } );
    }
    public void SetColor(Color c)
    {
        m_button.enabled = false;
        m_imagen.color = c;
    }
}
