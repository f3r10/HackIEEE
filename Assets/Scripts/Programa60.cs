// ------------------------------------------------------------------------------
// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;
using SimpleJSON;

public class Programa60
{
	public string nombre { get; set; }
	public string x { get; set; }
	public string y { get; set; }
	
	public Programa60 ()
	{	
	}
	public Programa60 (string nombre, string x, string y)
	{
		this.nombre = nombre;
		this.x = x;
		this.y = y;
	}
	public void convertFromJson(JSONNode json){
		this.nombre = json [0];
		this.x = json [1];
		this.y =  json [2];
	}

	public override string ToString(){
		//return "Coordenada: " + this.nombre + " , " + this.x + " , " + this.y;
		return this.y + " , " + this.x;
	}
}
