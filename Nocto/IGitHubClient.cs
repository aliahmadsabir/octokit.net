﻿using Nocto.Http;

namespace Nocto
{
    public interface IGitHubClient
    {
        IConnection Connection { get; }
        AuthenticationType AuthenticationType  { get; }
    }
}