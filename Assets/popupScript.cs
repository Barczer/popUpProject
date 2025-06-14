using UnityEngine;
using UnityEngine.InputSystem.Android;
using UnityEngine.UI;
using TMPro;
using System;
using System.Diagnostics.Tracing;
using UnityEngine.Events;

public class popupScript : MonoBehaviour
{
    [SerializeField] private Canvas _popUp;
    [SerializeField] private string _popUpText;
    [SerializeField] private TextMeshProUGUI _popUpStringPlace;
    [SerializeField] private Button _yesButton;
    [SerializeField] private Button _noButton;
    [SerializeField] private Button _exitButton;

    private void Start()
    {
        _popUp = gameObject.GetComponentInChildren<Canvas>();
        setUpPopUpText(_popUpText);
        addListinerButton(sendMessage, _yesButton);
        addListinerButton(noButtonClicked, _noButton);
    }

    private void setUpPopUpText(string text)
    {
        _popUpStringPlace.text = text;
    }

    private void addListinerButton(UnityAction listener, Button button)
    {
        button.onClick.AddListener(listener);
    }
    private void sendMessage()
    {
        Debug.Log("Working!");
    }

    private void enableExitButton(Button exitButton)
    {
        exitButton.gameObject.SetActive(true);
    }

    private void disablePopUp(GameObject popUp)
    {
        popUp.gameObject.SetActive(false);
    }

    private void noButtonClicked()
    {
        enableExitButton(_exitButton);
        disablePopUp(gameObject);
    }
    
}
