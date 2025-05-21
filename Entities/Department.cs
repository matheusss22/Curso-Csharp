using System;

namespace Workspace.Entities;

public class Department
{
    public string Name { get; set; }

    public Department()
    {

    }

    public Department(string name)
    {
        Name = name;
    }
}
