using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class satinAlma : MonoBehaviour
{
    public static float toplamMesafe;

    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public Button btn6;
    public Button btn7;

    public Button btnn1;
    public Button btnn2;
    public Button btnn3;
    public Button btnn4;
    public Button btnn5;
    public Button btnn6;
    public Button btnn7;


    public static float algoritmaKm = 100.0f;
    public static float pythonKm = 2500.0f;
    public static float cSharpKm = 5000.0f;
    public static float cKm = 7500.0f;
    public static float javaKm = 10000.0f;
    public static float assemblyKm = 12500.0f;
    public static float cPlusPlusKm = 25000.0f;



    public static int algoritmaS = 0;
    public static int pythonS = 0;
    public static int cSharpS= 0;
    public static int cS= 0;
    public static int javaS= 0;
    public static int assemblyS= 0;
    public static int cPlusPlusS = 0;

    void Start()
    {
        //sifirla();
        //PlayerPrefs.SetFloat("toplamMesafe",25500);
        //PlayerPrefs.SetFloat("toplamMesafe",25000);


        if (PlayerPrefs.GetFloat("toplamMesafe")<0)
        {
            PlayerPrefs.SetFloat("toplamMesafe",0);
        }
        else
        {
            toplamMesafe = PlayerPrefs.GetFloat("toplamMesafe");
            //PlayerPrefs.SetFloat("toplamMesafe", toplamMesafe);
        }
        Text yazi = GameObject.Find("toplamMesafeYazi").GetComponent<Text>();
        yazi.text = "Toplam Mesafeniz: "+(int)(toplamMesafe/100000.0f) + " Km";

        btn1 = btn1.GetComponent<Button>();
        btn1.onClick.AddListener(algoritma);

        btn2 = btn2.GetComponent<Button>();
        btn2.onClick.AddListener(python);

        btn3 = btn3.GetComponent<Button>();
        btn3.onClick.AddListener(cSharp);

        btn4 = btn4.GetComponent<Button>();
        btn4.onClick.AddListener(c);

        btn5 = btn5.GetComponent<Button>();
        btn5.onClick.AddListener(java);

        btn6 = btn6.GetComponent<Button>();
        btn6.onClick.AddListener(asm);

        btn7 = btn7.GetComponent<Button>();
        btn7.onClick.AddListener(cPlusPlus);

        btnn1 = btnn1.GetComponent<Button>();
        btnn1.onClick.AddListener(algoritma);

        btnn2 = btnn2.GetComponent<Button>();
        btnn2.onClick.AddListener(python);

        btnn3 = btnn3.GetComponent<Button>();
        btnn3.onClick.AddListener(cSharp);

        btnn4 = btnn4.GetComponent<Button>();
        btnn4.onClick.AddListener(c);

        btnn5 = btnn5.GetComponent<Button>();
        btnn5.onClick.AddListener(java);

        btnn6 = btnn6.GetComponent<Button>();
        btnn6.onClick.AddListener(asm);

        btnn7 = btnn7.GetComponent<Button>();
        btnn7.onClick.AddListener(cPlusPlus);


        if (PlayerPrefs.GetInt("algoritma") < 0)
        {
            PlayerPrefs.SetInt("algoritma", 0);
        }
        if (PlayerPrefs.GetInt("python") < 0)
        {
            PlayerPrefs.SetInt("python", 0);
        }
        if (PlayerPrefs.GetInt("cSharp") < 0)
        {
            PlayerPrefs.SetInt("cSharp", 0);
        }
        if (PlayerPrefs.GetInt("c") < 0)
        {
            PlayerPrefs.SetInt("c", 0);
        }
        if (PlayerPrefs.GetInt("java") < 0)
        {
            PlayerPrefs.SetInt("java", 0);
        }
        if (PlayerPrefs.GetInt("asm") < 0)
        {
            PlayerPrefs.SetInt("asm", 0);
        }

        if (PlayerPrefs.GetInt("cpp") < 0)
        {
            PlayerPrefs.SetInt("cpp", 0);
        }

        renkleriayarla();

        algoritmaS = PlayerPrefs.GetInt("algoritma");
        pythonS = PlayerPrefs.GetInt("python");
        cSharpS = PlayerPrefs.GetInt("cSharp");
        cS = PlayerPrefs.GetInt("c");
        javaS = PlayerPrefs.GetInt("java");
        assemblyS = PlayerPrefs.GetInt("asm");
        cPlusPlusS = PlayerPrefs.GetInt("cpp");


        Debug.Log("p " + pythonS);
        Debug.Log("cSharp " + cSharpS);
        Debug.Log("c " + cS);
        Debug.Log("java " + javaS);
        Debug.Log("asm " + assemblyS);
        Debug.Log("cpp " + cPlusPlusS);

        seciliyiYazdir();
    }

    void Update()
    {
        PlayerPrefs.SetFloat("toplamMesafe", toplamMesafe);
        /*  Debug.Log("p "+pythonS);
          Debug.Log("cSharp " + cSharpS);
          Debug.Log("c " + cS);
          Debug.Log("java " + javaS);
          Debug.Log("asm " + assemblyS);
          Debug.Log("cpp " + cPlusPlusS);*/
        Text yazi = GameObject.Find("toplamMesafeYazi").GetComponent<Text>();
        yazi.text = "Toplam Mesafeniz: " + toplamMesafe / 100 + " Km";

    }

    public void algoritma()
    {
        if(algoritmaS==0 && toplamMesafe>=algoritmaKm)
        {
            toplamMesafe = toplamMesafe - algoritmaKm;
            PlayerPrefs.SetFloat("toplamMesafe", toplamMesafe);
            Text yazi = GameObject.Find("toplamMesafeYazi").GetComponent<Text>();
            yazi.text = "Toplam Mesafeniz: " + toplamMesafe / 100 + " Km";
            algoritmaS = 3;
            PlayerPrefs.SetInt("algoritma", 3);
        }
        renkleriayarla();
    }

    public void python()
    {
        if(pythonS==0 && toplamMesafe >= pythonKm)
        {
            toplamMesafe = toplamMesafe - pythonKm;
            PlayerPrefs.SetFloat("toplamMesafe", toplamMesafe);
            Text yazi = GameObject.Find("toplamMesafeYazi").GetComponent<Text>();
            yazi.text = "Toplam Mesafeniz: " + toplamMesafe / 100 + " Km";
            seviye2Yap();
            pythonS = 3;
            PlayerPrefs.SetInt("python", 3);

        }
        else if(pythonS == 2)
        {
            seviye2Yap();
            pythonS = 3;
            PlayerPrefs.SetInt("python", 3);
        }
      //  Debug.Log("p " + pythonS);
        hepsiniYazdir();
        seciliyiYazdir();
        renkleriayarla();
    }

    public void cSharp()
    {
        if (cSharpS == 0 && toplamMesafe >= cSharpKm)
        {
            toplamMesafe = toplamMesafe - cSharpKm;
            PlayerPrefs.SetFloat("toplamMesafe", toplamMesafe);
            Text yazi = GameObject.Find("toplamMesafeYazi").GetComponent<Text>();
            yazi.text = "Toplam Mesafeniz: " + toplamMesafe / 100 + " Km";
           
            seviye2Yap();
            cSharpS = 3;
            PlayerPrefs.SetInt("cSharp", 3);

        }
        else if (cSharpS == 2)
        {
            seviye2Yap();
            cSharpS = 3;
            PlayerPrefs.SetInt("cSharp", 3);
        }
        //Debug.Log("cSharp " + cSharpS);
        hepsiniYazdir();
        seciliyiYazdir();
        renkleriayarla();
    }

    public void c()
    {
        if (cS == 0 && toplamMesafe >= cKm)
        {
            toplamMesafe = toplamMesafe - cKm;
            PlayerPrefs.SetFloat("toplamMesafe", toplamMesafe);
            Text yazi = GameObject.Find("toplamMesafeYazi").GetComponent<Text>();
            yazi.text = "Toplam Mesafeniz: " + toplamMesafe / 100 + " Km";
           
            seviye2Yap();
            cS = 3;
            PlayerPrefs.SetInt("c", 3);

        }
        else if (cS == 2)
        {
            seviye2Yap();
            cS = 3;
            PlayerPrefs.SetInt("c", 3);
        }
       // Debug.Log("c " + cS);
        hepsiniYazdir(); 
        seciliyiYazdir();
        renkleriayarla();
    }

    public void cPlusPlus()
    {
        if (cPlusPlusS == 0 && toplamMesafe >= cPlusPlusKm)
        {
            toplamMesafe = toplamMesafe - cPlusPlusKm;
            PlayerPrefs.SetFloat("toplamMesafe", toplamMesafe);
            Text yazi = GameObject.Find("toplamMesafeYazi").GetComponent<Text>();
            yazi.text = "Toplam Mesafeniz: " + toplamMesafe / 100 + " Km";
           
            seviye2Yap();
            cPlusPlusS = 3;
            PlayerPrefs.SetInt("cpp", 3);

        }
        else if (cPlusPlusS == 2)
        {
            seviye2Yap();
            cPlusPlusS = 3;
            PlayerPrefs.SetInt("cpp", 3);
        }
       // Debug.Log("cpp " + cPlusPlusS);
        hepsiniYazdir();
        seciliyiYazdir();
        renkleriayarla();
    }

    public void java()
    {
        if (javaS == 0 && toplamMesafe >= javaKm)
        {
            toplamMesafe = toplamMesafe - javaKm;
            PlayerPrefs.SetFloat("toplamMesafe", toplamMesafe);
            Text yazi = GameObject.Find("toplamMesafeYazi").GetComponent<Text>();
            yazi.text = "Toplam Mesafeniz: " + toplamMesafe / 100 + " Km";
           
            seviye2Yap();
            javaS = 3;
            PlayerPrefs.SetInt("java", 3);

        }
        else if (javaS == 2)
        {
            seviye2Yap();
            javaS = 3;
            PlayerPrefs.SetInt("java", 3);
        }
        //Debug.Log("java " + javaS);
        hepsiniYazdir();
        seciliyiYazdir();
        renkleriayarla();
    }

    public void asm()
    {

        if (assemblyS == 0 && toplamMesafe >= assemblyKm)
        {
            toplamMesafe = toplamMesafe - assemblyKm;
            PlayerPrefs.SetFloat("toplamMesafe", toplamMesafe);
            Text yazi = GameObject.Find("toplamMesafeYazi").GetComponent<Text>();
            yazi.text = "Toplam Mesafeniz: " + toplamMesafe / 100 + " Km";
            
            seviye2Yap();
            assemblyS = 3;
            PlayerPrefs.SetInt("asm", 3);

        }
        else if (assemblyS == 2)
        {
            seviye2Yap();
            assemblyS = 3;
            PlayerPrefs.SetInt("asm", 3);
        }
        //Debug.Log("asm " + assemblyS);
        hepsiniYazdir();
        seciliyiYazdir();
        renkleriayarla();
    }

 public void seviye2Yap()
    {
        if (PlayerPrefs.GetInt("python") == 3)
        {
            PlayerPrefs.SetInt("python", 2);
            pythonS = 2;
        }
        if (PlayerPrefs.GetInt("cSharp") == 3)
        {
            PlayerPrefs.SetInt("cSharp", 2);
            cSharpS = 2;
        }
        if (PlayerPrefs.GetInt("c") == 3)
        {
            PlayerPrefs.SetInt("c", 2);
            cS = 2;
        }
        if (PlayerPrefs.GetInt("java") == 3)
        {
            PlayerPrefs.SetInt("java", 2);
            javaS = 2;
        }
        if (PlayerPrefs.GetInt("asm") == 3)
        {
            PlayerPrefs.SetInt("asm", 2);
            assemblyS = 2;
        }
        if (PlayerPrefs.GetInt("cpp") == 3)
        {
            PlayerPrefs.SetInt("cpp", 2);
            cPlusPlusS = 2;
        }
    }

    public void seciliyiYazdir()
    {
        if (PlayerPrefs.GetInt("python") == 3)
        {
            Text yazi = GameObject.Find("sahipOlunan").GetComponent<Text>();
            yazi.text = "Seçili : Python";
        }
        if (PlayerPrefs.GetInt("cSharp") == 3)
        {
            Text yazi = GameObject.Find("sahipOlunan").GetComponent<Text>();
            yazi.text = "Seçili : C Sharp";
        }
        if (PlayerPrefs.GetInt("c") == 3)
        {
            Text yazi = GameObject.Find("sahipOlunan").GetComponent<Text>();
            yazi.text = "Seçili : C";
        }
        if (PlayerPrefs.GetInt("java") == 3)
        {
            Text yazi = GameObject.Find("sahipOlunan").GetComponent<Text>();
            yazi.text = "Seçili : Java";
        }
        if (PlayerPrefs.GetInt("asm") == 3)
        {
            Text yazi = GameObject.Find("sahipOlunan").GetComponent<Text>();
            yazi.text = "Seçili : Assembly";
        }
        if (PlayerPrefs.GetInt("cpp") == 3)
        {
            Text yazi = GameObject.Find("sahipOlunan").GetComponent<Text>();
            yazi.text = "Seçili : C++";
        }
    }
    public void sifirla()
    {
       
            PlayerPrefs.SetInt("algoritma", 0);
       
            PlayerPrefs.SetInt("python", 0);
      
            PlayerPrefs.SetInt("cSharp", 0);
      
            PlayerPrefs.SetInt("c", 0);
       
            PlayerPrefs.SetInt("java", 0);
       
            PlayerPrefs.SetInt("asm", 0);
      
            PlayerPrefs.SetInt("cpp", 0);
        

    }
    int a = 0;
    public void hepsiniYazdir()
    {
        a++;
        Debug.Log(a+"p " + pythonS);
        Debug.Log(a + "cSharp " + cSharpS);
        Debug.Log(a + "c " + cS);
        Debug.Log(a + "java " + javaS);
        Debug.Log(a + "asm " + assemblyS);
        Debug.Log(a + "cpp " + cPlusPlusS);
    }
    
    public void renkleriayarla()
    {
        if (PlayerPrefs.GetInt("algoritma") == 0)
        {
            ColorBlock colors = btnn1.colors;
            colors.normalColor = new Color32(255, 100, 100, 255);
            btnn1.colors = colors;
        }
        if (PlayerPrefs.GetInt("python") == 0)
        {
            ColorBlock colors = btnn2.colors;
            colors.normalColor = new Color32(255, 100, 100, 255);
            btnn2.colors = colors;
        }
        if (PlayerPrefs.GetInt("cSharp") == 0)
        {
            ColorBlock colors = btnn3.colors;
            colors.normalColor = new Color32(255, 100, 100, 255);
            btnn3.colors = colors;
        }
        if (PlayerPrefs.GetInt("c") == 0)
        {
            ColorBlock colors = btnn4.colors;
            colors.normalColor = new Color32(255, 100, 100, 255);
            btnn4.colors = colors;
        }
        if (PlayerPrefs.GetInt("java") == 0)
        {
            ColorBlock colors = btnn5.colors;
            colors.normalColor = new Color32(255, 100, 100, 255);
            btnn5.colors = colors;
        }
        if (PlayerPrefs.GetInt("asm") == 0)
        {
            ColorBlock colors = btnn6.colors;
            colors.normalColor = new Color32(255, 100, 100, 255);
            btnn6.colors = colors;
        }

        if (PlayerPrefs.GetInt("cpp") == 0)
        {
            ColorBlock colors = btnn7.colors;
            colors.normalColor = new Color32(255, 100, 100, 255);
            btnn7.colors = colors;
        }




        if (PlayerPrefs.GetInt("algoritma") == 3)
        {
            ColorBlock colors = btnn1.colors;
            colors.normalColor = new Color32(100, 255, 100, 255);
            btnn1.colors = colors;
        }
        if (PlayerPrefs.GetInt("python") == 2)
        {
            ColorBlock colors = btnn2.colors;
            colors.normalColor = new Color32(100, 255, 100, 255);
            btnn2.colors = colors;
        }
        if (PlayerPrefs.GetInt("cSharp") == 2)
        {
            ColorBlock colors = btnn3.colors;
            colors.normalColor = new Color32(100, 255, 100, 255);
            btnn3.colors = colors;
        }
        if (PlayerPrefs.GetInt("c") == 2)
        {
            ColorBlock colors = btnn4.colors;
            colors.normalColor = new Color32(100, 255, 100, 255);
            btnn4.colors = colors;
        }
        if (PlayerPrefs.GetInt("java") == 2)
        {
            ColorBlock colors = btnn5.colors;
            colors.normalColor = new Color32(100, 255, 100, 255);
            btnn5.colors = colors;
        }
        if (PlayerPrefs.GetInt("asm") == 2)
        {
            ColorBlock colors = btnn6.colors;
            colors.normalColor = new Color32(100, 255, 100, 255);
            btnn6.colors = colors;
        }

        if (PlayerPrefs.GetInt("cpp") == 2)
        {
            ColorBlock colors = btnn7.colors;
            colors.normalColor = new Color32(100, 255, 100, 255);
            btnn7.colors = colors;
        }


     
        if (PlayerPrefs.GetInt("python") == 3)
        {
            ColorBlock colors = btnn2.colors;
            colors.normalColor = new Color32(100, 100, 255, 255);
            btnn2.colors = colors;
        }
        if (PlayerPrefs.GetInt("cSharp") == 3)
        {
            ColorBlock colors = btnn3.colors;
            colors.normalColor = new Color32(100, 100, 255, 255);
            btnn3.colors = colors;
        }
        if (PlayerPrefs.GetInt("c") == 3)
        {
            ColorBlock colors = btnn4.colors;
            colors.normalColor = new Color32(100, 100, 255, 255);
            btnn4.colors = colors;
        }
        if (PlayerPrefs.GetInt("java") == 3)
        {
            ColorBlock colors = btnn5.colors;
            colors.normalColor = new Color32(100, 100, 255, 255);
            btnn5.colors = colors;
        }
        if (PlayerPrefs.GetInt("asm") == 3)
        {
            ColorBlock colors = btnn6.colors;
            colors.normalColor = new Color32(100, 100, 255, 255);
            btnn6.colors = colors;
        }

        if (PlayerPrefs.GetInt("cpp") == 3)
        {
            ColorBlock colors = btnn7.colors;
            colors.normalColor = new Color32(100, 100, 255, 255);
            btnn7.colors = colors;
        }




    }
}
