using System;

namespace Workspace.Entities.Exceptions;

public class DomainException : ApplicationException
{
    public DomainException(string message) : base(message) { }
}
