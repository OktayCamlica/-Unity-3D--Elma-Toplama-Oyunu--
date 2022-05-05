using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yonetici : MonoBehaviour
{

    public GameObject elma;  //instantiate edeceğimiz yani çoğaltacağımız nesnenin adı gerekiyor

    bool oyun_durduruldu = false;


    public void durdurma_butonu()
    {
        oyun_durduruldu = !oyun_durduruldu;

        if (oyun_durduruldu == true)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }


    void Start()
    {
        // InvokeRepeating("saniyeazalt", 5f, 1f);  5 saniye sonra başlasın 1er 1er düşsün
        InvokeRepeating("elmaEkle",0.0f ,0.5f);

    }

    void elmaEkle()
    {
        float rastgele = Random.Range(-5f, 10f);
        GameObject yeni_elma = Instantiate(elma , new Vector3(rastgele, 4, -9), Quaternion.identity);
    }






  /*  void saniyeazalt()
    {
        saniye--;
        Debug.Log(saniye.ToString());
        if (saniye == 8)
        {
            CancelInvoke("saniyeazalt");     saniye 8 olduğunda ınvoke komuutunu durdur 
        }
    } */
   
    void Update()
    {
      //  Debug.Log(Time.time.ToString());
    } 
}
