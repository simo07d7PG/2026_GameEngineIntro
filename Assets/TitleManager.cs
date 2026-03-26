using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    [SerializeField]
    GameObject helpTitle;
    public void OpenHelp()
    {
        helpTitle.SetActive(true);
    }
    public void GoToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
    public void CloseHelp()
    {
        helpTitle.SetActive(false);
    }
    void Start()
    {
        helpTitle.SetActive(false );
    }

    void Update()
    {
        
    }
}
