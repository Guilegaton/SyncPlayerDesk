﻿using Newtonsoft.Json;
using SyncPlayer.Interfaces;
using System;
using System.IO;
using System.Net;

namespace SyncPlayer.Helpers
{
    internal class HttpHelper : IHttpHelper
    {
        #region Public Methods

        public TAnswer Request<TAnswer, TModel>(TModel bodyObject, string requestUrl, string barearToken = "", string requestMethod = "POST", string contentType = "application/json", string encoding = "UTF-8")
            where TAnswer : class
            where TModel : class
        {
            TAnswer result = default;
            string json = bodyObject != null ? JsonConvert.SerializeObject(bodyObject) : string.Empty;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUrl);
            httpWebRequest.ContentType = contentType;
            httpWebRequest.Method = requestMethod;
            httpWebRequest.Headers.Add(HttpRequestHeader.ContentEncoding, encoding);
            httpWebRequest.Headers.Add("Authorization", "Basic " + barearToken);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                if (streamReader.Peek() > -1)
                    result = typeof(TAnswer) != typeof(string) ? JsonConvert.DeserializeObject<TAnswer>(streamReader.ReadToEnd()) : (TAnswer)Convert.ChangeType(streamReader.ReadToEnd(), typeof(string));
            }

            return result;
        }

        public bool Request<TModel>(TModel bodyObject, string requestUrl, string barearToken = "", string requestMethod = "POST", string contentType = "application/json", string encoding = "UTF-8") where TModel : class
        {
            string json = bodyObject != null ? JsonConvert.SerializeObject(bodyObject) : string.Empty;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUrl);
            httpWebRequest.ContentType = contentType;
            httpWebRequest.Method = requestMethod;
            httpWebRequest.Headers.Add(HttpRequestHeader.ContentEncoding, encoding);
            httpWebRequest.Headers.Add("Authorization", "Bearer " + barearToken);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            return httpResponse.StatusCode == HttpStatusCode.OK;
        }

        #endregion Public Methods
    }
}