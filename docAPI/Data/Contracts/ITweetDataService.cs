using docAPI.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace docAPI.Data.Contracts
{
    public interface ITweetDataService
    {
        Task<List<Tweet>> GetCurrentTweets();

        Task<List<Tweet>> UpdateTweets(List<Tweet> tweets);
    }
}