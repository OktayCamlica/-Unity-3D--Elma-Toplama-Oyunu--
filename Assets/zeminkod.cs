using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zeminkod : MonoBehaviour
{
    float suankican = 100.0f;
    float mevcutcan = 100.0f;
    public Image canbarı;
    public GameObject panel;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "elma")
        {
            Destroy(collision.gameObject);
        }
        suankican -= 10.0f;
        canbarı.fillAmount = suankican / mevcutcan;
        if (suankican <= 0)
        {
            panel.SetActive(true);
            Time.timeScale = 0.0f;
        }
      

    }


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
