using RestSharp;


namespace SearchingOMDB.Models
{
    public static class MovieDAL
    {
        public static string myKey = "4138b92c40msh040bf536271f01dp1c4ec1jsned777caa2841";

        public static string baseURL = @"https://moviesdatabase.p.rapidapi.com/titles/";

        public static Rootobject GetMatchingMovies(string titleToSearch)
        {
            string endpoint = $@"search/title/{ titleToSearch }?exact=true&titleType=movie";

            RestClient client = new RestClient(baseURL + endpoint);
            RestRequest request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", $"{ myKey }");
            request.AddHeader("X-RapidAPI-Host", "moviesdatabase.p.rapidapi.com");
            
            Rootobject response = client.Get<Rootobject>(request);
            
            return response;

        }

    }

}
