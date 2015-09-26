using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fader : MonoBehaviour
{
    public static Fader S;
    public Image some;

    void Awake()
    {
        S = this;
        some = GetComponent<Image>();
    }

    // Use this for initialization
    void Start()
    {
        some.color = Color.red;
        some.CrossFadeAlpha(0, 2, true);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
