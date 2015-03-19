// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using UnityEngine;
using System.Collections;

public class TbConnectJunar
{
		private String app_key = "OUR_API_KEY";
		private String guid = "";
		private String base_uri = "http://quito.cloudapi.junar.com";

		public TbConnectJunar (string p_app_key, string p_guid)
		{
				this.setGUID (p_guid);
				this.setAPPKEY (p_app_key);
		}

		public String getGUID ()
		{
				return guid;
		}

		public String getAuthKey ()
		{
				return this.app_key;
		}

		public void setGUID (string p_guid)
		{
				guid = p_guid;
		}

		public void setAPPKEY (string p_app_key)
		{
				app_key = p_app_key;
		}

		public String invoke (string[] p_params)
		{
				String url = "/datastreams/invoke/" + getGUID () + "?";
				url += "auth_key=" + app_key + "&output=json_array";
			
				for (int i=0; i < p_params.Length; i++) {
						url += "&pArgument" + i + "=" + p_params [i];
				}
				return this.base_uri + url;
		}

		public String info ()
		{
				String url = "/datastreams/" + getGUID () + "?auth_key=" + getAuthKey ();
				return this.base_uri + url;
		}
}

