﻿using docAPI.Models.Projections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace docAPI.Repository.Contracts
{
    public interface ITweetService
    {
        Task<List<TweetProjection>> GetTweets();

        Task<List<TweetProjection>> UpdateTweets(List<TweetProjection> tweets);
    }
}