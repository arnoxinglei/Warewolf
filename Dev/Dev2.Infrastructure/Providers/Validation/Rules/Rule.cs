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
using Dev2.Common.Interfaces.Infrastructure.Providers.Errors;
using Dev2.Common.Interfaces.Infrastructure.Providers.Validation;
using Dev2.Providers.Errors;
using Warewolf.Resource.Errors;

namespace Dev2.Providers.Validation.Rules
{
    public abstract class Rule<T> : RuleBase
    {
        protected readonly Func<T> GetValue;

        protected Rule(Func<T> getValue)
        {
            VerifyArgument.IsNotNull("getValue", getValue);
            GetValue = getValue;
        }
    }

    public abstract class RuleBase : IRuleBase
    {
        protected RuleBase()
        {
            LabelText = "";
            ErrorText = ErrorResource.InvalidValue;
        }

        public string LabelText { get; set; }
        public string ErrorText { get; set; }
        public Action DoError { get; set; }

        public abstract IActionableErrorInfo Check();

        protected IActionableErrorInfo CreatError()
        {
            var message = "";
            if (!string.IsNullOrEmpty(LabelText))
            {
                message = LabelText+" ";
            }
            return new ActionableErrorInfo(DoError)
            {
               Message = string.Format("{0}{1}", message, ErrorText)
            };
        }
    }
}
