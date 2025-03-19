namespace ChatApp_Demo.Chat_Functions
{

    #region Interfaces
    public interface IDummy_Services
    {
        Task<List<Dummy_Posts>> Get_Dummy_Posts(string postTitle);
        Task<Dummy_Exchange_Rate> Get_Exchange_Rate(string exchangeRate);
    }
    #endregion

    #region Services
    public class Dummy_Services : IDummy_Services
    {
        private readonly HttpClient _httpClient;

        public Dummy_Services(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Dummy_Posts>> Get_Dummy_Posts(string postTitle)
        {
            var response = await _httpClient.GetFromJsonAsync<List<Dummy_Posts>>("https://jsonplaceholder.typicode.com/posts");
            var filteredPosts = response?.Where(post => post.title.Contains(postTitle, StringComparison.OrdinalIgnoreCase)).ToList();
            return filteredPosts ?? new List<Dummy_Posts>();
        }

        public async Task<Dummy_Exchange_Rate> Get_Exchange_Rate(string exchangeRate)
        {
            var response = await _httpClient.GetFromJsonAsync<Dummy_Exchange_Rate>($"https://v6.exchangerate-api.com/v6/b62152c24014e1d33697afc5/pair/{exchangeRate}");
            return response ?? new Dummy_Exchange_Rate();
        }
    }
    #endregion

}   