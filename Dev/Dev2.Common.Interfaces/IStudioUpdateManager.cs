#pragma warning disable
/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2020 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later.
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using System;
using Dev2.Common.Interfaces.DB;
using Dev2.Common.Interfaces.ServerProxyLayer;
using Dev2.Common.Interfaces.ToolBase.ExchangeEmail;
using Dev2.Common.Interfaces.WebServices;
using System.Collections.Generic;
using System.Data;
using Dev2.Common.Interfaces.Deploy;

namespace Dev2.Common.Interfaces
{
    public interface IStudioUpdateManagerSave
    {
        void Save(IServerSource serverSource);
        void Save(IDbSource toDbSource);
        void Save(IWebServiceSource model);
        void Save(IRedisServiceSource redisServiceSource);
        void Save(IElasticsearchSourceDefinition elasticsearchServiceSource);
        void Save(IPluginSource source);
        void Save(IComPluginSource source);
        void Save(IEmailServiceSource emailServiceSource);
        void Save(IExchangeSource emailServiceSource);
        void Save(ISharepointServerSource sharePointServiceSource);
        void Save(IRabbitMQServiceSourceDefinition rabbitMqServiceSource);
        void Save(IWcfServerSource wcfSource);        
        void Save(IOAuthSource sharePointServiceSource);
    }

    public interface IStudioUpdateManagerTest
    {
        void TestConnection(IServerSource serverSource);
        void TestConnection(IWebServiceSource serverSource);
        void TestConnection(IRedisServiceSource redisServiceSource);
        string TestConnection(IElasticsearchSourceDefinition elasticsearchServiceSource);
        void TestConnection(ISharepointServerSource sharePointServiceSource);
        string TestConnection(IEmailServiceSource emailServiceSource);
        string TestConnection(IExchangeSource emailServiceSource);
        string TestConnection(IRabbitMQServiceSourceDefinition rabbitMqServiceSource);
        IList<string> TestDbConnection(IDbSource serverSource);
		IList<string> TestSqliteConnection(ISqliteDBSource serverSource);
		DataTable TestDbService(IDatabaseService inputValues);
        string TestWebService(IWebService inputValues);
        string TestPluginService(IPluginService inputValues);
        string TestPluginService(IComPluginService inputValues);
        string TestWcfService(IWcfService inputValues);
    }

    public interface IStudioUpdateManager : IStudioUpdateManagerSave, IStudioUpdateManagerTest
    {
        string TestConnection(IWcfServerSource wcfServerSource);
        Action<Guid, bool> ServerSaved { get; set; }
        void FireServerSaved(Guid savedServerID);
        void FireServerSaved(Guid savedServerID, bool isDeleted);

        List<IDeployResult> Deploy(List<Guid> resourceIDsToDeploy, bool deployTests, bool deployTriggers, IConnection destinationEnvironment);
    }

    public delegate void ItemSaved(bool refresh);

    public delegate void ServerSaved();
}