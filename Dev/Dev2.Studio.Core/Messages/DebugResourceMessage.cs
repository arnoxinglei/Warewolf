/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2017 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/



using Dev2.Studio.Interfaces;

namespace Dev2.Studio.Core.Messages
{
    public class DebugResourceMessage : IMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public DebugResourceMessage(IContextualResourceModel resource)
        {
            Resource = resource;
        }

        public IContextualResourceModel Resource { get; set; }
    }
}
