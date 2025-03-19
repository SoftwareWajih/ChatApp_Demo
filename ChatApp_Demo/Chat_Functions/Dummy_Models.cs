namespace ChatApp_Demo.Chat_Functions
{
    public class Dummy_Posts
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; } = null!;
        public string body { get; set; } = null!;
    }

    public class Dummy_Exchange_Rate
    {
        public string? result { get; set; }
        public string? documentation { get; set; }
        public string? terms_of_use { get; set; }
        public int time_last_update_unix { get; set; }
        public string? time_last_update_utc { get; set; }
        public int time_next_update_unix { get; set; }
        public string? time_next_update_utc { get; set; }
        public string? base_code { get; set; }
        public string? target_code { get; set; }
        public double conversion_rate { get; set; }
    }

}