using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintMeter : MonoBehaviour
{
    public float rb = 1f;
    public float colortimer = 0;

    public static string hintready = "n";
    public static string hintused = "n";
    
    
    public GameObject hintglow1;
    public GameObject hintglow2;
    public GameObject hintglow3;
    public GameObject hintglow4;
    public GameObject hintglow5;

    public GameObject rr_hintglow1;
    public GameObject rr_hintglow2;
    public GameObject rr_hintglow3;
    public GameObject rr_hintglow4;
    public GameObject rr_hintglow5;

    public GameObject Up_hintglow1;
    public GameObject Up_hintglow2;
    public GameObject Up_hintglow3;
    public GameObject Up_hintglow4;
    public GameObject Up_hintglow5;

    public GameObject LR_hintglow1;
    public GameObject LR_hintglow2;
    public GameObject LR_hintglow3;
    public GameObject LR_hintglow4;
    public GameObject LR_hintglow5;



    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
     
       hintglow1.GetComponent<ParticleSystem>().enableEmission = false;
       hintglow2.GetComponent<ParticleSystem>().enableEmission = false;
       hintglow3.GetComponent<ParticleSystem>().enableEmission = false;
       hintglow4.GetComponent<ParticleSystem>().enableEmission = false;
       hintglow5.GetComponent<ParticleSystem>().enableEmission = false;

       rr_hintglow1.GetComponent<ParticleSystem>().enableEmission = false;
       rr_hintglow2.GetComponent<ParticleSystem>().enableEmission = false;
       rr_hintglow3.GetComponent<ParticleSystem>().enableEmission = false;
       rr_hintglow4.GetComponent<ParticleSystem>().enableEmission = false;
       rr_hintglow5.GetComponent<ParticleSystem>().enableEmission = false;

        Up_hintglow1.GetComponent<ParticleSystem>().enableEmission = false;
        Up_hintglow2.GetComponent<ParticleSystem>().enableEmission = false;
        Up_hintglow3.GetComponent<ParticleSystem>().enableEmission = false;
        Up_hintglow4.GetComponent<ParticleSystem>().enableEmission = false;
        Up_hintglow5.GetComponent<ParticleSystem>().enableEmission = false;

        LR_hintglow1.GetComponent<ParticleSystem>().enableEmission = false;
        LR_hintglow2.GetComponent<ParticleSystem>().enableEmission = false;
        LR_hintglow3.GetComponent<ParticleSystem>().enableEmission = false;
        LR_hintglow4.GetComponent<ParticleSystem>().enableEmission = false;
        LR_hintglow5.GetComponent<ParticleSystem>().enableEmission = false;
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        colortimer += Time.deltaTime;
            if ((colortimer >= .5)&&(rb > 0))
            {
                  rb -= .05f;
                  colortimer = 0;
                }
        GetComponent<Image>().color = new Color(1, 1, 1);
            if(rb <= 0)
             {
             hintready = "y";
            //PlayerPrefs.SetInt("Magic Orb", 1);
            hintglow1.GetComponent<ParticleSystem>().enableEmission=true;
            hintglow2.GetComponent<ParticleSystem>().enableEmission = true;
            hintglow3.GetComponent<ParticleSystem>().enableEmission = true;
            hintglow4.GetComponent<ParticleSystem>().enableEmission = true;
            hintglow5.GetComponent<ParticleSystem>().enableEmission = true;

            rr_hintglow1.GetComponent<ParticleSystem>().enableEmission = true;
            rr_hintglow2.GetComponent<ParticleSystem>().enableEmission = true;
            rr_hintglow3.GetComponent<ParticleSystem>().enableEmission = true;
            rr_hintglow4.GetComponent<ParticleSystem>().enableEmission = true;
            rr_hintglow5.GetComponent<ParticleSystem>().enableEmission = true;

            Up_hintglow1.GetComponent<ParticleSystem>().enableEmission = true;
            Up_hintglow2.GetComponent<ParticleSystem>().enableEmission = true;
            Up_hintglow3.GetComponent<ParticleSystem>().enableEmission = true;
            Up_hintglow4.GetComponent<ParticleSystem>().enableEmission = true;
            Up_hintglow5.GetComponent<ParticleSystem>().enableEmission = true;

            LR_hintglow1.GetComponent<ParticleSystem>().enableEmission = true;
            LR_hintglow2.GetComponent<ParticleSystem>().enableEmission = true;
            LR_hintglow3.GetComponent<ParticleSystem>().enableEmission = true;
            LR_hintglow4.GetComponent<ParticleSystem>().enableEmission = true;
            LR_hintglow5.GetComponent<ParticleSystem>().enableEmission = true;
        }
    }
    [System.Obsolete]
    void OnMouseDown()
    {
     if(hintready == "y")
        {
            hintused = "y";
            hintready = "n";
            rb = 1f;
            hintglow1.GetComponent<ParticleSystem>().enableEmission = false;
            hintglow2.GetComponent<ParticleSystem>().enableEmission = false;
            hintglow3.GetComponent<ParticleSystem>().enableEmission = false;
            hintglow4.GetComponent<ParticleSystem>().enableEmission = false;
            hintglow5.GetComponent<ParticleSystem>().enableEmission = false;

            rr_hintglow1.GetComponent<ParticleSystem>().enableEmission = false;
            rr_hintglow2.GetComponent<ParticleSystem>().enableEmission = false;
            rr_hintglow3.GetComponent<ParticleSystem>().enableEmission = false;
            rr_hintglow4.GetComponent<ParticleSystem>().enableEmission = false;
            rr_hintglow5.GetComponent<ParticleSystem>().enableEmission = false;

            Up_hintglow1.GetComponent<ParticleSystem>().enableEmission = false;
            Up_hintglow2.GetComponent<ParticleSystem>().enableEmission = false;
            Up_hintglow3.GetComponent<ParticleSystem>().enableEmission = false;
            Up_hintglow4.GetComponent<ParticleSystem>().enableEmission = false;
            Up_hintglow5.GetComponent<ParticleSystem>().enableEmission = false;

            LR_hintglow1.GetComponent<ParticleSystem>().enableEmission = false;
            LR_hintglow2.GetComponent<ParticleSystem>().enableEmission = false;
            LR_hintglow3.GetComponent<ParticleSystem>().enableEmission = false;
            LR_hintglow4.GetComponent<ParticleSystem>().enableEmission = false;
            LR_hintglow5.GetComponent<ParticleSystem>().enableEmission = false;
        }    

    }

}

