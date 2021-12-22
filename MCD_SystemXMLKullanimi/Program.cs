using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MCD_SystemXMLKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region XML Data Yazma

            //XmlTextWriter xmlText = new XmlTextWriter(@"C:\XML\Personellerim.xml",System.Text.UTF8Encoding.UTF8);

            ////<!---Yorum--->
            //xmlText.WriteComment("Yorumlar buraya yazılır.");

            ////root oluşturma
            //xmlText.WriteStartElement("Personellerim");

            ////child oluşturma
            //xmlText.WriteStartElement("Personel");
            ////subchild oluşturma
            //xmlText.WriteAttributeString("ID","1");
            //xmlText.WriteElementString("İsim", "Ahmet");
            //xmlText.WriteElementString("Soyisim", "Koç");
            //xmlText.WriteElementString("EmailAdres", "ahmet.koc@gmail.com");
            ////child element kapatma
            //xmlText.WriteEndElement();


            ////child oluşturma
            //xmlText.WriteStartElement("Personel");
            ////subchild oluşturma
            //xmlText.WriteAttributeString("ID", "2");
            //xmlText.WriteElementString("İsim", "Gamze");
            //xmlText.WriteElementString("Soyisim", "Kural");
            //xmlText.WriteElementString("EmailAdres", "gamze.kural@gmail.com");
            ////child element kapatma
            //xmlText.WriteEndElement();


            ////root kapatma
            //xmlText.WriteEndElement();
            //xmlText.Close();

            #endregion

            #region xml data okuma

            //XmlReader XmlRead = XmlReader.Create(@"C:\XML\Personellerim.xml");
            //while (XmlRead.Read())
            //{
            //    Console.WriteLine($"{ XmlRead.Name.ToString()} - {XmlRead.Value.ToString()}");
            //}

            //Console.ReadLine();


            /////////////2.yol////////////////
            XmlReader reader = XmlReader.Create(@"C:\XML\personellerim.xml");
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    if (reader.MoveToFirstAttribute())
                    {
                        Console.WriteLine("ID : " + reader.Value.ToString());
                    }
                    //return only when you have START 
                    switch (reader.Name.ToString())
                    {
                        case "İsim":
                            Console.WriteLine("İsim : " + reader.ReadString());
                            break;
                        case "Soyisim":
                            Console.WriteLine("Soyisim : " + reader.ReadString());
                            break;
                        case "EmailAdres":
                            Console.WriteLine("EmailAdres : " + reader.ReadString());
                            Console.WriteLine("");
                            break;
                    }
                }
            }
            Console.ReadLine();

            #endregion

        }
    }
}
