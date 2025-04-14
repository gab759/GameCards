using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Text uiText;
    public void ChangeScene(int i)
    {
        SceneManager.LoadScene(i);
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene("Game");
    }
    public void ChangeText(string text)
    {
        uiText.text = text;
    }
}
