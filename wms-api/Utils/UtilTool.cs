using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Xml;
using wms_api.Models;

namespace wms_api.Utils
{

    public class UtilTool
    {


        public static string GetNumbers(string input)
        {
            return new string(input.Where(c => char.IsDigit(c)).ToArray());
        }

        public static string GetNameSharedPoint(string nombre, string fileName, string expediente)
        {
            try
            {
                nombre = nombre.Replace(" ", "");
                var ext = fileName.Split('.');
                return UtilTool.NormalizeFileName(nombre + "-" + expediente + "-" + UtilTool.ReturnGUID(3) + "." + ext[ext.Length - 1]);
            }
            catch
            {
                return fileName;
            }
        }


        //Normalizar el nombre de un fichero      \ / : * ? " < > |   C:/” + [nombre de archivo = 256 caracteres] + null terminator
        public static string NormalizeFileName(string fileName)
        {
            try
            {
                string invalidChars = System.Text.RegularExpressions.Regex.Escape(
                new string(System.IO.Path.GetInvalidFileNameChars())
           );
                string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);

                return System.Text.RegularExpressions.Regex.Replace(fileName, invalidRegStr, "_");
            }
            catch
            {
                return fileName;
            }
        }

        public static string clearString(string _string, bool cleanCharacterComma = false)
        {
            try
            {
                _string = _string.Replace("'", "");
                if (cleanCharacterComma)
                    _string = _string.Replace(",", "");

                _string = _string.Replace("undefined", "");
                _string = _string.Replace("null", "");

                return _string;
            }
            catch (Exception e)
            {
                return _string;
            }
        }

        public static bool ConvertBool(string value)
        {
            try
            {
                if (value == "1" || value.ToUpper() == "TRUE")
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public static string ReturnGUID(int i)
        {
            return Guid.NewGuid().ToString().ToUpper().Remove(i);
        }

        public static string CryptPasswd(string Valor, string Key)
        {
            if (string.IsNullOrEmpty(Valor))
                return "";

            Crypto cpt = new Crypto(Crypto.SymmProvEnum.DES);
            return cpt.Encrypting(Valor, Key);

        }

        public static string DeCryptPasswd(string Valor, string Key)
        {
            if (string.IsNullOrEmpty(Valor))
                return "";

            Crypto cpt = new Crypto(Crypto.SymmProvEnum.DES);
            return cpt.Decrypting(Valor, Key);

        }

        public static string ReturnGUID()
        {
            return Guid.NewGuid().ToString().ToUpper().Remove(8);
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static object CloneObject(object objSource, Type typeSource = null)
        {
            //step : 1 Get the type of source object and create a new instance of that type
            if (typeSource == null) typeSource = objSource.GetType();

            object objTarget = Activator.CreateInstance(typeSource);

            Newtonsoft.Json.Linq.JObject objSource_help = null;
            try
            {
                objSource_help = (Newtonsoft.Json.Linq.JObject)Newtonsoft.Json.Linq.JToken.FromObject(objSource);
            }
            catch { }

            //Step2 : Get all the properties of source object type
            PropertyInfo[] propertyInfo = typeSource.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            //Step : 3 Assign all source property to taget object 's properties
            foreach (PropertyInfo property in propertyInfo)
            {
                //Check whether property can be written to
                if (property.CanWrite)
                {
                    //Step : 4 check whether property type is value type, enum or string type
                    if (property.PropertyType.IsValueType || property.PropertyType.IsEnum || property.PropertyType.Equals(typeof(System.String)))
                    {

                        try
                        {
                            property.SetValue(objTarget, property.GetValue(objSource, null), null);
                        }
                        catch
                        {

                            Type t = property.PropertyType;
                            var value = objSource_help[property.Name];

                            try
                            {
                                value = objSource_help[property.Name].ToString();
                            }
                            catch
                            {
                                try
                                {
                                    value = objSource_help[property.Name.ToLower()].ToString();
                                }
                                catch
                                {

                                    try
                                    {
                                        value = objSource_help.Properties().FirstOrDefault(p => p.Name.ToLower() == property.Name.ToLower()).Value;

                                    }
                                    catch { value = null; }

                                }
                            }

                            if (value == null)
                            {
                                property.SetValue(objTarget, null, null);
                                continue;
                            }

                            dynamic _value = getType(t, value);

                            //var tmp_value = Convert.ChangeType(objSource_help[property.Name], property);
                            property.SetValue(objTarget, _value, null);
                        }
                    }
                    //else property type is object/complex types, so need to recursively call this method until the end of the tree is reached
                    else
                    {
                        try
                        {
                            object objPropertyValue = property.GetValue(objSource, null);

                            if (objPropertyValue == null)
                            {
                                property.SetValue(objTarget, null, null);
                            }
                            else
                            {
                                property.SetValue(objTarget, CloneObject(objPropertyValue), null);
                            }

                        }
                        catch (Exception e) { }
                    }
                }
            }
            return objTarget;
        }


        public static List<string> GetPropertyKeysForDynamic(dynamic dynamicToGetPropertiesFor)
        {
            var dictionary = new Dictionary<string, object>();
            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(dynamicToGetPropertiesFor))
            {
                object obj = propertyDescriptor.GetValue(dynamicToGetPropertiesFor);
                dictionary.Add(propertyDescriptor.Name, obj);
            }

            List<string> toReturn = new List<string>();
            foreach (string key in dictionary.Keys)
            {
                toReturn.Add(key);
            }
            return toReturn;
        }


        public static dynamic getType(Type t, dynamic value)
        {
            dynamic _value = null;

            if (t.Equals(typeof(int)))
            {
                try
                {
                    _value = int.Parse(value.ToString());
                }
                catch { _value = null; }
            }
            else if (t.Equals(typeof(double)))
            {
                try
                {
                    _value = double.Parse(value.ToString());
                }
                catch { _value = null; }
            }
            else if (t.Equals(typeof(string)))
            {
                try
                {
                    _value = value.ToString();
                }
                catch { _value = null; }
            }
            else if (t.Equals(typeof(bool)))
            {
                try
                {
                    _value = bool.Parse(value.ToString());
                }
                catch { _value = null; }
            }
            else if (t.Equals(typeof(DateTime)))
            {
                try
                {
                    _value = DateTime.Parse(value.ToString());
                }
                catch { _value = null; }
            }
            else if (t.Name.Equals("Nullable`1"))
            {
                _value = getType(t.GenericTypeArguments[0], value);
            }

            return _value;
        }



        public static string GetCurrentUser(string authorizationString)
        {
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(authorizationString);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(new[] { ':' }, 2);
                return credentials[0];
            }
            catch
            {
                return "Not Defined";
            }
        }

        internal static SUsuario GetUserByUserName(string username, WMS_LIGERO_LIVEContext _db)
        {
            if (_db == null)
                _db = new WMS_LIGERO_LIVEContext();

            try
            {
                //Si esta a nivel del site
                return _db.SUsuarios.Where(f => f.NombreUsuario == username).First();
            }
            catch
            {
                return new SUsuario { };
            }
        }


        internal static V2MasterConfig CONFIG_GetRecord(string config_code, string site, WMS_LIGERO_LIVEContext _db)
        {
            List<V2MasterConfig> configList = _db.V2MasterConfigs
                .Where(f => f.SetupCode == config_code)
                .Where(f => f.Site == site || f.Site == null).ToList();

            //Si esta a nivel del site
            if (configList.Any(f => f.Site == site))
                return configList.FirstOrDefault(f => f.Site == site);

            //Devuelve el que encuentre o NULL
            return configList.FirstOrDefault();

        }

        internal static string CONFIG_GetParam(string config_code, string site, WMS_LIGERO_LIVEContext _db)
        {
            if (_db == null)
                _db = new WMS_LIGERO_LIVEContext();

            List<V2MasterConfig> configList = _db.V2MasterConfigs
                .Where(f => f.SetupCode == config_code)
                .Where(f => f.Site == site || f.Site == null).ToList();

            try
            {
                //Si esta a nivel del site
                if (configList.Any(f => f.Site == site))
                    return configList.First(f => f.Site == site).Value;

                //Devuelve el que encuentre o NULL
                return configList.First().Value;
            }
            catch
            {
                return "";
            }
        }

        internal static string GetParameter(string code, WMS_LIGERO_LIVEContext _db = null)
        {
            try
            {

                if (_db == null)
                    _db = new WMS_LIGERO_LIVEContext();

                SParametro parameter = _db.SParametros.Where(f => f.CodParametro == code).FirstOrDefault();

                return parameter.ValorParametro;
            }
            catch
            {
                return "";
            }
        }


        internal static object[] ERP_GetConnection(string connection_code, string site, WMS_LIGERO_LIVEContext _db)
        {
            V2MasterConfig erpConfig = UtilTool.CONFIG_GetRecord(connection_code, site, _db);

            if (erpConfig == null)
                throw new Exception(UtilTool.getLangInfo("CONFIG_NOT_DEFINED") + " " + connection_code);

            //Obtains the connection based on Customer Setup
            V2MasterConnection erpConnection = _db.V2MasterConnections.FirstOrDefault(f => f.Rowid.ToString() == erpConfig.Value);

            if (erpConnection == null)
                throw new Exception(UtilTool.getLangInfo("CONNECTION_NOT_DEFINED_FOR") + " " + connection_code);

            return new object[] { erpConfig, erpConnection };
        }


        internal static string getLangInfo(string word_code)
        {
            return word_code;
        }

        public static dynamic GetDynamicFromJSON(string jsonString)
        {
            return JsonConvert.DeserializeObject<dynamic>(jsonString);

        }

        public static string ReplaceTempleteList(string templete, List<string[]> list)
        {
            string tmpTemplate = templete;

            foreach (string[] arr in list)
            {
                tmpTemplate = tmpTemplate.Replace(arr[0], arr[1]);
            }

            return tmpTemplate;
        }


        public static string CallSoap(string xml, string url, string method, bool useEnvelope = true)
        {

            string _soapEnvelope =
                              @"<soap:Envelope
                                xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'
                                xmlns:xsd='http://www.w3.org/2001/XMLSchema'
                                xmlns:soap='http://schemas.xmlsoap.org/soap/envelope/'>
                            <soap:Body></soap:Body></soap:Envelope>";

            //Create the request
            HttpWebRequest req = CreateWebRequest(url, method);

            WebResponse response = null;
            string strResponse = "";

            //write the soap envelope to request stream
            using (Stream stm = req.GetRequestStream())
            {
                using (StreamWriter stmw = new StreamWriter(stm))
                {
                    stmw.Write(CreateSoapEnvelope(xml, method, _soapEnvelope, useEnvelope));
                }
            }

            //get the response from the web service
            response = req.GetResponse();
            Stream str = response.GetResponseStream();
            StreamReader sr = new StreamReader(str);
            strResponse = sr.ReadToEnd();

            //strResponse = UtilTool.RemoveSpecialCharsForXML(strResponse);
            //DataSet ds = UtilTool.GetDataSetFromXMLString(strResponse);

            strResponse = RemoveInvalidXmlChars(strResponse);

            return strResponse;
        }

        public static string RemoveInvalidXmlChars(string content)
        {
            return new string(content.Where(ch => XmlConvert.IsXmlChar(ch)).ToArray());
        }
        private static string CreateSoapEnvelope(string _parameters, string _method, string _soapEnvelope, bool useEnvelope = true)
        {
            string MethodCall = "<" + _method + @" xmlns=""http://tempuri.org/"">";

            MethodCall = MethodCall + _parameters + "</" + _method + ">";

            StringBuilder sb = new StringBuilder(_soapEnvelope);

            sb.Insert(sb.ToString().IndexOf("</soap:Body>"), MethodCall);

            if (useEnvelope)
                return sb.ToString();
            else
                return _parameters;
        }


        private static HttpWebRequest CreateWebRequest(string _url, string _method)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(_url);
            webRequest.Headers.Add("SOAPAction", "\"http://tempuri.org/" + _method + "\"");
            webRequest.Headers.Add("To", _url);
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        public static string ReplaceTildes(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder(capacity: normalizedString.Length);

            for (int i = 0; i < normalizedString.Length; i++)
            {
                char c = normalizedString[i];
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder
                .ToString()
                .Normalize(NormalizationForm.FormC);
        }

    }

    public static class Constantes
    {
        public const string CryptString = "JAMURCO";
        public const string SAPB1 = "SAPB1";
        public const string SIESA = "SIESA";

        //TRANSPORTADORAS
        public const string TRANSPRENSA = "TRANSPRENSA";
        public const string TCC = "TCC";
        public const string COORDINADORA = "COORDINADORA";
        public const string DEPRISA = "DEPRISA";

    }

    public class Mail_Tpl_Obj
    {
        public string MESSAGE { get; set; }

        public string SUBJECT { get; set; }
    }


}
