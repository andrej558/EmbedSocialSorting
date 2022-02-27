using Newtonsoft.Json;
using WebApplication1.Models;

namespace WebApplication1.Helpers
{
    public class ReaderJson
    {


        public List<Review> GetData(string path)
        {

            var jsonData = System.IO.File.ReadAllText(path);


            var reviews = JsonConvert.DeserializeObject<List<Review>>(jsonData);

            return reviews;

        }

    }
}
