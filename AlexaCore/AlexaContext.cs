﻿using System.Runtime.CompilerServices;
using Autofac;

[assembly: InternalsVisibleTo("AlexaCore.Testing")]
namespace AlexaCore
{
    public class AlexaContext
    {
        public static IContainer Container { get; private set; }

        public AlexaContext(IContainer container)
		{
		    Container = container;
		}
    }
}
