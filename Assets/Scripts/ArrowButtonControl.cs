using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowButtonControl : MonoBehaviour
{
    [SerializeField] private GameObject _targetObject;
    [SerializeField] private string _targetMessage;
    [SerializeField] private Color _buttonDownColor;
    [SerializeField] private float _buttonDownSize;
    public void OnMouseEnter()
    {
        Debug.Log("ENTER");
        Image image = GetComponent<Image>();
        if (image != null)
        {
            image.color = Color.gray;
        }
    }
    void OnMouseExit()
    {
        Debug.Log("EXIT");
        Image image = GetComponent<Image>();
        if (image != null)
        {
            image.color = Color.white;
        }
    }
    void OnMouseDown()
    {
        Debug.Log("DOWN");
        transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
    }
    void OnMouseUp()
    {
        Debug.Log("UP");
        transform.localScale = Vector3.one;
        if(_targetObject != null)
        {
            _targetObject.SendMessage(_targetMessage);
        }
    }
}
