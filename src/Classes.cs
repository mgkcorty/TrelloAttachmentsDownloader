namespace TrelloAttachmentsDownloader
{
    public class RootCard
    {
        public string name { get; set; }
        public Action[] actions { get; set; }
    }

    public class Action
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public Attachment attachment { get; set; }
    }

    public class Attachment
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }
}
