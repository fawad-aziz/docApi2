using docAPI.Data.Contracts;
using docAPI.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace docAPI.Data.Concrete
{
    public class InMemoryTweetDataService : ITweetDataService
    {
        private List<Tweet> tweetList = new List<Tweet>();

        public Task<List<Tweet>> GetCurrentTweets()
        {
            return Task.FromResult(tweetList);
        }

        public Task<List<Tweet>> UpdateTweets(List<Tweet> tweets)
        {
            if (tweets.Count > 0)
            {
                tweetList = tweets;
            }

            return Task.FromResult(tweetList);
        }
    }
}