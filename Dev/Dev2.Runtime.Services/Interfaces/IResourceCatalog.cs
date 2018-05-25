using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using Dev2.Common.Interfaces.Data;
using Dev2.Runtime.Hosting;
using Warewolf.ResourceManagement;

namespace Dev2.Runtime.Interfaces
{
    public interface IResourceCatalog :
          IResourceWorkspaceProvider
        , IResourceSyncProvider
        , IResourceRenameProvider
        , IResourceDeleteProvider
        , IResourceLoadProvider
        , IResourceSaveProvider
        , IResourceDuplicateProvider

    {
        void AddToActivityCache(IResource resource);
        ConcurrentDictionary<Guid, List<IResource>> WorkspaceResources { get; }
        IDev2Activity Parse(Guid workspaceID, Guid resourceID);
        IDev2Activity Parse(Guid workspaceID, Guid resourceID, string executionId);
        void CleanUpOldVersionControlStructure();
        IResourceActivityCache GetResourceActivityCache(Guid workspaceID);
        void RemoveFromResourceActivityCache(Guid workspaceID, IResource resource);
        string SetResourceFilePath(Guid workspaceID, IResource resource, ref string savedPath);
        ResourceCatalogResult SaveImpl(Guid workspaceID, IResource resource, StringBuilder contents);
        ResourceCatalogResult SaveImpl(Guid workspaceID, IResource resource, StringBuilder contents, string savedPath);
        ResourceCatalogResult SaveImpl(Guid workspaceID, IResource resource, StringBuilder contents, string savedPath, string reason);
    }
}