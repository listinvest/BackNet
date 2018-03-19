﻿using System.Collections.Generic;
using Shared;

namespace Server.Commands
{
    internal class StopConnection : ICommand
    {
        public string name { get; } = "stopconnection";


        public void Process(List<string> args) => throw new ExitException();
    }
}