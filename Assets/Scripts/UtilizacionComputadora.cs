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

		public class UtilizacionComputadora
		{
	public string parroquia { get; set; }
	public string porcentaje { get; set; }

	public UtilizacionComputadora ()
	{	
	}
	public UtilizacionComputadora (string parrroquia, string porcentaje)
	{
		this.parroquia = parroquia;
		this.porcentaje = porcentaje;
	}
	public void convertFromJson(JSONNode json){
		this.parroquia = json [14];
		this.porcentaje = json [26];
	}
	
	public override string ToString(){
		return this.parroquia + "\t" + this.porcentaje;
	}
}