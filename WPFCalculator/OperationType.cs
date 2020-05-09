using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCalculator
{
    /// <summary>
    /// The type of opearation the Calculator will perform
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// Add Two values together
        /// </summary>
        Add,

        /// <summary>
        /// Substracts a number from another
        /// </summary>
        Minus,

        /// <summary>
        /// Divides a number from another number
        /// </summary>
        Divide,

        /// <summary>
        /// Multiplies a number with another
        /// </summary>
        Multiply
    }
}
