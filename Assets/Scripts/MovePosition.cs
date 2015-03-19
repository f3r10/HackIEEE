using System;
using UnityEngine;
using System.Collections;
using SimpleJSON;
using UnityEngine.UI;
using System.Collections.Generic;

public class MovePosition : MonoBehaviour 
{
    private Vector3 recTransform;
    private Vector3 move;
    public Text txtNombreParroquia;
    public Text txtResultado;
    private string appKey = "5e22c11c82cc941ed343b5208be1b1d44aec2028";
    private string guid = "POBLA-QUE-UTILI-COMPU";
    private TbConnectJunar dataStream;
    private string urlIInfo;

    public void OnClickParroquia()
    {
        Vector3 pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -1.05f);
        txtNombreParroquia.transform.position = pos;

        txtNombreParroquia.text = gameObject.name;

        Debug.Log("click en " + gameObject.name);      

        dataStream = new TbConnectJunar(appKey, guid);
        urlIInfo = dataStream.invoke(new string[0]);

        // pass element to change
        Debug.Log(urlIInfo);

        callURI(urlIInfo, gameObject.name);
    }

    public void callURI(String p_url, String parroquia)
    {
        HTTP.Request requestJunar = new HTTP.Request("get", p_url);
        //requestJunar.Send( request  => var = request.response.Text);

        requestJunar.Send((request) =>
        {
            // Define Json class implementation
            //extractData (request.response.Text);
            //extract60yPiquitoData (request.response.Text);
            txtResultado.text = extractUtilizacionCompuData(request.response.Text, parroquia);
        });


    }

    public String extractUtilizacionCompuData(string json, string parroquiaSeleccionada)
    {
        var N = JSONNode.Parse(json);

        // recorrido del json y agrego a lista
        List<UtilizacionComputadora> lista = new List<UtilizacionComputadora>();
        for (int i = 1; i < 316; i++)
        {
            UtilizacionComputadora obj = new UtilizacionComputadora();
            obj.convertFromJson(N["result"][i]);
            lista.Add(obj);
        }

        var result = "";
        foreach (UtilizacionComputadora elemento in lista)
        {
            if (elemento.parroquia == parroquiaSeleccionada)
            {
                result = "Población que utilizó computadora (%)\n" + result + elemento.ToString() + "\n";
            }
        }
        Debug.Log(result);
        return result;
    }

    public void OnMouseUpAsButton()
    {
        OnClickParroquia();
    }
}
