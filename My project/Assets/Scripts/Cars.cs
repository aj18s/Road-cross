using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars : MonoBehaviour
{
    public GameObject Explosion;
    public AudioClip ExplosionClip;
    AudioSource player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,1.5f);
        if(transform.position.z >= 54.229705810546878f)
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Instantiate(Explosion, transform.position, Quaternion.identity);
            GameObject.Find("Button Controller").GetComponent<AudioSource>().PlayOneShot(ExplosionClip);
            other.gameObject.SetActive(false);
            GameObject.Find("Button Controller").GetComponent<Controller>().OverPanel();
            Destroy(this.gameObject);
        }
    }
}
