﻿using System;

namespace docAPI.Models.Projections
{
    public class TweetProjection
    {
        public string UserName { get; set; }

        public string ScreenName { get; set; }

        public string ProfileImageUrl { get; set; }

        public string Text { get; set; }

        public DateTime CreatedAt { get; set; }

        public int RetweetCount { get; set; }
    }
}