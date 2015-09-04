using MyMovieApp.Models.Abstract;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Script.Serialization;

namespace MyMovieApp.Models.Webservice
{
    public class MovieWebservice : IMovieWebservice
    {
        public Movie GetMovieInfo(string title)
        {
            var json = String.Empty;

            String requestUriString = String.Format("https://www.omdbapi.com/?t={0}&plot=full&r=json", title);
            var request = (HttpWebRequest)WebRequest.Create(requestUriString);

            using (var response = request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    json = reader.ReadToEnd();
                }
            }

            return JsonConvert.DeserializeObject<Movie>(json);
        }
    }
}