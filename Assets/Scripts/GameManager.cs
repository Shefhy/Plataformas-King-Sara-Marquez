using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public int vidas;
    public int puntos = 0;
    private SFXManager sfxManager;


    void Awake()
    {
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        //Si ya hay una instancia y no soy yo me destruyo
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }

        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this);
    }

    public void RestarVidas()
    {
        vidas--;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BombExplode(GameObject bomb)
    {
        Animator bombAnimator;
        bombAnimator = bomb.GetComponent<Animator>();
        bombAnimator.SetBool("BombExplosion", true);
        Destroy(bomb, 0.7f);
        sfxManager.BombExlpode();
    }

}
