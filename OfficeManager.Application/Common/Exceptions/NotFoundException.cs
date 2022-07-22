﻿namespace OfficeManager.Application.Common.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException() : base() {}

        public NotFoundException(string message) : base(message) {}

        public NotFoundException(string message, Exception innerException) : base(message, innerException) {}

        public NotFoundException(string Name, object key)
            : base($"Entity \"{Name}\" ({key}) was not found")
        { }
    }
}
