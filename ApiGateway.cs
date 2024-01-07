using CrudApiClient.Models;
using System.Security.Policy;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.Net.Http.Headers;

namespace CrudApiClient
{
    public class ApiGateway
    {
        private string url = "https://localhost:7109/api/Thought";
        private HttpClient httpClient = new HttpClient();
        //private string baseUrl;

        public List<Thought> ListThought()
        {
              List<Thought> thoughts = new List<Thought>();
                if(url.Trim().Substring(0,5).ToLower()== "https")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                HttpResponseMessage res = httpClient.GetAsync(url).Result;
                if (res.IsSuccessStatusCode)
                {
                    string result = res.Content.ReadAsStringAsync().Result;
                    var datacol = JsonConvert.DeserializeObject<List<Thought>>(result);
                    if (datacol != null)
                        thoughts = datacol;
                }
                else
                {
                    string result = res.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error Occured at API Endpoint, Error Info " + result);
                }
            }
                catch (Exception ex)
                {
                     throw new Exception("Error Occured at API Endpoint, Error Info " + ex.Message);
                }
                finally { httpClient.Dispose(); }
                return thoughts;
            }
        public void Dispose()
        {             
            httpClient.Dispose();
        }

        public Thought CreateThought(Thought thought)
        {
            if (url.Trim().Substring(0, 5).ToLower() == "https")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string json = JsonConvert.SerializeObject(thought);
            try
            {
                HttpResponseMessage res = httpClient.PostAsync(url, new StringContent(json, Encoding.UTF8, "application/json")).Result;
                if (res.IsSuccessStatusCode)
                {
                    string result = res.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<Thought>(result);
                    if (data != null)
                        thought = data;
                }
                else
                {
                    string result = res.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error Occured at API Endpoint, Error Info " + result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured at API Endpoint, Error Info " + ex.Message);
            }
            finally { httpClient.Dispose(); }
            return thought;
        }
       
        public Thought GetThought(int id)
        {
            Thought thought = new Thought();
            url = url + "/" + id;
            if (url.Trim().Substring(0, 5).ToLower() == "https")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                HttpResponseMessage res = httpClient.GetAsync(url).Result;
                if (res.IsSuccessStatusCode)
                {
                    string result = res.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<Thought>(result);
                    if (data != null)
                        thought = data;
                }
                else
                {
                    string result = res.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error Occured at API Endpoint, Error Info " + result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured at API Endpoint, Error Info " + ex.Message);
            }
            finally { httpClient.Dispose(); }
            return thought;
        }

        public void UpdateThought(Thought thought)
        {
            if(url.Trim().Substring(0, 5).ToLower() != "https")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            int id = thought.id;
            url = url + "/" + id;
            string json = JsonConvert.SerializeObject(thought);
            try
            {
                HttpResponseMessage res = httpClient.PutAsync(url, new StringContent(json, Encoding.UTF8, "application/json")).Result;
                if (!res.IsSuccessStatusCode)
                {
                    string result = res.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error Occured at API Endpoint, Error Info " + result);
                }
            }        
            
            catch (Exception ex)
            {
                throw new Exception("Error Occured at API Endpoint, Error Info " + ex.Message);
            }
            finally { httpClient.Dispose(); }
            return;
        }
        public void DeleteThought(int id)
        {
            if (url.Trim().Substring(0, 5).ToLower() != "https")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;            
            url = url + "/" + id;
            try
            {
                HttpResponseMessage res = httpClient.DeleteAsync(url).Result;
                if (!res.IsSuccessStatusCode)
                {
                    string result = res.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error Occured at API Endpoint, Error Info " + result);
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Error Occured at API Endpoint, Error Info " + ex.Message);
            }
            finally { httpClient.Dispose(); }
            return;
        }

        //public List<Thought> SearchThoughts(string searchTerm)
        //{
        //    List<Thought> thoughts = new List<Thought>();
        //    string searchUrl = $"{url}/search?term={WebUtility.UrlEncode(searchTerm)}";

        //    if (searchUrl.Trim().Substring(0, 5).ToLower() == "https")
        //        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

        //    try
        //    {
        //        HttpResponseMessage res = httpClient.GetAsync(searchUrl).Result;
        //        if (res.IsSuccessStatusCode)
        //        {
        //            string result = res.Content.ReadAsStringAsync().Result;
        //            var datacol = JsonConvert.DeserializeObject<List<Thought>>(result);
        //            if (datacol != null)
        //                thoughts = datacol;
        //        }
        //        else
        //        {
        //            string result = res.Content.ReadAsStringAsync().Result;
        //            throw new Exception("Error Occurred at API Endpoint, Error Info " + result);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error Occurred at API Endpoint, Error Info " + ex.Message);
        //    }
        //    finally
        //    {
        //        httpClient.Dispose();
        //    }

        //    return thoughts;
        //}

    //    public Thought GetRandomThought()
    //    {
    //        try
    //        {
    //            using (HttpClient client = new HttpClient())
    //            {
    //                client.BaseAddress = new Uri(url);
    //                client.DefaultRequestHeaders.Accept.Clear();
    //                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

    //                HttpResponseMessage response = client.GetAsync("random").Result;

    //                if (response.IsSuccessStatusCode)
    //                {
    //                    string result = response.Content.ReadAsStringAsync().Result;
    //                    Thought randomThought = JsonConvert.DeserializeObject<Thought>(result);
    //                    return randomThought;
    //                }
    //                else
    //                {
    //                    // Handle error response
    //                    throw new Exception($"Error: {response.StatusCode}");
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("Error occurred while getting a random thought", ex);
    //        }
    //}

    }
}

 
       


