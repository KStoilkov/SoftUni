namespace _04.GenericListVersion
{
    ﻿using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface |
    AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = true)]

    public class VersionAttribute : Attribute
    {
        public string Version { get; set; }

        public int Major { get; private set; }
        public int Minor { get; private set; }

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
            this.Version = this.Major + "." + this.Minor;
        }
    }
}
