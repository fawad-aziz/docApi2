﻿using System;

namespace docAPI.Models.Entities
{
    public class Tweet
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string ScreenName { get; set; }

        public string ProfileImageUrl { get; set; }

        public string Text { get; set; }

        public int RetweetCount { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsCurrent { get; set; }
    }
}