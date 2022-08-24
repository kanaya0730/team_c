using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoder : MonoBehaviour
{
    [SerializeField]
    GameObject _creditPanael;
    [SerializeField]
    GameObject _rulePanael;
    public void OnClick(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void Credit()
    {
        _creditPanael.SetActive(true);
    }
    public void Playrule()
    {
        _rulePanael.SetActive(true);
    }
    public void CloseCredit()
    {
        _creditPanael.SetActive(false);
    }
    public void CloserulePanel()
    {
        _rulePanael.SetActive(false);
    }
}