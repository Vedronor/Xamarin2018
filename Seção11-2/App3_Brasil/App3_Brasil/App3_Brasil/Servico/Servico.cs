using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App3_Brasil.Modelo;
using Newtonsoft.Json;

namespace App3_Brasil.Servico
{
    public class Servico
    {
        private static string URLEstado = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";
        private static string URLMunicipio = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/{0}/municipios";

        public static List<Estado> GetEstados() {

            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(URLEstado);

            return JsonConvert.DeserializeObject<List<Estado>>(conteudo);
        }

        public static List<Municipio> GetMunicipio(int estado)
        {
            string newURL = string.Format(URLMunicipio, estado);
            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(newURL);

            return JsonConvert.DeserializeObject<List<Municipio>>(conteudo);
        }
    }
}
