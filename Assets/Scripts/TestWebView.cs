using UnityEngine;
using System.Collections;

public class TestWebView : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        WebMediator.Install();
        WebMediator.LoadUrl("http://www.google.com.ec");
        WebMediator.SetMargin(12, Screen.height / 2 + 12, 12, 12);
        WebMediator.Show();
	}
	
	// Update is called once per frame
	void Update () 
    {
        
	}     
}
