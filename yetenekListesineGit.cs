using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class yetenekListesineGit : MonoBehaviour
{
    public Button buton;
    void Start()
    {
        Button btn = buton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }


    void Update()
    {

    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("diller");
    }
}
