using System.Collections.Generic;
using MeetApp.Model;
using System.IO;
using System.Xml;
using System;

namespace MeetApp
{
    public class XMLPersistence : IPersistence
    {

        // legge gli incontri da un file xml
        public List<Incontro> GetIncontri()
        {
            List<Incontro> incontri = new List<Incontro>();
            Incontro incontro = null;
            List<Partecipante> partecipanti = null;
            List<Partecipante> assenti = null;
            Dictionary<Partecipante, DateTime> esclusi = null;

            FileStream fs = new FileStream(Environment.CurrentDirectory + "\\Incontri.xml", FileMode.Open, FileAccess.Read);
            XmlDataDocument xmldoc = new XmlDataDocument();
            xmldoc.Load(fs);
            XmlNodeList incontriList = xmldoc.GetElementsByTagName("incontro");
            for (int i = 0; i <= incontriList.Count - 1; i++)
            {
                XmlNodeList incontroChilds = incontriList[i].ChildNodes;
                string descrizione = null;
                string data = null;
                string ora = null;
                string luogo = null;
                for (int j = 0; j <= incontroChilds.Count - 1; j++)
                {
                    if (incontroChilds[j].Name == "descrizione")
                        descrizione = incontroChilds[j].InnerText;
                    else if (incontroChilds[j].Name == "data")
                        data = incontroChilds[j].InnerText;
                    else if (incontroChilds[j].Name == "ora")
                        ora = incontroChilds[j].InnerText;
                    else if (incontroChilds[j].Name == "luogo")
                        luogo = incontroChilds[j].InnerText;
                    else if (incontroChilds[j].Name == "partecipanti")
                    {
                        partecipanti = new List<Partecipante>();
                        XmlNodeList partecipantiList = incontroChilds[j].ChildNodes;
                        for (int k = 0; k <= partecipantiList.Count - 1; k++)
                        {
                            string nome = null;
                            string cognome = null;
                            string email = null;
                            XmlNodeList partecipanteChilds = partecipantiList[k].ChildNodes;
                            for (int z = 0; z <= partecipanteChilds.Count - 1; z++)
                            {
                                if (partecipanteChilds[z].Name == "nome")
                                    nome = partecipanteChilds[z].InnerText;
                                else if (partecipanteChilds[z].Name == "cognome")
                                    cognome = partecipanteChilds[z].InnerText;
                                else if (partecipanteChilds[z].Name == "email")
                                    email = partecipanteChilds[z].InnerText;
                            }
                            partecipanti.Add(new Partecipante(nome, cognome, email));
                        }
                    }
                    else if (incontroChilds[j].Name == "assenti")
                    {
                        assenti = new List<Partecipante>();
                        XmlNodeList assentiList = incontroChilds[j].ChildNodes;
                        for (int k = 0; k <= assentiList.Count - 1; k++)
                        {
                            string nome = null;
                            string cognome = null;
                            string email = null;
                            XmlNodeList assentiChilds = assentiList[k].ChildNodes;
                            for (int z = 0; z <= assentiChilds.Count - 1; z++)
                            {
                                if (assentiChilds[z].Name == "nome")
                                    nome = assentiChilds[z].InnerText;
                                else if (assentiChilds[z].Name == "cognome")
                                    cognome = assentiChilds[z].InnerText;
                                else if (assentiChilds[z].Name == "email")
                                    email = assentiChilds[z].InnerText;
                            }
                            assenti.Add(new Partecipante(nome, cognome, email));
                        }
                    }
                    else if (incontroChilds[j].Name == "esclusi")
                    {
                        esclusi = new Dictionary<Partecipante, DateTime>();
                        Partecipante partecipante = null;
                        String dataEsclusione = null;
                        XmlNodeList esclusiList = incontroChilds[j].ChildNodes;
                        for (int k = 0; k <= esclusiList.Count - 1; k++)
                        {
                            XmlNodeList esclusoChilds = esclusiList[k].ChildNodes;
                            for (int z = 0; z <= esclusoChilds.Count - 1; z++)
                            {
                                if (esclusoChilds[z].Name == "partecipante")
                                {
                                    string nome = null;
                                    string cognome = null;
                                    string email = null;
                                    XmlNodeList partecipanteChilds = esclusoChilds[z].ChildNodes;
                                    for (int y = 0; y <= partecipanteChilds.Count - 1; y++)
                                    {
                                        if (partecipanteChilds[y].Name == "nome")
                                            nome = partecipanteChilds[y].InnerText;
                                        else if (partecipanteChilds[y].Name == "cognome")
                                            cognome = partecipanteChilds[y].InnerText;
                                        else if (partecipanteChilds[y].Name == "email")
                                            email = partecipanteChilds[y].InnerText;
                                    }
                                    partecipante = new Partecipante(nome, cognome, email);
                                }
                                else if (esclusoChilds[z].Name == "data")
                                    dataEsclusione = esclusoChilds[z].ChildNodes[0].InnerText;
                            }
                            string[] ggmmyy = dataEsclusione.Split(new char[] { '/' });
                            esclusi.Add(partecipante, new DateTime(Int32.Parse(ggmmyy[2]), Int32.Parse(ggmmyy[1]), Int32.Parse(ggmmyy[0])));
                        }
                    }
                }
                string[] ggmmyyyy = data.Split(new char[] { '/' });
                incontro = new Incontro(descrizione, new DateTime(Int32.Parse(ggmmyyyy[2]), Int32.Parse(ggmmyyyy[1]), Int32.Parse(ggmmyyyy[0])), ora, luogo);
                incontro.Partecipanti = partecipanti;
                incontro.Assenti = assenti;
                incontro.Esclusi = esclusi;
                incontri.Add(incontro);
            }
            fs.Close();
            return incontri;
        }

        // legge i possibiliPartecipanti da un file xml
        public List<Partecipante> GetPossibiliPartecipanti()
        {
            // ho cablato la lista nel codice giusto per fare prima
            // in teoria dovrei leggere dal file xml come ho fatto nel metodo sopra
            return new List<Partecipante>(){
                    new Partecipante("Mario", "Rossi", "mr@gmail.com"),
                    new Partecipante("Andrea", "Costa", "ac@live.it"),
                    new Partecipante("Maria", "Rosa", "rm@gmail.com"),
                    new Partecipante("Daniela", "Cinti", "dc@live.it"),
                    new Partecipante("Valerio", "Renzi", "vr@gmail.com"),
                    new Partecipante("Alex", "Sandro", "as@live.it")
                };
        }

        // salva gli incontri su un file xml
        public void SalvaCambiamenti(Modello modello)
        {
            FileStream writer = new FileStream(Environment.CurrentDirectory + "\\Incontri.xml", FileMode.Create);

            using (XmlWriter xmlWriter = XmlWriter.Create(writer))
            {
                xmlWriter.WriteStartElement("incontri");
                foreach (Incontro i in modello.Incontri)
                {
                    xmlWriter.WriteStartElement("incontro");

                    xmlWriter.WriteElementString("descrizione", i.Descrizione);
                    xmlWriter.WriteElementString("data", i.Data.ToShortDateString());
                    xmlWriter.WriteElementString("ora", i.Ora);
                    xmlWriter.WriteElementString("luogo", i.Luogo);

                    xmlWriter.WriteStartElement("partecipanti");
                    foreach(Partecipante p in i.Partecipanti)
                    {
                        xmlWriter.WriteStartElement("partecipante");
                        xmlWriter.WriteElementString("nome", p.Nome);
                        xmlWriter.WriteElementString("cognome", p.Cognome);
                        xmlWriter.WriteElementString("email", p.Email);
                        xmlWriter.WriteEndElement(); //partecipante
                    }
                    xmlWriter.WriteEndElement(); //partecipanti

                    xmlWriter.WriteStartElement("assenti");
                    foreach (Partecipante p in i.Assenti)
                    {
                        xmlWriter.WriteStartElement("partecipante");
                        xmlWriter.WriteElementString("nome", p.Nome);
                        xmlWriter.WriteElementString("cognome", p.Cognome);
                        xmlWriter.WriteElementString("email", p.Email);
                        xmlWriter.WriteEndElement(); //partecipante
                    }
                    xmlWriter.WriteEndElement(); //assenti

                    xmlWriter.WriteStartElement("esclusi");
                    foreach (KeyValuePair<Partecipante, DateTime> kvp in i.Esclusi)
                    {
                        xmlWriter.WriteStartElement("escluso");
                        Partecipante p = kvp.Key;
                        xmlWriter.WriteStartElement("partecipante");
                        xmlWriter.WriteElementString("nome", p.Nome);
                        xmlWriter.WriteElementString("cognome", p.Cognome);
                        xmlWriter.WriteElementString("email", p.Email);
                        xmlWriter.WriteEndElement(); //partecipante
                        xmlWriter.WriteElementString("data", kvp.Value.ToShortDateString());
                        xmlWriter.WriteEndElement(); //escluso
                    }
                    xmlWriter.WriteEndElement(); //esclusi

                    xmlWriter.WriteEndElement();//incontro
                }
                xmlWriter.WriteEndElement();//incontri
                xmlWriter.WriteEndDocument();

                writer.Flush();
            }
        }
    }
}