﻿namespace WebBlog.Specifications.TransferObjects
{
    internal class ValidationError
    {
        public string Message { get; set; }

        public ValidationError(string message)
        {
            Message = message;
        }
    }
}
