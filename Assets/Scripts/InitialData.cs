using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InitialData {


    private static string PARADA_TROLEBUS = "Trolebús";
    private static string SUR_OCCIDENTE = "Sur Occidental";
    private static string SUR_ORIENTAL = "Sur Oriental";
    private static string PARADA_METROBUS = "Metrobus";
    private static string PARADA_ECOVIA = "Ecovía";
    private static string SESENTA_PIQUITO = "60 y Piquito";
    private string ln;
    private string lt;
    private string urlGoogleMaps = "";



    public void SendData(string nombreParroquia, string tipoParada)
    {
        Parroquia parroquia = new Parroquia();
        List<Parroquia> lista = parroquia.createList();
        foreach (Parroquia coordenada in lista)
        { // Loop through List with foreach.
            if (coordenada.nombreParroquia == nombreParroquia)
            {
                ln = coordenada.x;
                lt = coordenada.y;
            }
        }
        WebMediator.Install();
        urlGoogleMaps = generateUrl(ln, lt, tipoParada);

        WebMediator.LoadUrl(urlGoogleMaps);
        //Screen.height / 2
        WebMediator.SetMargin(12, Screen.height / 2 + 12, 12, 12);
        WebMediator.Show();
    
    }

    public string generateUrl(string ln, string lat, string tipoParada )
    {
        string url = "";

        if (tipoParada == PARADA_TROLEBUS)
        {
            url = "https://www.google.com/maps/d/viewer?mid=zbeD-v0-lTHU.kolrvjZecdjQ&ll=" + ln + "," + lat + "&z=15";
        }
        else if (tipoParada == SUR_OCCIDENTE)
        {
            url = "https://www.google.com/maps/d/viewer?mid=zPF8gCtdwW6g.k5FmJZOzZBSU&ll=" + ln + "," + lat + "&z=15";
        }

        else if (tipoParada == SUR_ORIENTAL)
        {
            url = "https://www.google.com/maps/d/viewer?mid=zPF8gCtdwW6g.kTeMxyZFe4wA&ll=" + ln + "," + lat + "&z=15";
        }
        else if (tipoParada == PARADA_METROBUS)
        {
            url = "https://www.google.com/maps/d/viewer?mid=z08GGt8LKpCQ.kyaxxB8N3TX0&ll=" + ln + "," + lat + "&z=15";
        }

        else if (tipoParada == PARADA_ECOVIA)
        {
            url = "https://www.google.com/maps/d/viewer?mid=z08GGt8LKpCQ.k7M3I2DdGdxI&ll=" + ln + "," + lat + "&z=15";
        }
        else if (tipoParada == SESENTA_PIQUITO)
        {
            url = "https://www.google.com/maps/d/viewer?mid=z08GGt8LKpCQ.kbyH1h-L6AAY&ll=" + ln + "," + lat + "&z=15";
        }
        else
        {
            url = "";
        }

        Debug.Log("TIPO DE PARADA: " + url);
        Debug.Log("URL GENERADA: " + url);
        return url;

    }
}
