using System;
using System.Collections.Generic;
using System.Text;

namespace JokeApp.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class DadJoke
    {
        public string id { get; set; }
        public string joke { get; set; }
        public int status { get; set; }
    }


}
