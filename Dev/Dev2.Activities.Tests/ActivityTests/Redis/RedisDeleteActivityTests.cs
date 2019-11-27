﻿/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2018 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using System;
using System.Collections.Generic;
using Dev2.Activities.RedisDelete;
using Dev2.Data.ServiceModel;
using Dev2.Runtime.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Warewolf.Storage;
using Warewolf.Storage.Interfaces;

namespace Dev2.Tests.Activities.ActivityTests.Redis
{
    [TestClass]
    public class RedisDeleteActivityTests : BaseActivityTests
    {
        static RedisDeleteActivity CreateRedisDeleteActivity()
        {
            return new RedisDeleteActivity();
        }
        static IExecutionEnvironment CreateExecutionEnvironment()
        {
            return new ExecutionEnvironment();
        }
       
        [TestMethod]
        [Owner("Candice Daniel")]
        [TestCategory(nameof(RedisDeleteActivity))]
        public void RedisDeleteActivity_Equal_BothareObjects()
        {
            object redisDeleteActivity = CreateRedisDeleteActivity();
            var other = new object();
            var redisActivityEqual = redisDeleteActivity.Equals(other);
            Assert.IsFalse(redisActivityEqual);
        }

        [TestMethod]
        [Owner("Candice Daniel")]
        [TestCategory(nameof(RedisDeleteActivity))]
        public void RedisDeleteActivity_GivenEnvironmentIsNull_ShouldHaveNoDebugOutputs()
        {
            //---------------Set up test pack-------------------
            var redisDeleteActivity = CreateRedisDeleteActivity();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var debugInputs = redisDeleteActivity.GetDebugInputs(null, 0);
            //---------------Test Result -----------------------
            Assert.AreEqual(0, debugInputs.Count);
        }
      
    }
}