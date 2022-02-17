﻿namespace ambient_common.Models
{
    public class ErrorMessage : BaseModel
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public bool Read { get; set; } = false;
    }
}