using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icon_script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject star;
    void Update()
    {
        SpriteRenderer star_parent_sprite = star.transform.parent.gameObject.GetComponent<SpriteRenderer>();
        if (star_parent_sprite.color == Color.yellow) {
            Destroy(star);
        }
    }
}
