namespace SearchingOMDB.Models
{
        public class Rootobject
        {
            public int page { get; set; }
            public object next { get; set; }
            public int entries { get; set; }
            public Result[] results { get; set; }
        }

        public class Result
        {
            public string _id { get; set; }
            public string id { get; set; }
            public Primaryimage primaryImage { get; set; }
            public Titletype titleType { get; set; }
            public Titletext titleText { get; set; }
            public Originaltitletext originalTitleText { get; set; }
            public Releaseyear releaseYear { get; set; }
            public Releasedate releaseDate { get; set; }
        }

        public class Primaryimage
        {
            public string id { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string url { get; set; }
            public Caption caption { get; set; }
            public string __typename { get; set; }
        }

        public class Caption
        {
            public string plainText { get; set; }
            public string __typename { get; set; }
        }

        public class Titletype
        {
            public string text { get; set; }
            public string id { get; set; }
            public bool isSeries { get; set; }
            public bool isEpisode { get; set; }
            public string __typename { get; set; }
            public Category[] categories { get; set; }
            public bool canHaveEpisodes { get; set; }
        }

        public class Category
        {
            public string value { get; set; }
            public string __typename { get; set; }
        }

        public class Titletext
        {
            public string text { get; set; }
            public string __typename { get; set; }
        }

        public class Originaltitletext
        {
            public string text { get; set; }
            public string __typename { get; set; }
        }

        public class Releaseyear
        {
            public int year { get; set; }
            public object endYear { get; set; }
            public string __typename { get; set; }
        }

    public class Releasedate
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public string __typename { get; set; }
    }



}
