﻿using System.ComponentModel.DataAnnotations;

namespace CrudApi
{
    public class Thought
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Text { get; set; } = "";
    }
}
