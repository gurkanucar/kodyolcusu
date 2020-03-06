using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class hareket : MonoBehaviour
{

    [SerializeField] private GameObject oyuncu;
    public Button buton;
    public static float ram = 100;
    public GameObject bar;
    public static int zip = 0;
    public static Rigidbody2D rb;
    public static int mesafe;
    public static int ziplama2Kere;
    public Button butonAnaMenu;
    public Button butonYbaslat;
    //public Rigidbody2D mermiRb;
    // public Transform mermiCikisYeri;
    private BoxCollider2D bc;
    public Animator animator;
    float yonX;

    float hiz = 10.0f;
    float guc = 40.0f;
    //gravity scale 15 iken guc 40.0 dı
    private void Awake()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        bc = transform.GetComponent<BoxCollider2D>();
    }
    void Start()
    {
        Button btn2 = butonAnaMenu.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick2);
        Button btn3 = butonYbaslat.GetComponent<Button>();
        btn3.onClick.AddListener(TaskOnClick3);
        Button btn = buton.GetComponent<Button>();
        buton.gameObject.SetActive(false);
        btn.onClick.AddListener(TaskOnClick);
        if (PlayerPrefs.GetInt("skor")<0)
        {
            PlayerPrefs.SetInt("skor", 0);
        }
        ram = 100;
        ziplama2Kere = PlayerPrefs.GetInt("algoritma");
        //Debug.Log("ZİPLAMA SEVİYE  "+PlayerPrefs.GetInt("algoritma"));
    }

    void Update()
    {
        // yonX = CrossPlatformInputManager.VirtualAxisReference("Horizontal").GetValue;

        PlayerPrefs.SetFloat("toplamMesafe", satinAlma.toplamMesafe);
        

        yonX = CrossPlatformInputManager.GetAxis("Horizontal");

        if (yonX < 0)
        {
            animator.Play("yuru");
            transform.eulerAngles = new Vector3(0, 180, 0);
            if (satinAlma.assemblyS == 3)
            {
                ram -= 0.01f;
            }
            else
            {
                ram -= 0.07f;
            }
        }
        else if (yonX > 0)
        {
            animator.Play("yuru");
            transform.eulerAngles = new Vector3(0, 0, 0);
            if (satinAlma.assemblyS == 3)
            {
                ram -= 0.01f;
            }
            else
            {
                ram -= 0.07f;
            }
        }

        

        if (CrossPlatformInputManager.GetButtonDown("ziplamaButon"))
        {
          
         

            if(satinAlma.cSharpS==3)
            {
                 guc = 50.0f;
               // guc = 50.0f;
            }
            else
            {
                guc = 40.0f;
               // guc = 30.0f;
            }


            if (rb.velocity.y == 0 )
            {
                zip = 1;
                rb.velocity = Vector2.up * guc;
                animator.Play("zipla");

                if(satinAlma.assemblyS==3)
                {
                    ram -= 1.0f;
                }
                else
                {
                    ram -= 2.3f;
                }

               
            }
            if(zip<2 && zip>0 && rb.velocity.y < 0 && ziplama2Kere == 3)
            {
                rb.velocity = Vector2.up * guc/1.2f;
                animator.Play("zipla");
                if (satinAlma.assemblyS == 3)
                {
                    ram -= 2.0f;
                }
                else
                {
                    ram -= 5.0f;
                }




                zip += 1;
            }

        }

        if(rb.velocity.y==0 && rb.velocity.x==0)
        {
            animator.Play("dur");
        }

       /* else if (CrossPlatformInputManager.GetButtonDown("atesButon"))
        {
            Rigidbody2D mermi = Instantiate(mermiRb, mermiCikisYeri.position,mermiCikisYeri.rotation );
            mermi.velocity = Vector2.up * guc;
        }

    */
    }

    private void FixedUpdate()
    {
        if(rb.velocity.y==0)
        {
            zip = 0;
        }

        bar.transform.localScale = new Vector3(ram / 100, 1, 1);
        
        mesafe = (int)(Vector2.Distance(oyuncu.transform.position, new Vector2(-15.0f, -4.37f)));
        if(satinAlma.javaS==3)
        {
            mesafe =(int)(mesafe * 1.25f);
        }

        if (satinAlma.cS == 3)
        {
            hiz = 20.0f;
        }
        else
        {
            hiz = 10.0f;
        }

        rb.velocity = new Vector2(yonX * hiz, rb.velocity.y);



        Text yazi = GameObject.Find("skorYazi").GetComponent<Text>();
        Text yazi2 = GameObject.Find("ramYazi").GetComponent<Text>();
        yazi2.text ="RAM: " +(int)ram + " kb";
       // yazi.transform.position = new Vector2(bar.transform.position.x + 230.0f, bar.transform.position.y - 200.0f);
       // yazi2.transform.position = new Vector2(bar.transform.position.x + 230.0f , bar.transform.position.y - 130.0f);



        if (mesafe<8)
        {
            mesafe = 0;
        }
        else
        {
            mesafe -= 8;
        }

            yazi.text = "Mesafe: " + mesafe;
       
        if(ram<=0)
        {
            rb.gravityScale = 0.0f;
            rb.velocity = new Vector2(0, 0);

            if (PlayerPrefs.GetInt("skor")<mesafe)
            {
                PlayerPrefs.SetInt("skor", mesafe);
            }
            buton.gameObject.SetActive(true);
            rb.gravityScale = 0.0f;
            rb.velocity = new Vector2(0, 0);
            Text yazi3 = GameObject.Find("ySkor").GetComponent<Text>();
            yazi3.text = PlayerPrefs.GetInt("skor") + " m";
            ram = 100;

            satinAlma.toplamMesafe += mesafe;

        }
        else if(ram>100)
        {
            ram = 100;
        }
        
        //Debug.Log(Vector2.Distance(oyuncu.transform.position, new Vector2 (-15.0f, -4.37f)));

    }
    void TaskOnClick()
    {
        //SceneManager.LoadScene("oyun");
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
