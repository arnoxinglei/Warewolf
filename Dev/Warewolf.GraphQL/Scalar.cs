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

using GraphQL.Types;

namespace Warewolf.GraphQL
{
    public class Scalar
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class ScalarType : ObjectGraphType<Scalar>
    {
        public ScalarType()
        {
            Field(s => s.Name);
            Field(s => s.Value);
        }
    }
}