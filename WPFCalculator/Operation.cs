using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCalculator
{

    /// <summary>
    /// Holds some information about a single calculator operation
    /// </summary>
    public class Operation
    {

        #region Public Properties


        /// <summary>
        /// Left side of the operation
        /// </summary>
        public string LeftSide { get; set; }

        /// <summary>
        /// Right side of the operation
        /// </summary
        public string RightSide { get; set; }

        /// <summary>
        /// The type of operation to perform
        /// </summary>
        public OperationType OperationType { get; set; }

        /// <summary>
        /// The Inner opration to be performed initially before thid operation
        /// </summary>
        public Operation InnerOperation { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Operation()
        {
            //Create empty strings instead of having just nulls
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }
        #endregion
    }
}
