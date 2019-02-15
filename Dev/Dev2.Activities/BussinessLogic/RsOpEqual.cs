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

namespace Dev2.DataList
{
    /// <summary>
    /// Class for the "=" recordset search option 
    /// </summary>

    public class RsOpEqual : AbstractRecsetSearchValidation
    {
        #region Overrides of AbstractRecsetSearchValidation

        public override Func<DataStorage.WarewolfAtom, bool> CreateFunc(IEnumerable<DataStorage.WarewolfAtom> values, IEnumerable<DataStorage.WarewolfAtom> from, IEnumerable<DataStorage.WarewolfAtom> to, bool all)
        {
            if (all)
            {
                return a => values.All(x => DataStorage.CompareAtoms(a,x)==0);
            }

            return a => values.Any(x =>  DataStorage.CompareAtoms(a, x) == 0);

        }

        #endregion




        public override string HandlesType() => "=";

        public override int ArgumentCount => 2;
    }
}
