﻿using System;

namespace Avalon.Common.Attributes
{
    /// <summary>
    /// A Lua attribute that can be put onto a string property to denote it as Lua code.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class LuaAttribute : Attribute
    {
    }
}
