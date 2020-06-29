﻿/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2020 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later.
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using System;
using Newtonsoft.Json;
using Warewolf.Data;

namespace Warewolf.Configuration
{
    public class ServerSettingsData : BindableBase, IEquatable<ServerSettingsData>, IHasChanged
    {
        public ServerSettingsData()
        {
            PropertyChanged += (sender, args) => HasChanged = true;
        }

        public ushort? WebServerPort { get; set; }
        public ushort? WebServerSslPort { get; set; }
        public string SslCertificateName { get; set; }
        public bool? CollectUsageStats { get; set; }
        public int? DaysToKeepTempFiles { get; set; }

        private string _auditFilePath;
        [Obsolete("AuditFilePath is deprecated. It will be deleted in future releases.")]
        public string AuditFilePath
        {
            get => _auditFilePath;
            set => SetProperty(ref _auditFilePath, value);
        }

        public bool? EnableDetailedLogging { get; set; }
        public string Sink { get; set; }
        public string ExecutionLogLevel{ get; set; }
        public int? LogFlushInterval { get; set; }

        [JsonIgnore]
        public bool HasChanged { get; set; }

        public bool Equals(ServerSettingsData other)
        {
            if (other is null)
            {
                return false;
            }
            var equals = WebServerPort == other.WebServerPort;
            equals &= WebServerSslPort == other.WebServerSslPort;
            equals &= string.Equals(SslCertificateName, other.SslCertificateName, StringComparison.InvariantCultureIgnoreCase);
            equals &= CollectUsageStats == other.CollectUsageStats;
            equals &= DaysToKeepTempFiles == other.DaysToKeepTempFiles;
            equals &= EnableDetailedLogging == other.EnableDetailedLogging;
            equals &= ExecutionLogLevel == other.ExecutionLogLevel;
            equals &= LogFlushInterval == other.LogFlushInterval;
            equals &= AuditFilePath == other.AuditFilePath;
            equals &= Sink == other.Sink;
            return equals;
        }

        public override bool Equals(object other)
        {
            if (other is ServerSettingsData settingsData)
            {
                return Equals(settingsData);
            }
            return false;
        }

        public override int GetHashCode()
        {
            var result = 0;
            result += (result * 397) ^ (WebServerPort?.GetHashCode() ?? 0);
            result += (result * 397) ^ (WebServerSslPort?.GetHashCode() ?? 0);
            result += (result * 397) ^ (SslCertificateName?.GetHashCode() ?? 0);
            result += (result * 397) ^ (CollectUsageStats?.GetHashCode() ?? 0);
            result += (result * 397) ^ (DaysToKeepTempFiles?.GetHashCode() ?? 0);
            result += (result * 397) ^ (AuditFilePath?.GetHashCode() ?? 0);
            result += (result * 397) ^ (EnableDetailedLogging?.GetHashCode() ?? 0);
            result += (result * 397) ^ (LogFlushInterval?.GetHashCode() ?? 0);
            return result;
        }
    }
}
