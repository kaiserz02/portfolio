﻿namespace kbdesilva.Models
{
    public class Project
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string[] Technologies { get; set; } = [];
        public string? Url { get; set; }
    }
}
