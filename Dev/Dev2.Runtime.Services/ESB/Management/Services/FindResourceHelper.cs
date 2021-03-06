#pragma warning disable
/*
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
using System.Linq;
using Dev2.Common;
using Dev2.Common.Interfaces.Data;
using Dev2.Data.ServiceModel;
using Dev2.Providers.Errors;
using Dev2.Runtime.Security;
using Dev2.Services.Security;

namespace Dev2.Runtime.ESB.Management.Services
{
    public class FindResourceHelper
    {
        IAuthorizationService _authorizationService;

        public SerializableResource SerializeResourceForStudio(IResource resource,Guid workspaceID)
        {
            var errors = new List<ErrorInfo>();
            var parseErrors = resource.Errors;
            if(parseErrors != null)
            {
                errors.AddRange(parseErrors.Select(error => error as ErrorInfo));
            }

            var datalist = "<DataList></DataList>";

            if(resource.DataList != null)
            {
                var replace = resource.DataList.Replace("\"", GlobalConstants.SerializableResourceQuote);
                datalist = replace.Replace("'", GlobalConstants.SerializableResourceSingleQuote).ToString();
            }

            return new SerializableResource
            {
                Inputs = resource.Inputs,
                Outputs = resource.Outputs,
                ResourceID = resource.ResourceID,
                VersionInfo = resource.VersionInfo,
                ResourceName = resource.ResourceName,
                IsSource = resource.IsSource,
                IsServer = resource.IsServer,
                IsService = resource.IsService,
                ResourceCategory = resource.GetResourcePath(workspaceID),
                IsReservedService = resource.IsReservedService,
                IsResourceVersion = resource.IsResourceVersion,
                IsFolder = resource.IsFolder,
                Permissions = AuthorizationService.GetResourcePermissions(resource.ResourceID),
                ResourceType = resource.ResourceType,
                IsValid = resource.IsValid,
                DataList = datalist,
                Errors = errors,
                IsNewResource = resource.IsNewResource
            };
        }

        IAuthorizationService AuthorizationService => _authorizationService ?? (_authorizationService = ServerAuthorizationService.Instance);
    }
}
