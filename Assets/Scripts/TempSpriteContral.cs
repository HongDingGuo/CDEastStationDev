using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempSpriteContral : MonoBehaviour {

    public List<Sprite> objls_Sprites;
    

    private void Start()
    {
        StartCoroutine(ShowSprite());
    }


    IEnumerator ShowSprite()
    {
        int count = objls_Sprites.Count;
        for (int i = 0; i < count; i++)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = objls_Sprites[i];
            yield return new WaitForSeconds(2.0f);
            if (i >= 2)
                i = -1;
        }
    }

}
