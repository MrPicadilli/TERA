using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthSystem : MonoBehaviour
{
    [SerializeField] Sprite fullHearth, emptyHearth;

    [SerializeField] Image life1, life2,life3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update() {
        switch(Player.instance.currentHealth){
            case 3:
                life1.sprite = fullHearth;
                life2.sprite = fullHearth;
                life3.sprite = fullHearth;
                break;
            case 2:
                life1.sprite = fullHearth;
                life2.sprite = fullHearth;
                life3.sprite = emptyHearth;
                break;
            case 1:
                life1.sprite = fullHearth;
                life2.sprite = emptyHearth;
                life3.sprite = emptyHearth;
                break;
            case 0:
                life1.sprite = emptyHearth;
                life2.sprite = emptyHearth;
                life3.sprite = emptyHearth;
                break;
            
                
        }
    }
}
