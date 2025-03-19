namespace ChatApp_Demo.Chat_Functions
{

    #region Interfaces
    public interface IDummy_Services
    {
        Task<List<Dummy_Posts>> GetDummyPosts(string postTitle);
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

        public async Task<List<Dummy_Posts>> GetDummyPosts(string postTitle)
        {
            var response = await _httpClient.GetFromJsonAsync<List<Dummy_Posts>>("https://jsonplaceholder.typicode.com/posts");
            var filteredPosts = response?.Where(post => post.title.Contains(postTitle, StringComparison.OrdinalIgnoreCase)).ToList();
            return filteredPosts ?? new List<Dummy_Posts>();
        }
    }
    #endregion

}