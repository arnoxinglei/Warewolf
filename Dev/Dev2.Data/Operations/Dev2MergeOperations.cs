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
using System.Text;
using Dev2.Data.Interfaces;
using Dev2.Data.Interfaces.Enums;
using Warewolf.Resource.Errors;

namespace Dev2.Data.Operations
{
    public class Dev2MergeOperations : IDev2MergeOperations
    {
        #region Ctor

        public Dev2MergeOperations()
        {
            MergeData = new StringBuilder();
        }

        #endregion Ctor

        #region Properties

        public StringBuilder MergeData { get; private set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Merges the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="mergeType">Type of the merge.</param>
        /// <param name="at">At.</param>
        /// <param name="padding">The padding.</param>
        /// <param name="mergeAlignment">The merge alignment.</param>
        /// <exception cref="System.ArgumentNullException">value;The value can not be null.</exception>
        public void Merge(string value, enMergeType mergeType, string at, string padding, enMergeAlignment mergeAlignment)
        {
            if(value != null)
            {
                switch(mergeType)
                {
                    case enMergeType.Char:
                        CharMergeOp(value, at);
                        break;

                    case enMergeType.Index:
                        IndexMergeOp(value, at, padding, mergeAlignment);
                        break;

                    case enMergeType.NewLine:
                        NewLineMergeOp(value);
                        break;

                    case enMergeType.Tab:
                        TabMergeOp(value);
                        break;

                    case enMergeType.None:
                        NoneMergeOp(value);
                        break;

                    default:
                        throw new Exception(ErrorResource.ErrorInDev2MergeOperations);
                }
            }
            else
            {
                throw new ArgumentNullException("value", ErrorResource.ValueCannotBeNull);
            }

        }

        public void Merge(string value, string mergeType, string at, string padding, string align)
        {
            enMergeType mergingType;
            var mergeAlignment = enMergeAlignment.Left;

            switch (mergeType)
            {
                case "Index":
                    switch (align)
                    {
                        case "Left":
                            mergeAlignment = enMergeAlignment.Left;
                            break;

                        case "Right":
                            mergeAlignment = enMergeAlignment.Right;
                            break;
                        default:
                            break;
                    }
                    mergingType = enMergeType.Index;
                    break;

                case "Tab":
                    mergingType = enMergeType.Tab;
                    break;

                case "New Line":
                    mergingType = enMergeType.NewLine;
                    break;

                case "Chars":
                    mergingType = enMergeType.Char;
                    break;

                case "None":
                    mergingType = enMergeType.None;
                    break;

                default:
                    throw new Exception(ErrorResource.ErrorInDev2MergeOperations);
            }
            Merge(value, mergingType, at, padding, mergeAlignment);
        }

        #endregion Methods

        #region Private Methods

        #region IndexMergeOp

        /// <summary>
        /// Merge data to the class string using a index merge, mainly used for fixed width,if the index is more than the length of the value then the padding will be applyed useing the padding character
        /// </summary>
        /// <param name="value">The value that will be merged to the class string</param>
        /// <param name="at">The numeric index that will be used during the merge</param>
        /// <param name="padding">The padding character that will be used</param>
        /// <param name="mergeAlignment">The alignment used for the padding</param>
        void IndexMergeOp(string value, string at, string padding, enMergeAlignment mergeAlignment)
        {
            if (Int32.TryParse(at, out int indexToUse))
            {
                var paddedString = string.Empty;
                var difference = indexToUse - value.Length;
                if (difference >= 0)
                {
                    var padChar = string.IsNullOrEmpty(padding) || padding.Length < 1 ? ' ' : padding[0];
                    paddedString = paddedString.PadRight(difference, padChar);

                    if (mergeAlignment == enMergeAlignment.Left)
                    {
                        paddedString = paddedString.Insert(0, value);
                    }
                    else
                    {
                        paddedString += value;
                    }
                }
                else
                {
                    if (difference < 0)
                    {
                        paddedString = value.Substring(0, indexToUse);
                    }
                }

                MergeData.Append(paddedString);
            }
        }

        #endregion

        #region CharMergeOp

        /// <summary>
        /// Merge data to the class string using a Character merge, which will merge the data with the specified characters inbetween
        /// </summary>
        /// <param name="value">The value that will be merged to the class string</param>
        /// <param name="at">The Charecters that will be used as the merge token</param>
        void CharMergeOp(string value, string at)
        {
            MergeData.Append(value).Append(at);
        }

        #endregion

        #region NewLineMergeOp

        /// <summary>
        /// Merge data to the class string using a NewLine merge, which will merge the data with a new line in between
        /// </summary>
        /// <param name="value">The value that will be merged to the class string</param>
        void NewLineMergeOp(string value)
        {
            MergeData.Append(value).Append("\r\n");
        }

        #endregion

        #region TabMergeOp

        /// <summary>
        /// Merge data to the class string using a Tab merge, which will merge the data with a Tab inbetween
        /// </summary>
        /// <param name="value">The value that will be merged to the class string</param>
        void TabMergeOp(string value)
        {
            MergeData.Append(value).Append("\t");
        }

        #endregion

        #region NoneMergeOp

        /// <summary>
        /// Merge data to the class string using a None merge, which will merge the data with nothing inbetween
        /// </summary>
        /// <param name="value">The value that will be merged to the class string</param>
        void NoneMergeOp(string value)
        {
            MergeData.Append(value);
        }

        #endregion

        #endregion Private Methods
    }
}
