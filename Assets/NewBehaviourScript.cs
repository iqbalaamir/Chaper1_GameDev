using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public Button button;
    public string newScene;
    private object onButtonClick;

    // Start is called before the first frame update
    private void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        Debug.Log("Button Clicked");
        SceneManager.LoadScene(newScene);
    }
}
