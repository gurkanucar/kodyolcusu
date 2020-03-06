using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class yenidenBaslat : MonoBehaviour
{
    public Button buton;
    public Button butonAnaMenu;
    public Button butonYbaslat;
    public GameObject obje;
    void Start()
    {
        hareket.ram = 100;
        Button btn = buton.GetComponent<Button>();
        buton.gameObject.SetActive(false);
        btn.onClick.AddListener(TaskOnClick);
        Button btn2 = butonAnaMenu.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick2);
        Button btn3 = butonYbaslat.GetComponent<Button>();
        btn3.onClick.AddListener(TaskOnClick3);


    }

    void Update()
    {

        transform.position = new Vector3(obje.transform.position.x, -10.0f, -10f);
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        hareket.rb.gravityScale = 0.0f;
        hareket.rb.velocity = new Vector2(0, 0);

        if (PlayerPrefs.GetInt("skor") < hareket.mesafe)
        {
            PlayerPrefs.SetInt("skor", hareket.mesafe);
        }

       // SceneManager.LoadScene("oyun");
         hareket.rb.gravityScale = 0.0f;
         hareket.rb.velocity = new Vector2(0,0);
  
        Debug.Log("yenidennn");
        buton.gameObject.SetActive(true);
        Text yazi3 = GameObject.Find("ySkor").GetComponent<Text>();
        yazi3.text = PlayerPrefs.GetInt("skor") + " m";

        satinAlma.toplamMesafe += hareket.mesafe;

    }

    void TaskOnClick()
    {
      //  SceneManager.LoadScene("oyun");
    }
    void TaskOnClick2()
    {
        SceneManager.LoadScene("anaMenu");
    }
    void TaskOnClick3()
    {
        SceneManager.LoadScene("oyun");
    }
}
