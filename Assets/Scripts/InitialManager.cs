using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InitialManager : MonoBehaviour
{
    private int b_Points;
    public Text bestScore;
    public string name;
    public GameObject errorMessage;
    public InputField myInputField;

    private void Start()
    {
        if (PlayerPrefs.HasKey("best"))
            b_Points = PlayerPrefs.GetInt("best");
        if(PlayerPrefs.HasKey("name"))
            name = PlayerPrefs.GetString("name");

        bestScore.text = $"Best Score: {name} : {b_Points}";
    }

    public void Next()
    {

        if (PlayerPrefs.HasKey("name"))
            SceneManager.LoadScene(1);
        else
            errorMessage.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void NameChange()
    {
        name = myInputField.GetComponent<InputField>().text;
        PlayerPrefs.SetString("name", name);
    }

    public void CloseError()
    {
        errorMessage.SetActive(false);
    }
}
