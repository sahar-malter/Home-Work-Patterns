using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class cake : MonoBehaviour
{

    public GameObject Cake_pf;
    public Transform spown_loacation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
     GetComponent<Collider>().enabled = false;
        StartCoroutine(cake_it());
    }

    IEnumerator cake_it()
    {
        Debug.Log("yum yum, i ate the cake");
        Debug.Log("points +1");
     GameManager.score++;
     yield return new WaitForSeconds(0.2f);
     GetComponent<Collider>().enabled = true;
     GameObject new_cake = Instantiate(Cake_pf, spown_loacation.position, spown_loacation.rotation);
     new_cake.transform.localScale /= (1.5f+(GameManager.score/5));
        Debug.Log("OOHHH a new cake !!");

        Destroy(gameObject);
    }

}
