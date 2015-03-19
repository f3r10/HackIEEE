using UnityEngine;
using System.Collections;
using SimpleJSON;

public class TasaAnalfabetismoDigital : MonoBehaviour {

	public string nombreParroquia { get; set; }
	public string porcentaje { get; set; }

    public TasaAnalfabetismoDigital()
	{	
	}

    public TasaAnalfabetismoDigital(string nombreParroquia, string porcentaje)
	{
        this.nombreParroquia = nombreParroquia;
        this.porcentaje = porcentaje;
	}
	public void convertFromJson(JSONNode json){
        this.nombreParroquia = json[0];
        this.porcentaje = json[1];
	}
}
