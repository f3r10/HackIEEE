using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadWebNavigator : MonoBehaviour {

    private GameObject nombreParroquia;
    //2b2d3b949ce645af99f73477db2e2c68
	// Use this for initialization
	void Start () {
        nombreParroquia = GameObject.FindGameObjectWithTag("nombre_parroquia");

       // WebMediator.Install();
	}

    public void dataSetToBrowser()
    {
        InitialData initialData = new InitialData();
        initialData.SendData(nombreParroquia.GetComponent<Text>().text, gameObject.name);

    }
}
