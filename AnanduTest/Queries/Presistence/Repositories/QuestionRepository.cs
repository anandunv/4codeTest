using Queries.Core.Domain;
using Queries.Core.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Queries.Presistence.Repositories
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public DataContext dataContext { get { return Context as DataContext; } }

        public QuestionRepository(DataContext context):base(context)
        {

        }

        public List<Question> GetSatckQuestionsFormApi(out bool executestatus, out string executemessage)
        {
            executestatus = true;
            executemessage = "";
            try
            {
                // Http Client not woring with stack api

                //HttpClient client = new HttpClient();
                //client.BaseAddress = new Uri("https://api.stackexchange.com/");

                //// Add an Accept header for JSON format.
                //client.DefaultRequestHeaders.Accept.Add(
                //    new MediaTypeWithQualityHeaderValue("application/json"));


                //HttpResponseMessage response = client.GetAsync("2.2/questions?page=1&pagesize=50&order=desc&sort=creation&site=stackoverflow").Result;

                //if (response.IsSuccessStatusCode)
                //{
                //    //var jss = new JavaScriptSerializer();

                //    var us = response.Content.ReadAsStringAsync().Result;
                //    var ss = Newtonsoft.Json.JsonConvert.DeserializeObject(us);
                //}

                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.stackexchange.com/2.2/questions?page=1&pagesize=50&order=desc&sort=creation&site=stackoverflow");
                httpWebRequest.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                httpWebRequest.Method = "GET";
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string responseText;
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    responseText = streamReader.ReadToEnd();
                }

                var result = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchResult>(responseText);

                return result.items;
            }
            catch(Exception ex)
            {
                executestatus = false;
                executemessage = ex.ToString();
                return null;
            }
        }


    }

    class SearchResult
    {
        public List<Question> items { get; set; }
    }
}
