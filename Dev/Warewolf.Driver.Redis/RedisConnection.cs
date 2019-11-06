﻿/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2019 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using System;
using System.Collections.Generic;
using ServiceStack.Redis;
using Warewolf.Interfaces;

namespace Warewolf.Driver.Redis
{
    public class RedisConnection : IRedisConnection
    {
        public RedisConnection(string hostName)
        {
            IRedisClient client = new RedisClient(hostName);
            Cache = new RedisCache(client);
        }

        public IRedisCache Cache { get; private set; }
    }

    internal class RedisCache : IRedisCache
    {
        private readonly IRedisClient _client;
        public RedisCache(IRedisClient client)
        {
            _client = client;
        }

        public IDictionary<string, string> Get(string key) => _client.Get<IDictionary<string, string>>(key);

        public bool Set(string key, IDictionary<string, string> value, TimeSpan timeSpan) => _client.Set(key, value, timeSpan);
    }
}