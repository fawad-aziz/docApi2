using docAPI.Data.Contracts;
using docAPI.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace docAPI.Data.Concrete
{
    public class TweetDataService : ITweetDataService
    {
        public Task<List<Tweet>> GetCurrentTweets() => Task.FromResult(new List<Tweet>());

        public Task<List<Tweet>> UpdateTweets(List<Tweet> tweets) => Task.FromResult((new List<Tweet>()));
    }
}