using System;
using UnityEngine;
using UnityEngine.UI;

public class buttonScript : MonoBehaviour
{
    [SerializeField] private GameObject _popUp;
    private Button _myButton;

    void Start()
    {
        if (_myButton == null)
        {
            _myButton = GetComponent<Button>();
            _myButton.onClick.AddListener(() => showPopUp(_popUp));
        }
    }

    private void showPopUp(GameObject popUp)
    {
        popUp.SetActive(true);
        hideButton(_myButton);
    }

    private void hideButton(Button button)
    {
        button.gameObject.SetActive(false);
    }
}
