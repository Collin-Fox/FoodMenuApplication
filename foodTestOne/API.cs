using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using foodTestOne;
using Newtonsoft.Json;

namespace FoodMenuApplication
{
    internal class API
    {
        public string getMethod(food newFood)
        {
            using(var client = new HttpClient())
            {
                var foodJson = JsonConvert.SerializeObject(newFood);
                var endpoint = new Uri("https://7157-108-214-189-156.ngrok-free.app/api/v1/food");
                var payload = new StringContent(foodJson, Encoding.UTF8, "application/json");
                var result = client.PostAsync(endpoint, payload).Result.Content.ReadAsStringAsync().Result;

                return (string)foodJson;
            }

           
        }

    }
}
